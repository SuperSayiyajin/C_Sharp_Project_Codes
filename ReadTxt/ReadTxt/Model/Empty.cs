﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadTxt.Model
{
    class Empty : ChessPiece
    {
        public Empty(string name, bool isdestroyed, float point) : base(name, isdestroyed, point)
        {
        }

        public override List<Index> calculate(Index index)
        {
            return new List<Index>();
        }
    }
}
