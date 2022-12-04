using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 学生管理系统
{
    public partial class Student : Form
    {

        public Student()
        {
            InitializeComponent();
            table();
        }
        public void table()
        {
            dataGridView2.Rows.Clear();//清空控件中已有数据
            Dao lj = new Dao();
            string sql = " select * from Courses";
            IDataReader dc = lj.read(sql);
            while (dc.Read())
            {
                dataGridView2.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString());
            }
            dc.Close();
            lj.LJClose();
        }
        public void tableSno()
        {
            dataGridView1.Rows.Clear();//清空控件中已有数据
            Dao lj = new Dao();
            string sql = $" select * from SC where Sno='{textBox1.Text}'";
            IDataReader dc = lj.read(sql);
            while (dc.Read())
            {
                dataGridView1.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString());
            }
            dc.Close();
            lj.LJClose();
        }
        public void tableCno()
        {
            dataGridView2.Rows.Clear();//清空控件中已有数据
            Dao lj = new Dao();
            string sql = $" select * from courses where Cno='{textBox2.Text}'";
            IDataReader dc = lj.read(sql);
            while (dc.Read())
            {
                dataGridView2.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString());
            }
            dc.Close();
            lj.LJClose();
        }
        public void SAC()
        {
            dataGridView3.Rows.Clear();//清空控件中已有数据
            Dao lj = new Dao();
            string sql1 = $" select sum(score)  from SC where Sno = '{textBox3.Text}'";
            string sql2 = $" select AVG(score)  from SC where Sno = '{textBox3.Text}'";
            string sql3 = $" select count(cno) from sc where score < 60 and Sno= '{textBox3.Text}'";
            IDataReader dc1 = lj.read(sql1);
            IDataReader dc2 = lj.read(sql2);
            IDataReader dc3 = lj.read(sql3);
            while (dc1.Read()&&dc2.Read()&&dc3.Read())
            {
                dataGridView3.Rows.Add(dc1[0].ToString(), dc2[0].ToString(), dc3[0].ToString());
            }

        }
       /* public void tableSUM()
        {
            dataGridView3.Rows.Clear();//清空控件中已有数据
            Dao lj = new Dao();
            string sql = $" select sum(score)  from SC where Sno = '{textBox3.Text}'";
            IDataReader dc = lj.read(sql);
            while (dc.Read())
            {
                dataGridView3.Rows.Add(dc[0].ToString());
            }
            dc.Close();
            lj.LJClose();
        }
        public void tableAVG()
        {
            dataGridView3.Rows.Clear();//清空控件中已有数据
            Dao lj = new Dao();
            string sql = $" select AVG(score)  from SC where Sno = '{textBox3.Text}'";
            IDataReader dc = lj.read(sql);
            while (dc.Read())
            {
                dataGridView3.Rows.Add(dc[1].ToString());
            }
            dc.Close();
            lj.LJClose();
        }
        public void tableCOUNTnot()
        {
            dataGridView3.Rows.Clear();//清空控件中已有数据
            Dao lj = new Dao();
            string sql = $" select count(cno) from sc where score < 60 and Sno= '{textBox3.Text}'";
            IDataReader dc = lj.read(sql);
            while (dc.Read())
            {
                dataGridView3.Rows.Add(dc[2].ToString());
            }
            dc.Close();
            lj.LJClose();
        }*/
        private void button1_Click(object sender, EventArgs e)
        {
            tableSno();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            tableCno();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SAC();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

