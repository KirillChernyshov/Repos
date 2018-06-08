using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    /* Задача 2.1.29
        Найти расстановку 5 ферзей, при которой каждое поле шахматной
        доски будет находиться под ударом хотя бы одного из них.
    */
    public class SearchOfLocationQueens
    {
        CellOfChessBoard[,] Cells { get; set; }
        SearchOfStrikeZone[] SerchEngineOfCells { get; set; }

        int queens = 5;

        public SearchOfLocationQueens()
        {
            Generate();
            InitSearhEngineOfCells();
        }

        public CellOfChessBoard[,] ArrangementOfQueens()
        {
            int circle = 4;
            while (queens > 0)
            {
                searchPosForQeen(circle--);
            }

            return Cells;
        }

        void searchPosForQeen(int circle)
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (Cells[i, j].Circle == circle && !Cells[i, j].Queen && !Cells[i, j].UnderAttack && queens > 0)
                    {
                        Cells[i, j].Queen = true;
                        Cells[i, j].Color = System.Drawing.Color.Red;
                        queens--;
                        SearhOfStrikeZone(i, j);
                    }
                }
            }
        }

        void SearhOfStrikeZone(int x, int y)
        {
            for (int direction = 0; direction < SerchEngineOfCells.Length; direction++)
            {
                List<int[]> pos = SerchEngineOfCells[direction].SearchPosOfCells(x, y);

                for (int i = 0; i < pos.Count; i++)
                {
                    int X = pos[i][0];
                    int Y = pos[i][1];

                    Cells[X, Y].UnderAttack = true;
                    if (!Cells[X, Y].Queen)
                        Cells[X, Y].Color = System.Drawing.Color.Green;
                }
            }
        }


        void Generate()
        {
            Cells = new CellOfChessBoard[8, 8];
            int circle = 1;

            for (int i = 0; i < 8; i++)
            {
                circle = 0;
                for (int j = 0; j < 8; j++)
                {
                    if (i < 4)
                    {
                        if (j > 7 - i)
                            circle--;
                        else
                        {
                            circle = (i < j) ? i + 1 : j + 1;
                        }
                    }
                    else
                    {
                        if (j > i)
                            circle--;
                        else
                        {
                            if (j < 8 - i)
                                circle++;
                        }
                    }

                    Cells[i, j] = new CellOfChessBoard(circle);
                }
            }
        }

        void InitSearhEngineOfCells()
        {
            SearchOfStrikeZone[] serchEngineOfCells = new SearchOfStrikeZone[8];
            serchEngineOfCells[0] = new SearchOfStrikeZone(0, -1); // N
            serchEngineOfCells[1] = new SearchOfStrikeZone(1, -1); // N E
            serchEngineOfCells[2] = new SearchOfStrikeZone(1, 0);  // E
            serchEngineOfCells[3] = new SearchOfStrikeZone(1, 1);  // S E
            serchEngineOfCells[4] = new SearchOfStrikeZone(0, 1);  // S
            serchEngineOfCells[5] = new SearchOfStrikeZone(-1, 1); // S W
            serchEngineOfCells[6] = new SearchOfStrikeZone(-1, 0); // W
            serchEngineOfCells[7] = new SearchOfStrikeZone(-1, -1);// N W
            SerchEngineOfCells = serchEngineOfCells;
        }
    }
}
