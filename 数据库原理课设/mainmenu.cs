using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 数据库原理课设
{
    public partial class mainmenu : Form
    {
        public mainmenu()
        {
            InitializeComponent();
        }

        private void mainmenu_Load(object sender, EventArgs e)
        {
            time.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        private void btn_stu_Click(object sender, EventArgs e)
        {
            this.Hide();
            showstu s = new showstu();
            s.ShowDialog();
        }

        private void btn_course_Click(object sender, EventArgs e)
        {
            this.Hide();
            showcourse s = new showcourse();
            s.ShowDialog();
        }

        private void btn_class_Click(object sender, EventArgs e)
        {
            this.Hide();
            showclass s = new showclass();
            s.ShowDialog();
        }

        private void btn_teacher_Click(object sender, EventArgs e)
        {
            this.Hide();
            showteacher s = new showteacher();
            s.ShowDialog();
        }

        private void btn_grade_Click(object sender, EventArgs e)
        {
            this.Hide();
            showgrade s = new showgrade();
            s.ShowDialog();
        }

        private void 退出系统ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mainmenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}