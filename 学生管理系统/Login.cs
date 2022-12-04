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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                login();
            }
            else 
            {
                MessageBox.Show("输入有空项，请重新输入！");
            }
        }
            //登陆验证，验证是否允许登陆，允许返回真
            public void login()
            {
            //学生
            if (radioButtonUSER.Checked == true)
            {
                Dao lj = new Dao();
                string sql = $"select * from Students where Sno='{textBox1.Text}'and PSW='{textBox2.Text}'";
                IDataReader dc = lj.read(sql);
                if (dc.Read())
                {
                    SMS.UID = dc["Sno"].ToString();
                    SMS.Uname = dc["Sname"].ToString();
                    MessageBox.Show("登陆成功！");
                    Student ST = new Student();
                    this.Hide();
                    ST.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("登陆失败！");
                }
                lj.LJClose();
            }
            //教师
            if (radioButtonADMIN.Checked == true)
            {
                Dao lj = new Dao();
                string sql = $"select * from Teachers where Tno='{textBox1.Text}'and PSW='{textBox2.Text}'";
                IDataReader dc = lj.read(sql);
                if (dc.Read()) 
                {
                    SMS.UID = dc["Tno"].ToString();
                    SMS.Uname = dc["Tname"].ToString();
                    MessageBox.Show("登陆成功！");
                    Teacher TEA = new Teacher();
                    this.Hide();
                    TEA.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("登陆失败！");
                }
                lj.LJClose();
            }
            //管理员
            if(radioButton1.Checked==true)
            {
                Dao lj = new Dao();
                string sql = $"select * from ADMINN where ZH='{textBox1.Text}'and PSW='{textBox2.Text}' ";
                IDataReader dc = lj.read(sql);
                if(dc.Read())
                {
                    SMS.UID = dc["ZH"].ToString();
                    SMS.Uname = dc["PSW"].ToString();
                    MessageBox.Show("登陆成功！");
                    Admin admin = new Admin();
                    this.Hide();
                    admin.ShowDialog();
                    this.Show();
                }
            }
            }
        

        private void radioButtonADMIN_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
