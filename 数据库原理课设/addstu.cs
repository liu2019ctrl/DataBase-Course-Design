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
    public partial class addstudent : Form
    {
        private showstu s1;

        private string[] str = new string[3];

        //用于添加
        public addstudent(showstu s)
        {
            InitializeComponent();
            //添加功能时，隐藏修改按钮
            btn_amend.Visible = false;
            //使修改完就刷新
            this.s1 = s;
        }

        //用于修改
        public addstudent(string[] a, showstu s2)
        {
            InitializeComponent();
            for (int i = 0; i < 3; i++)
            {
                str[i] = a[i];
            }

            add_sno.Text = str[0];
            add_sname.Text = str[1];
            add_sclass.Text = str[2];
            //修改功能时，隐藏添加按钮
            btn_add.Visible = false;
            //使修改完就刷新
            this.s1 = s2;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (add_sclass.Text != null && add_sname.Text != null && add_sno.Text != null)
            {
                string sno = add_sno.Text;
                string sname = add_sname.Text;
                string sclass = add_sclass.Text;
                string sql = "insert into stuinfo values('" + sno + "','" + sname + "','" + sclass + "')";
                Mytools mytools = new Mytools();
                mytools.Excute(sql);
                MessageBox.Show("添加成功！");
                this.Hide();
            }
            else
            {
                MessageBox.Show("请写入信息！");
            }

            //用于修改后直接刷新界面
            s1.Table();
        }

        private void btn_amend_Click(object sender, EventArgs e)
        {
            //当这些控件内容不为空
            if (add_sclass.Text != null && add_sname.Text != null && add_sno.Text != null)
            {
                //修改了学号
                if (add_sno.Text != str[0])
                {
                    string sql = "update stuinfo set 学号='" + add_sno.Text + "'where 学号='" + str[0] + "' and 姓名='" +
                                 str[1] + "'";
                    Mytools mytools = new Mytools();
                    mytools.Excute(sql);
                    //更新学号
                    str[0] = add_sno.Text;
                }

                //修改了姓名
                if (add_sname.Text != str[1])
                {
                    string sql = "update stuinfo set 姓名='" + add_sname.Text + "'where 学号='" + str[0] + "' and 姓名='" +
                                 str[1] + "'";
                    Mytools mytools = new Mytools();
                    mytools.Excute(sql);
                    //更新姓名
                    str[1] = add_sname.Text;
                }

                //修改了班级
                if (add_sclass.Text != str[2])
                {
                    string sql = "update stuinfo set 班级='" + add_sclass.Text + "'where 学号='" + str[0] + "' and 姓名='" +
                                 str[1] + "'";
                    Mytools mytools = new Mytools();
                    mytools.Excute(sql);
                    //更新班级
                    str[2] = add_sclass.Text;
                }

                MessageBox.Show("修改成功！");
                this.Hide();
            }
            else
            {
                MessageBox.Show("有空值，请重新填写！");
            }

            //用于修改后直接刷新界面
            s1.Table();
        }
    }
}