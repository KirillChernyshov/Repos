using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL;

namespace _2._1._29
{
    /* Задача 2.1.29
        Найти расстановку 5 ферзей, при которой каждое поле шахматной
        доски будет находиться под ударом хотя бы одного из них.
    */
    public partial class Form1 : Form
    {
        SearchOfLocationQueens searching;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chessBoard.RowCount = 8;
            chessBoard.ColumnCount = 8;
            chessBoard.ClearSelection();

            searching = new SearchOfLocationQueens();
        }

        private void start_Click(object sender, EventArgs e)
        {
            CellOfChessBoard[,] cells = searching.ArrangementOfQueens();
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                    chessBoard.Rows[i].Cells[j].Style.BackColor = cells[i, j].Color;
            }
        }

    }
}
