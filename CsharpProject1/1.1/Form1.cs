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

namespace _1._1
{
    /* Задача 1.1.29
        Дан текстовый файл NameT и файл целых чисел NameN. 
        Добавить в начало1|конец2 каждой строки файла NameT 
        изображение соответствующего числа из файла NameN. 
        Если файл NameN короче файла NameT, то оставшиеся строки
        файла NameT не изменять. 
    */
    public partial class Form1 : Form
    {
        OpenFileDialog DialogWindowForTextFile;
        OpenFileDialog DialogWindowForNumFile;
        string strPathToFile;
        string intPathToFile;

        AddingNumbersToText adding;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DialogWindowForTextFile = new OpenFileDialog();
            DialogWindowForNumFile = new OpenFileDialog();
            DialogWindowForTextFile.InitialDirectory = System.IO.Path.Combine(Application.StartupPath, @"Files");
            DialogWindowForNumFile.InitialDirectory = System.IO.Path.Combine(Application.StartupPath, @"Files");
        }

        private void ChooseTextFile_Click(object sender, EventArgs e)
        {
            if (DialogWindowForTextFile.ShowDialog() == DialogResult.OK)
            {
                strPathToFile = DialogWindowForTextFile.FileName;
                richTextBox1.Text = WorkWithTxt.ShowFile(strPathToFile);
                CheckFiles();
            }
        }

        private void ChooseNumFile_Click(object sender, EventArgs e)
        {
            if (DialogWindowForNumFile.ShowDialog() == DialogResult.OK)
            {
                intPathToFile = DialogWindowForNumFile.FileName;
                CheckFiles();
            }
        }

        private void AddtoEndBtn_Click(object sender, EventArgs e)
        {
            List<string> strList = WorkWithTxt.ReadingString(strPathToFile);
            WorkWithTxt.Write(adding.AddTotheEnd(strList), strPathToFile);
            richTextBox1.Text = WorkWithTxt.ShowFile(strPathToFile);
        }

        private void AddtoSrartBtn_Click(object sender, EventArgs e)
        {
            List<string> strList = WorkWithTxt.ReadingString(strPathToFile);
            WorkWithTxt.Write(adding.AddTotheBegining(strList), strPathToFile);
            richTextBox1.Text = WorkWithTxt.ShowFile(strPathToFile);
        }

        private void CheckFiles()
        {
            if (strPathToFile != null && intPathToFile != null)
            {
                List<int> intList = WorkWithTxt.ReadingInteger(intPathToFile);
                adding = new AddingNumbersToText(intList);

                AddtoEndBtn.Visible = true;
                AddtoSrartBtn.Visible = true;
            }
        }
    }
}
