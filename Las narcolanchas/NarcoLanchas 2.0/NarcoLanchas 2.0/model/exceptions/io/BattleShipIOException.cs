using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NarcoLanchas_2._0.model.exceptions.io
{
    public class BattleshipIOException : BattleshipException
    {
        private string message;
        public BattleshipIOException(string message)
        {
            this.message = message;
        }

        public string GetMessage()
        {
            return $"BattleshipIOException: Exception IO occurred: {message}";
        }
    }
}
