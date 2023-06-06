using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NarcoLanchas_2._0.model.exceptions
{
    public class NextToAnotherCraftException : CoordinateException
    {
        public NextToAnotherCraftException(Coordinate c) : base(c)
        {
        }

        public new string GetMessage()
        {
            return $"NextToAnotherCraftException: coordinate {coord} is a coordinate that is already occupied by a another craft";
        }
    }
}
