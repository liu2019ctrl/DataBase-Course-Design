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
    public partial class addclass : Form
    {
        private showclass s;
        private string str;

        public addclass(showclass s1)
        {
            InitializeComponent();
            btn_amend.Visible = false;
            this.s = s1;
        }

        public addclass(string str1, showclass s2)
        {
            InitializeComponent();
            btn_add.Visible = false;
            this.str = str1;
            this.s = s2;
        }

        private void addclass_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!C_name.Text.Equals(""))
            {
                string str = C_name.Text;
                string sql = "insert into classinfo values('" + str + "','0')";
                Mytools mytools = new Mytools();
                mytools.Excute(sql);
                MessageBox.Show("添加成功！");
                this.Hide();
            }

            s.Table();
        }

        //修改班级
        private void btn_amend_Click(object sender, EventArgs e)
        {
            if (!C_name.Text.Equals(str))
            {
                string sql = "update classinfo set 班级名称='" + C_name.Text + "' where 班级名称='" + str + "'";
                Mytools mytools = new Mytools();
                mytools.Excute(sql);
                MessageBox.Show("修改成功！");
                this.Hide();
            }

            str = C_name.Text;
            s.Table();
        }
    }
}