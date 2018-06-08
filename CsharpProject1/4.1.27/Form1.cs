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
    /* Задача 4.1.27
        Информация агентства по продаже недвижимости содержит следующие сведения о квартирах:
            ü район, в котором находится квартира,
            ü этаж,
            ü количество комнат,
            ü общая площадь,
            ü цена за 1 м2.
        Клиент, обращаясь в агентство, имеет возможность указать вес для каждого из критериев 
        (важный критерий имеет большой вес, незначительный – маленький), а агентство, в свою очередь, 
        предлагает ему список квартир, упорядоченный по невозрастанию суммы весов.
    */
    public partial class Form1 : Form
    {
        Form2 newWin = new Form2();
        Apartment[] apartments;

        public Form1()
        {
            InitializeComponent();
            ApartmentGenerator gen = new ApartmentGenerator();
            apartments = gen.Generate(500);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<Query> query = new List<Query>();
            query.Add(new Query("Район", district.Text, (int)districtP.Value));
            query.Add(new Query("Этаж", floor.Text, (int)floorP.Value));
            query.Add(new Query("Комнат", rooms.Text, (int)roomsP.Value));
            query.Add(new Query("Площадь", area.Text, (int)areaP.Value));
            query.Add(new Query("Цена", price.Text, (int)priceP.Value));

            FillGrid(query);

            SortingApartments sort = new SortingApartments(apartments);
            if (!newWin.Visible)
                newWin = new Form2();
            newWin.FillGrid(sort.SortApartments(query));
            newWin.Show();
        }

        void FillGrid(List<Query> query)
        {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < query.Count; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = query[i].Criterion;
                dataGridView1.Rows[i].Cells[1].Value = query[i].Value;
                dataGridView1.Rows[i].Cells[2].Value = query[i].Priority;
            }
        }
    }
}
