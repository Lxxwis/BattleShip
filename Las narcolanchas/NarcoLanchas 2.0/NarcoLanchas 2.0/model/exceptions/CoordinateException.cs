﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NarcoLanchas_2._0.model.exceptions
{
    public abstract class CoordinateException : BattleshipException
    {
        protected Coordinate coord;

        public CoordinateException(Coordinate c)
        {
            coord = c;
        }

        public string GetMessage()
        {
            return $"CoordinateException: An exception occurred in coordinate {coord}";
        }
    }
}
