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
    public partial class Teacher12 : Form
    {
        string ID = "";
        public Teacher12()
        {
            InitializeComponent();
        }
        public Teacher12(string Cno,string Sno,string score)
        {
            InitializeComponent();
            ID = textBox1.Text = Cno;
            textBox2.Text = Sno;
            textBox3.Text = score;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string sql = $"update SC set Cno='{textBox1.Text}',Sno='{textBox2.Text}',score={textBox3.Text} where Cno='{ID}'";
            Dao lj = new Dao();
            if (lj.Execute(sql) > 0)
            {
                MessageBox.Show("修改成功");
                this.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
