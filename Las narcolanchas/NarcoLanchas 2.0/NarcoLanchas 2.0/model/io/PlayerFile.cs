using NarcoLanchas_2._0.model.exceptions.io;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NarcoLanchas_2._0.model.io
{
    public class PlayerFile : IPlayer
    {
        private string name;
        private string[] commands;
        private int indexCommand;

        public PlayerFile(string name, string filename)
        {
            this.name = name;

            try
            {
                commands = File.ReadAllLines(filename);
                //foreach (string line in commands)
                //    MessageBox.Show(line);
            }
            catch (IOException)
            {
                throw new BattleshipIOException("Error reading commands.");
            }

            indexCommand = 0;
        }

        public string GetName()
        {
            return $"{name} ({GetType().Name})";
        }

        public Coordinate NextShoot(Board b)
        {
            throw new NotImplementedException();
        }

        public void PutCrafts(Board b)
        {
            if (b is null)
                throw new ArgumentNullException();

            HashSet<string> comandos = new HashSet<string>()
            {
                "put",
                "endput",
                "exit"
            };

            bool isExit = false;
            bool isEndPut = false;

            string typeCraft;
            Orientation typeOrientation;

            while (indexCommand < commands.Length && !isExit && !isEndPut)
            {
                Regex re = new Regex(@"[\s]+");
                string[] cmd = re.Split(commands[indexCommand++]);

                if (comandos.Contains(cmd[0]))
                {
                    switch (cmd[0])
                    {
                        case "put":
                            if (cmd.Length < 5 || cmd.Length > 6)
                                throw new BattleshipIOException("Error: number of params incorrect");
                            else
                            {
                                typeCraft = cmd[1];

                                try
                                {
                                    typeOrientation = (Orientation)Enum.Parse(typeof(Orientation), cmd[2]);
                                }
                                catch (ArgumentException)
                                {
                                    throw new BattleshipIOException("Error: orientation wrong");
                                }

                                Craft craft = CraftFactory.CreateCraft(typeCraft, typeOrientation);

                                Coordinate position;

                                try
                                {
                                    int x = int.Parse(cmd[3]);
                                    int y = int.Parse(cmd[4]);

                                    if (cmd.Length == 5)    // Coordinate2D
                                        position = CoordinateFactory.CreateCoordinate(x, y);
                                    else                    // Coordinate3D
                                    {
                                        int z = int.Parse(cmd[5]);
                                        position = CoordinateFactory.CreateCoordinate(x, y, z);
                                    }

                                    b.AddCraft(craft, position);
                                }
                                catch (FormatException)
                                {
                                    throw new BattleshipIOException("Error: coordinate not valid");
                                }
                            }
                            break;
                        case "endput":
                            isEndPut = true;
                            break;
                        case "exit":
                            isExit = true;
                            break;
                    }
                }
                else
                    throw new BattleshipIOException($"Error: command {cmd[0]} not found");
            }
        }
    }
}
