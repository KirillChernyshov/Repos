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

namespace _1._3._14
{
    /* Задача 1.3.14
        Вывести студента с наименьшим средним баллом на каждом курсе.
    */
    public partial class Form1 : Form
    {
        OpenFileDialog fileDialog = new OpenFileDialog();
        Student[] students;

        public Form1()
        {
            InitializeComponent();
            fileDialog.InitialDirectory = Path.Combine(Application.StartupPath, @"Files");
            fileDialog.Filter = "Data files | *.dat";
        }

        private void chooseFile_Click(object sender, EventArgs e)
        {
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = fileDialog.FileName;
                StudentsInBFile studentsB = new StudentsInBFile(path);
                students = studentsB.Read();
                FillTable(students);
                show.Visible = true;
                label1.Visible = true;
            }
        }

        private void show_Click(object sender, EventArgs e)
        {
            SortOfStudents stud = new SortOfStudents(students);
            IList<Student> uns = stud.StudetsWithMinMark();
            FillTable(uns);
        }

        void FillTable(IList<Student> students)
        {
            studentsGrid.Rows.Clear();
            for (int i = 0; i < students.Count; i++)
            {
                studentsGrid.Rows.Add();
                studentsGrid.Rows[i].Cells[0].Value = students[i].FIO;
                studentsGrid.Rows[i].Cells[1].Value = students[i].Year;
                for (int j = 0; j < students[i].MedB.Length; j++)
                    studentsGrid.Rows[i].Cells[2].Value += students[i].MedB[j] + "; ";
                studentsGrid.Rows[i].Cells[3].Value = students[i].Course;
                studentsGrid.Rows[i].Cells[4].Value = students[i].Group;
                studentsGrid.Rows[i].Cells[5].Value = students[i].AverageRating;
            }
        }
    }
}
