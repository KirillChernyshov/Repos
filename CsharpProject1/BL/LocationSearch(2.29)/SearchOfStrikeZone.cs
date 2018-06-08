using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class SearchOfStrikeZone
    {
        int IncrementX { get; set; }
        int IncrementY { get; set; }
        List<int[]> Pos { get; set; } // Список координат ячеек

        public SearchOfStrikeZone(int incX, int incY)
        {
            IncrementX = incX;
            IncrementY = incY;
            Pos = new List<int[]>();
        }

        public List<int[]> SearchPosOfCells(int x, int y) //Возвращает x, y
        {
            int[] pos = new int[2];

            if (x < 7 && x > 0 && y < 7 && y > 0)
            {
                pos[0] = x + IncrementX;
                pos[1] = y + IncrementY;
                Pos.Add(pos);
                SearchPosOfCells(pos[0], pos[1]);
            }

            return Pos;
        }
    }
}
