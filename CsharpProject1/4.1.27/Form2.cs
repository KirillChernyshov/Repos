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

namespace _4._1._27
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        public void FillGrid(Apartment[] apartments)
        {
            apGrid.Rows.Clear();
            for (int i = 0; i < apartments.Length; i++)
            {
                apGrid.Rows.Add();
                apGrid.Rows[i].Cells[0].Value = apartments[i].District;
                apGrid.Rows[i].Cells[1].Value = apartments[i].Floor;
                apGrid.Rows[i].Cells[2].Value = apartments[i].AmountOfRooms;
                apGrid.Rows[i].Cells[3].Value = apartments[i].Area;
                apGrid.Rows[i].Cells[4].Value = apartments[i].PricePerSquareMeter;
                apGrid.Rows[i].Cells[5].Value = apartments[i].OverallPriority;
            }
        }
    }
}
