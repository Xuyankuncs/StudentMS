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
    public partial class Teacher2 : Form
    {
        public Teacher2()
        {
            InitializeComponent();
            table();
        }
        public void table()
        {
            dataGridView1.Rows.Clear();//清空控件中已有数据
            Dao lj = new Dao();
            string sql = " select * from Students";
            IDataReader dc = lj.read(sql);
            while (dc.Read())
            {
                dataGridView1.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString(), dc[3].ToString(), dc[4].ToString(), dc[5].ToString(), dc[6].ToString());
            }
            dc.Close();
            lj.LJClose();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string Sno = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                string Sname = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                string CLA = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                string Ssex = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                string Mj = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                string Year = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                string PSW = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                Teacher22 admin = new Teacher22(Sno, Sname, CLA, Ssex, Mj, Year, PSW);
                admin.ShowDialog();
                table();//刷新数据
            }
            catch
            {
                MessageBox.Show("ERROR");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Teacher21 SA = new Teacher21();
            SA.ShowDialog();
            table();
        }
        public void tableSno()
        {
            dataGridView1.Rows.Clear();//清空控件中已有数据
            Dao lj = new Dao();
            string sql = $" select * from Students where Sno='{textBox1.Text}'";
            IDataReader dc = lj.read(sql);
            while (dc.Read())
            {
                dataGridView1.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString(), dc[3].ToString(), dc[4].ToString(), dc[5].ToString(), dc[6].ToString());
            }
            dc.Close();
            lj.LJClose();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            tableSno();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();//获取学生学号
                DialogResult dr = MessageBox.Show("确认删除吗？", "信息提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    string sql = $"delete from Students where Sno='{id}'";
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
                MessageBox.Show("请先选中需删除对象！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Teacher2_Load(object sender, EventArgs e)
        {

        }
    }
}
