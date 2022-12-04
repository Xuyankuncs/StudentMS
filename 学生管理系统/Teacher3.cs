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
    public partial class Teacher3 : Form
    {
        public Teacher3()
        {
            InitializeComponent();
            table();
        }
        public void table()
        {
            dataGridView1.Rows.Clear();//清空控件中已有数据
            Dao lj = new Dao();
            string sql = " select * from Courses";
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
            dataGridView1.Rows.Clear();//清空控件中已有数据
            Dao lj = new Dao();
            string sql = $" SELECT COUNT(DISTINCT SNO) FROM SC GROUP BY CNO HAVING CNO = '{textBox1.Text}'";
            IDataReader dc = lj.read(sql);
            while (dc.Read())
            {
                dataGridView1.Rows.Add(textBox1.Text, "选修人数为：", dc[0].ToString());
            }
            dc.Close();
            lj.LJClose();
        }
        public void tableMjCno()
        { 
            dataGridView1.Rows.Clear();//清空控件中已有数据
            Dao lj = new Dao();
            string sql = $" SELECT COUNT(DISTINCT SNO) FROM SC  where sno in (select sno from students where Mj='{textBox3.Text}') GROUP BY CNO HAVING CNO = '{textBox2.Text}'";
            IDataReader dc = lj.read(sql);
            while (dc.Read())
            {
                dataGridView1.Rows.Add(textBox2.Text, "选修人数为：", dc[0].ToString());
            }
            dc.Close();
            lj.LJClose();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            tableCno();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            tableMjCno();
        }

        private void 课程管理_Load(object sender, EventArgs e)
        {

        }
    }
}
