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
    public partial class admin2 : Form
    {
        public admin2()
        {
            InitializeComponent();
            Table();
            //label2.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + dataGridView1.SelectedRows[0].Cells[1].Value.ToString();//获取教师编号

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //从数据库读取数据显示在表格中
        public void Table()
        {
            dataGridView1.Rows.Clear();//清空旧数据
            Dao dao = new Dao();
            string sql = "select * from Teachers";
            IDataReader dc = dao.read(sql);
            while(dc.Read())
            {
                dataGridView1.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString(), dc[3].ToString(), dc[4].ToString());
            }
            dc.Close();//关闭数据库连接
            dao.LJClose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            admin21 a = new admin21();
            a.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();//获取教师编号
                label2.Text = id + dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                DialogResult dr = MessageBox.Show("确认删除吗？", "信息提示", MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
                if(dr==DialogResult.OK)
                {
                    string sql = $"delete from Teachers where Tno='{id}'";
                    Dao dao = new Dao();
                    if(dao.Execute(sql)>0)
                    {
                        MessageBox.Show("删除成功！");
                        Table();
                    }
                    else
                    {
                        MessageBox.Show("删除失败！");
                    }
                    dao.LJClose();                                 
                }
            }
            catch
            {
                MessageBox.Show("请现在表格中选取要删除的教师记录！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

       private void dataGridView1_Click(object sender, EventArgs e)
        {
           label2.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + dataGridView1.SelectedRows[0].Cells[1].Value.ToString(); ;//获取教师编号
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string Tno = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                string Tname = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                string Mj = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                string EorP = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                string PSW = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                admin22 admin = new admin22(Tno,Tname,Mj,EorP,PSW);
                admin.ShowDialog();
                Table();//刷新数据
            }
            catch
            {
                MessageBox.Show("ERROR!");
            }
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Table();
        }

        private void admin2_Load(object sender, EventArgs e)
        {

        }
    }
}
