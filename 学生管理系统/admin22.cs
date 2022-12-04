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
    public partial class admin22 : Form
    {
        string TNO = "";
        public admin22()
        {
            InitializeComponent();
        }
        public admin22(string Tno,string Tname,string Mj,string EorP,string PSW)
        {
            InitializeComponent();
            TNO = Tno;
            textBox2.Text = Tname;
            textBox3.Text = Mj;
            textBox4.Text = EorP;
            textBox5.Text = PSW;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string sql = $"update Teachers set Tname='{textBox2.Text}',Mj='{textBox3.Text}',EorP='{textBox4.Text}',PSW='{textBox5.Text}'where Tno='{TNO}'";
            Dao dao = new Dao();
            if(dao.Execute(sql)>0)
            {
                MessageBox.Show("修改成功！");
                this.Close();
            }
        }

        private void admin22_Load(object sender, EventArgs e)
        {

        }
    }
}
