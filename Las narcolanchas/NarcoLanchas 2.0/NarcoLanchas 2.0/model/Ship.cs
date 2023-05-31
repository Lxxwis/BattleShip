using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NarcoLanchas_2._0.model
{
    public class Ship
    {
        private Orientation orientation;
        private char symbol;
        private string name;
        private Coordinate position;
        private int[][] shape;

        public Ship(Orientation orientation, char symbol, string name)
        {
            this.orientation = orientation;
            this.symbol = symbol;
            this.name = name;
            this.shape = new int[][]
                {
            new int[] {
                0, 0, 0, 0, 0, // NORTH .....
                0, 0, 1, 0, 0, // ..#..
                0, 0, 1, 0, 0, // ..#..
                0, 0, 1, 0, 0, // ..#..
                0, 0, 0, 0, 0 // .....
                },

            new int[] {
                0, 0, 0, 0, 0, // EAST .....
                0, 0, 0, 0, 0, // .....
                0, 1, 1, 1, 0, // .###.
                0, 0, 0, 0, 0, // .....
                0, 0, 0, 0, 0 // .....
                },

            new int[] {
                0, 0, 0, 0, 0, // SOUTH .....
                0, 0, 1, 0, 0, // ..#..
                0, 0, 1, 0, 0, // ..#..
                0, 0, 1, 0, 0, // ..#..
                0, 0, 0, 0, 0 // .....
                },

            new int[] {
                0, 0, 0, 0, 0, // WEST .....
                0, 0, 0, 0, 0, // .....
                0, 1, 1, 1, 0, // .###.
                0, 0, 0, 0, 0, // .....
                0, 0, 0, 0, 0 // .....
                }
         };

        }

        public void SetPosition(Coordinate position)
        {
            this.position = position.Copy();
        }

        public Coordinate GetPosition()
        {
            if (position == null)
                return null;
            else
                return position.Copy();
        }

        public String GetName()
        {
            return name;
        }



        public int[][] GetShape()
        {
            return shape;
        }
    }
}
