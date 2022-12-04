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
    public partial class Teacher22 : Form
    {
        string ID = " ";
        public Teacher22(string Sno, string Sname, string CLA, string Ssex, string Mj, string Year,string PSW)
        {
            InitializeComponent();          
            ID=Sno;//Sno作为主键
            textBox2.Text = Sname;
            textBox3.Text = CLA;
            textBox4.Text = Ssex;
            textBox5.Text = Mj;
            textBox6.Text = Year;
            textBox7.Text = PSW;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = $"update Students set Sname='{textBox2.Text}',class='{textBox3.Text}',Ssex='{textBox4.Text}',Mj='{textBox5.Text}',Year='{textBox6.Text}',PSW='{textBox7.Text}'  where Sno='{ID}'";
            Dao lj = new Dao();
            if (lj.Execute(sql) > 0)
            {
                MessageBox.Show("修改成功");
                this.Close();
            }
            else
            {
                MessageBox.Show("失败");
            }
        }
        private void 修改基本信息_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
