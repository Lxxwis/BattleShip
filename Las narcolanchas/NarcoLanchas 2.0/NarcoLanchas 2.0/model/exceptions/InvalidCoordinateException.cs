using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NarcoLanchas_2._0.model.exceptions
{
    public class InvalidCoordinateException : CoordinateException
    {
        public InvalidCoordinateException(Coordinate c) : base(c)
        {
        }

        public new string GetMessage()
        {
            return $"InvalidCoordinateException: coordinate {coord} is out of bounds";
        }
    }
}
