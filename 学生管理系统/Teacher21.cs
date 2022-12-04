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
    public partial class Teacher21 : Form
    {
        public Teacher21()
        {
            InitializeComponent();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != ""&& textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "" && textBox7.Text != "" )
            {
                Dao lj = new Dao();
                string sql = $"insert into Students values('{textBox1.Text}','{textBox2.Text}','{textBox3.Text}','{textBox4.Text}','{textBox5.Text}','{textBox6.Text}','{textBox7.Text}')";
                int n = lj.Execute(sql);
                if (n > 0)
                {
                    MessageBox.Show("添加成功！");
                    
                }
                else
                {
                    MessageBox.Show("添加失败，请检查是否为合法课程号及学号！");
                }
                textBox1.Text = ""; 
                textBox2.Text = ""; 
                textBox3.Text = "";
            }
            else
            {
                MessageBox.Show("输入不允许有空项！");
            }
        }

        private void Teacher21_Load(object sender, EventArgs e)
        {

        }
    }
}
