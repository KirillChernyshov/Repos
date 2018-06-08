using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL;

namespace _1._2._29
{
    /* Задача 1.2.29
        Дан файл вещественных чисел. 
        Поменять в нем местами минимальный и максимальный элементы.
    */
    public partial class Form1 : Form
    {
        OpenFileDialog fileDialog = new OpenFileDialog();
        NumericSwap nSwap;
        string path;

        public Form1()
        {
            InitializeComponent();
            fileDialog.InitialDirectory = Path.Combine(Application.StartupPath, @"Files");
            fileDialog.Filter = "Data files | *.dat";
        }

        private void selectFile_Click(object sender, EventArgs e)
        {
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                path = fileDialog.FileName;
                List<double> dList = WorkWithBFile.ReadOfDouble(path);
                nSwap = new NumericSwap(dList);
                windowOfContent.Text = string.Join(" ", dList);
                swap.Visible = true;
            }
        }

        private void swap_Click(object sender, EventArgs e)
        {
            List<double> dList = nSwap.SwapMinMax();
            windowOfContent.Text = string.Join(" ", dList);
            WorkWithBFile.WriteOfDouble(dList, path);
            windowOfContent.Text = string.Join(" ", dList);
        }
    }
}
