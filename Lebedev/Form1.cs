using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lebedev
{
    public partial class Form1 : Form
    {
        DBConnect db = new DBConnect();
        DataTable tovar;
        int counter;
        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            db.openConn();
            var reader = new SqlCommand("SELECT * FROM products_b_import", db.getConn()).ExecuteReader();

            tovar = new DataTable();
            tovar.Load(reader);
            counter = 0;

            GetData(counter);
        }

        public void GetData(int counter)
        {
            label1.Text = tovar.Rows[counter][4].ToString(); //Тип продукта
            label3.Text = tovar.Rows[counter][0].ToString(); //Наименование продукта
            label4.Text = tovar.Rows[counter][1].ToString(); //Артикул
            label7.Text = tovar.Rows[counter][2].ToString(); //Стоимость
            //label5.Text = "Материалы: " + tovar.Rows[counter][4].ToString(); //Материалы
            pictureBox1.Image = Image.FromFile(tovar.Rows[counter][3].ToString()); //Картинка

            label14.Text = tovar.Rows[counter + 1][4].ToString(); 
            label12.Text = tovar.Rows[counter + 1][0].ToString(); 
            label11.Text = tovar.Rows[counter + 1][1].ToString(); 
            label8.Text = tovar.Rows[counter + 1][2].ToString(); 
            //label10.Text = "Материалы: " + tovar.Rows[counter + 1][4].ToString();
            pictureBox2.Image = Image.FromFile(tovar.Rows[counter + 1][3].ToString());

            label28.Text = tovar.Rows[counter + 2][4].ToString();
            label26.Text = tovar.Rows[counter + 2][0].ToString();
            label25.Text = tovar.Rows[counter + 2][1].ToString();
            label22.Text = tovar.Rows[counter + 2][2].ToString();
            //label24.Text = "Материалы: " + tovar.Rows[counter + 2][4].ToString();
            pictureBox4.Image = Image.FromFile(tovar.Rows[counter + 2][3].ToString());

            label21.Text = tovar.Rows[counter + 3][4].ToString();
            label19.Text = tovar.Rows[counter + 3][0].ToString();
            label18.Text = tovar.Rows[counter + 3][1].ToString();
            label15.Text = tovar.Rows[counter + 3][2].ToString();
            //label17.Text = "Материалы: " + tovar.Rows[counter + 3][4].ToString();
            pictureBox3.Image = Image.FromFile(tovar.Rows[counter + 3][3].ToString());

            label56.Text = tovar.Rows[counter + 4][4].ToString();
            label54.Text = tovar.Rows[counter + 4][0].ToString();
            label53.Text = tovar.Rows[counter + 4][1].ToString();
            label50.Text = tovar.Rows[counter + 4][2].ToString();
            //label52.Text = "Материалы: " + tovar.Rows[counter + 4][4].ToString();
            pictureBox8.Image = Image.FromFile(tovar.Rows[counter + 4][3].ToString());

            label49.Text = tovar.Rows[counter + 5][4].ToString();
            label47.Text = tovar.Rows[counter + 5][0].ToString();
            label46.Text = tovar.Rows[counter + 5][1].ToString();
            label43.Text = tovar.Rows[counter + 5][2].ToString();
            //label45.Text = "Материалы: " + tovar.Rows[counter + 5][4].ToString();
            pictureBox7.Image = Image.FromFile(tovar.Rows[counter + 5][3].ToString());

            label42.Text = tovar.Rows[counter + 6][4].ToString();
            label40.Text = tovar.Rows[counter + 6][0].ToString();
            label39.Text = tovar.Rows[counter + 6][1].ToString();
            label36.Text = tovar.Rows[counter + 6][2].ToString();
            //label38.Text = "Материалы: " + tovar.Rows[counter + 6][4].ToString();
            pictureBox6.Image = Image.FromFile(tovar.Rows[counter + 6][3].ToString());

            label35.Text = tovar.Rows[counter + 7][4].ToString();
            label33.Text = tovar.Rows[counter + 7][0].ToString();
            label32.Text = tovar.Rows[counter + 7][1].ToString();
            label29.Text = tovar.Rows[counter + 7][2].ToString();
            //label31.Text = "Материалы: " + tovar.Rows[counter + 7][4].ToString();
            pictureBox5.Image = Image.FromFile(tovar.Rows[counter + 7][3].ToString());

            label112.Text = tovar.Rows[counter + 8][4].ToString();
            label110.Text = tovar.Rows[counter + 8][0].ToString();
            label109.Text = tovar.Rows[counter + 8][1].ToString();
            label106.Text = tovar.Rows[counter + 8][2].ToString();
            //label108.Text = "Материалы: " + tovar.Rows[counter + 8][4].ToString();
            pictureBox16.Image = Image.FromFile(tovar.Rows[counter + 8][3].ToString());

            label105.Text = tovar.Rows[counter + 9][4].ToString();
            label103.Text = tovar.Rows[counter + 9][0].ToString();
            label102.Text = tovar.Rows[counter + 9][1].ToString();
            label99.Text = tovar.Rows[counter + 9][2].ToString();
            //label101.Text = "Материалы: " + tovar.Rows[counter + 9][4].ToString();
            pictureBox15.Image = Image.FromFile(tovar.Rows[counter + 9][3].ToString());

            label98.Text = tovar.Rows[counter + 10][4].ToString();
            label96.Text = tovar.Rows[counter + 10][0].ToString();
            label95.Text = tovar.Rows[counter + 10][1].ToString();
            label92.Text = tovar.Rows[counter + 10][2].ToString();
            //label94.Text = "Материалы: " + tovar.Rows[counter + 10][4].ToString();
            pictureBox14.Image = Image.FromFile(tovar.Rows[counter + 10][3].ToString());

            label91.Text = tovar.Rows[counter + 11][4].ToString();
            label89.Text = tovar.Rows[counter + 11][0].ToString();
            label88.Text = tovar.Rows[counter + 11][1].ToString();
            label85.Text = tovar.Rows[counter + 11][2].ToString();
            //label87.Text = "Материалы: " + tovar.Rows[counter + 11][4].ToString();
            pictureBox13.Image = Image.FromFile(tovar.Rows[counter + 11][3].ToString());

            label84.Text = tovar.Rows[counter + 12][4].ToString();
            label82.Text = tovar.Rows[counter + 12][0].ToString();
            label81.Text = tovar.Rows[counter + 12][1].ToString();
            label78.Text = tovar.Rows[counter + 12][2].ToString();
            //label80.Text = "Материалы: " + tovar.Rows[counter + 12][4].ToString();
            pictureBox12.Image = Image.FromFile(tovar.Rows[counter + 12][3].ToString());

            label77.Text = tovar.Rows[counter + 13][4].ToString();
            label75.Text = tovar.Rows[counter + 13][0].ToString();
            label74.Text = tovar.Rows[counter + 13][1].ToString();
            label71.Text = tovar.Rows[counter + 13][2].ToString();
            //label73.Text = "Материалы: " + tovar.Rows[counter + 13][4].ToString();
            pictureBox11.Image = Image.FromFile(tovar.Rows[counter + 13][3].ToString());

            label70.Text = tovar.Rows[counter + 14][4].ToString();
            label68.Text = tovar.Rows[counter + 14][0].ToString();
            label67.Text = tovar.Rows[counter + 14][1].ToString();
            label64.Text = tovar.Rows[counter + 14][2].ToString();
            //label66.Text = "Материалы: " + tovar.Rows[counter + 14][4].ToString();
            pictureBox10.Image = Image.FromFile(tovar.Rows[counter + 14][3].ToString());

            label63.Text = tovar.Rows[counter + 15][4].ToString();
            label61.Text = tovar.Rows[counter + 15][0].ToString();
            label60.Text = tovar.Rows[counter + 15][1].ToString();
            label57.Text = tovar.Rows[counter + 15][2].ToString();
            //label59.Text = "Материалы: " + tovar.Rows[counter + 15][4].ToString();
            pictureBox9.Image = Image.FromFile(tovar.Rows[counter + 15][3].ToString());

            label140.Text = tovar.Rows[counter + 16][4].ToString();
            label138.Text = tovar.Rows[counter + 16][0].ToString();
            label137.Text = tovar.Rows[counter + 16][1].ToString();
            label134.Text = tovar.Rows[counter + 16][2].ToString();
            //label136.Text = "Материалы: " + tovar.Rows[counter + 16][4].ToString();
            pictureBox20.Image = Image.FromFile(tovar.Rows[counter + 16][3].ToString());

            label133.Text = tovar.Rows[counter + 17][4].ToString();
            label131.Text = tovar.Rows[counter + 17][0].ToString();
            label130.Text = tovar.Rows[counter + 17][1].ToString();
            label127.Text = tovar.Rows[counter + 17][2].ToString();
            //label129.Text = "Материалы: " + tovar.Rows[counter + 17][4].ToString();
            pictureBox19.Image = Image.FromFile(tovar.Rows[counter + 17][3].ToString());

            label126.Text = tovar.Rows[counter + 18][4].ToString();
            label124.Text = tovar.Rows[counter + 18][0].ToString();
            label123.Text = tovar.Rows[counter + 18][1].ToString();
            label120.Text = tovar.Rows[counter + 18][2].ToString();
            //label122.Text = "Материалы: " + tovar.Rows[counter + 18][4].ToString();
            pictureBox18.Image = Image.FromFile(tovar.Rows[counter + 18][3].ToString());

            label119.Text = tovar.Rows[counter + 19][4].ToString();
            label117.Text = tovar.Rows[counter + 19][0].ToString();
            label116.Text = tovar.Rows[counter + 19][1].ToString();
            label113.Text = tovar.Rows[counter + 19][2].ToString();
            //label115.Text = "Материалы: " + tovar.Rows[counter + 19][4].ToString();
            pictureBox17.Image = Image.FromFile(tovar.Rows[counter + 19][3].ToString());
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (counter > 0)
            {
                counter -= 20; //Назад
            }
            GetData(counter);
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (counter < tovar.Rows.Count - 20)
            {
                counter += 20; //Вперед
            }
            GetData(counter);
        }

        private void поВозрастаниюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            db.openConn();
            var reader = new SqlCommand("SELECT * FROM products_b_import ORDER BY Наименование_продукции ASC", db.getConn()).ExecuteReader();

            tovar = new DataTable();
            tovar.Load(reader);
            counter = 0;

            GetData(counter);
        }

        private void поУбываниюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            db.openConn();
            var reader = new SqlCommand("SELECT * FROM products_b_import ORDER BY Наименование_продукции DESC", db.getConn()).ExecuteReader();

            tovar = new DataTable();
            tovar.Load(reader);
            counter = 0;

            GetData(counter);
        }

        private void всеТипыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            db.openConn();
            var reader = new SqlCommand("SELECT * FROM products_b_import", db.getConn()).ExecuteReader();

            tovar = new DataTable();
            tovar.Load(reader);
            counter = 0;

            GetData(counter);
        }

        private void одинСлойToolStripMenuItem_Click(object sender, EventArgs e)
        {
            db.openConn();
            var reader = new SqlCommand("SELECT * FROM products_b_import WHERE CONCAT (Тип_продукции, Тип_продукции) LIKE '%" + "Один слой" + "%'", db.getConn()).ExecuteReader();

            tovar = new DataTable();
            tovar.Load(reader);
            counter = 0;

            GetData(counter);
        }

        private void дваСлояToolStripMenuItem_Click(object sender, EventArgs e)
        {
            db.openConn();
            var reader = new SqlCommand("SELECT * FROM products_b_import WHERE Тип_продукции = 'Два слоя'", db.getConn()).ExecuteReader();

            tovar = new DataTable();
            tovar.Load(reader);
            counter = 0;

            GetData(counter);
        }

        private void триСлояToolStripMenuItem_Click(object sender, EventArgs e)
        {
            db.openConn();
            var reader = new SqlCommand("SELECT * FROM products_b_import WHERE Тип_продукции = 'Три слоя'", db.getConn()).ExecuteReader();

            tovar = new DataTable();
            tovar.Load(reader);
            counter = 0;

            GetData(counter);
        }

        private void детскаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            db.openConn();
            var reader = new SqlCommand("SELECT * FROM products_b_import WHERE Тип_продукции = 'Детская'", db.getConn()).ExecuteReader();

            tovar = new DataTable();
            tovar.Load(reader);
            counter = 0;

            GetData(counter);
        }

        private void суперМягкаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            db.openConn();
            var reader = new SqlCommand("SELECT * FROM products_b_import WHERE Тип_продукции = 'Супер мягкая'", db.getConn()).ExecuteReader();

            tovar = new DataTable();
            tovar.Load(reader);
            counter = 0;

            GetData(counter);
        }
    }
}
