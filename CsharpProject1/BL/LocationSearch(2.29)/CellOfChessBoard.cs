using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class CellOfChessBoard
    {
        public bool Queen { get; set; }
        public bool UnderAttack { get; set; }
        public int Circle { get; set; }
        public System.Drawing.Color Color { get; set; }

        public CellOfChessBoard(int circle)
        {
            Circle = circle;
        }
    }
}
