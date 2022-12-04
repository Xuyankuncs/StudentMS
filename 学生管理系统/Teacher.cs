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
    public partial class Teacher : Form
    {
        public Teacher()
        {
            InitializeComponent();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Teacher2 SA = new Teacher2();
            SA.ShowDialog();
        }

        private void 成绩管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Teacher1 SA = new Teacher1();
            SA.ShowDialog();
        }

        private void 课程管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Teacher3 SA = new Teacher3();
            SA.ShowDialog();
        }
    }
}
