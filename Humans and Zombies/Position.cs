using System;
using System.Collections.Generic;
using System.Text;

namespace Humans_and_Zombies
{
    class Position
    {
        public int Row { get; set; }
        public int Column { get; set; }

        public Position(int row, int column)
        {
            Row = row;
            Column = column;
        }
    }
}
