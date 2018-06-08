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

namespace _3._1._29
{
    /* Задача 3.1.29
        Написать программу для вычисления значения выражения, 
        представленного в обратной польской записи.
    */
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void start_Click(object sender, EventArgs e)
        {
            string exp = textBox.Text;
            ReversePolishNotation rev = new ReversePolishNotation(exp);
            double r = rev.HandlerOfExpression();
            textBox.Text = r.ToString();
        }
    }
}
