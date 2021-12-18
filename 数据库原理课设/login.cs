using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 数据库原理课设
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }


        private void btn_login_Click(object sender, EventArgs e)
        {
            if (account.Text == "" || password.Text == "")
            {
                MessageBox.Show("输入不完整!");
            }

            this.Hide();
            mainmenu mainmenu = new mainmenu();
            mainmenu.ShowDialog();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            数据库原理课设.register register = new register();
            register.ShowDialog();
        }
    }
}