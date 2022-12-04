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
    public partial class Teacher1 : Form
    {
        public Teacher1()
        {
            InitializeComponent();
            table();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }
        //读取数据显示于表格
        public void table()
        {
            dataGridView1.Rows.Clear();//清空控件中已有数据
            Dao lj = new Dao();
            string sql = " select * from SC";
            IDataReader dc = lj.read(sql);
            while (dc.Read())
            {
                dataGridView1.Rows.Add(dc[0].ToString(),dc[1].ToString(),dc[2].ToString());
            }
            dc.Close();
            lj.LJClose();
        }
        public void tableCno()
        {
            dataGridView1.Rows.Clear();//清空控件中已有数据
            Dao lj = new Dao();
            string sql = $" select * from SC where Cno='{textBox5.Text}'";
            IDataReader dc = lj.read(sql);
            while (dc.Read())
            {
                dataGridView1.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString());
            }
            dc.Close();
            lj.LJClose();
        }
        public void tableSno()
        {
            dataGridView1.Rows.Clear();//清空控件中已有数据
            Dao lj = new Dao();
            string sql = $" select * from SC where Sno='{textBox4.Text}'";
            IDataReader dc = lj.read(sql);
            while (dc.Read())
            {
                dataGridView1.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString());
            }
            dc.Close();
            lj.LJClose();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Teacher11 SA = new Teacher11();
            SA.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tableSno();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            tableCno();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();//获取学生
                string Cno = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();//获取课程
                DialogResult dr = MessageBox.Show("确认删除吗？", "信息提示", MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    string sql = $"delete from SC where Cno='{id}'and Sno='{Cno}'";
                    Dao lj = new Dao();
                    if (lj.Execute(sql) > 0)
                    {
                        MessageBox.Show("删除成功！");
                        table();
                    }
                    else 
                    {
                        MessageBox.Show("删除失败！");
                    }
                    lj.LJClose();
                }
            }
            catch 
            {
                MessageBox.Show("请先选中需删除对象！","信息提示",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        public void tableMOSTS()
        {
            dataGridView1.Rows.Clear();//清空控件中已有数据
            Dao lj = new Dao();
            string sql = $"select * from SC where Cno='{textBox1.Text}' and score=(select max(score) from SC where Cno='{textBox1.Text}')";
            //string sql = $" select *  from SC where score > = ALL(select score from SC) and Cno='{textBox1.Text}'";
            IDataReader dc = lj.read(sql);
            while (dc.Read())
            {
                dataGridView1.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString());
            }
            dc.Close();
            lj.LJClose();
        }
        public void tableLESS()
        {
            dataGridView1.Rows.Clear();//清空控件中已有数据
            Dao lj = new Dao();
            string sql = $"select * from SC where Cno='{textBox2.Text}' and score=(select min(score) from SC where Cno='{textBox2.Text}')";
            IDataReader dc = lj.read(sql);
            while (dc.Read())
            {
                dataGridView1.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString());
            }
            dc.Close();
            lj.LJClose();
        }
        public void tableAVE()
        {
            dataGridView1.Rows.Clear();//清空控件中已有数据
            Dao lj = new Dao();
            string sql = $" SELECT AVG(score) FROM SC WHERE Cno ='{textBox3.Text}'";
            IDataReader dc = lj.read(sql);
            while (dc.Read())
            {
                dataGridView1.Rows.Add("平均", "成绩", dc[0].ToString());
            }
            dc.Close();
            lj.LJClose();
        }
        private void dataGridView1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string Cno = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                string Sno = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                string score = dataGridView1.SelectedRows[0].Cells[2].Value.ToString(); 
                Teacher12 admin = new Teacher12(Cno,Sno,score);
                admin.ShowDialog();
                table();//刷新数据
            }
            catch 
            {
                MessageBox.Show("ERROR");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            table();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            tableCno();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tableMOSTS();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            tableLESS();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tableAVE();
        }

        private void SCOREADM_Load(object sender, EventArgs e)
        {

        }
    }
}
