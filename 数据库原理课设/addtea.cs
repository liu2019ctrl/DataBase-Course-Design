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
    public partial class addtea : Form
    {
        private showteacher s;
        private string[] str = new string[5];

        public addtea(showteacher s1)
        {
            InitializeComponent();
            btn_amend.Visible = false;
            s1.Table();
        }

        public addtea(string[] a, showteacher s2)
        {
            InitializeComponent();
            btn_add.Visible = false;
            for (int i = 0; i < 5; i++)
            {
                str[i] = a[i];
            }

            add_tno.Text = str[0];
            add_tname.Text = str[1];
            add_course.Text = str[2];
            add_cno.Text = str[3];
            add_rest.Text = str[4];
            //修改功能时，隐藏添加按钮
            btn_add.Visible = false;
            //使修改完就刷新
            this.s = s2;
        }


        private void btn_amend_Click_1(object sender, EventArgs e)
        {
            if (add_tname.Text != null && add_course.Text != null && add_tno.Text != null && add_tno.Text != null &&
                add_rest.Text != null)
            {
                //修改了职工号
                if (add_tno.Text != str[0])
                {
                    string sql = "update teachview set 职工号='" + add_tno.Text + "'where 职工号='" + str[0] + "' and 姓名='" +
                                 str[1] + "'";
                    Mytools mytools = new Mytools();
                    mytools.Excute(sql);
                    //更新学职工号
                    str[0] = add_tno.Text;
                }

                //修改了姓名
                if (add_tname.Text != str[1])
                {
                    string sql = "update teainfo set 姓名='" + add_tname.Text + "'where 职工号='" + str[0] + "'";
                    string sql1 = "update courseinfo set 授课老师='" + add_tname.Text + "'where 课程号='" + str[3] + "'";
                    Mytools mytools = new Mytools();
                    mytools.Excute(sql);
                    mytools.Excute(sql1);
                    //更新姓名
                    str[1] = add_tname.Text;
                }

                //修改了教课
                if (add_course.Text != str[2])
                {
                    string sql = "update courseinfo set 课程名称='" + add_course.Text + "'where 职工号='" + str[0] + "'";
                    Mytools mytools = new Mytools();
                    mytools.Excute(sql);
                    //更新班级
                    str[2] = add_course.Text;
                }

                if (add_cno.Text != str[3])
                {
                    string sql = "update courseinfo set 课程号='" + add_cno.Text + "'where 课程号='" + str[3] + "'";
                    Mytools mytools = new Mytools();
                    mytools.Excute(sql);
                    //更新班级
                    str[3] = add_cno.Text;
                }

                if (add_rest.Text != str[4])
                {
                    string sql = "update courseinfo set 课程号='" + add_rest.Text + "'where 课程号='" + str[3] + "'";
                    Mytools mytools = new Mytools();
                    mytools.Excute(sql);
                    //更新班级
                    str[4] = add_rest.Text;
                }

                MessageBox.Show("修改成功！");
                this.Hide();
            }
            else
            {
                MessageBox.Show("有空值，请重新填写！");
            }

            //用于修改后直接刷新界面
            s.Table();
        }

        //添加老师
        private void btn_add_Click_1(object sender, EventArgs e)
        {
            if (add_course.Text != null && add_tno.Text != null && add_tname.Text != null)
            {
                string tno = add_tno.Text;
                string tname = add_tname.Text;
                string course = add_course.Text;
                string cno = add_cno.Text;
                string rest = add_rest.Text;

                string sql = "insert into teainfo values('" + tno + "','" + tname + "')";
                string sql1 = "insert into courseinfo values('" + cno + "','" + course + "','" + tname + "','" + rest +
                              "')";
                Mytools mytools = new Mytools();
                mytools.Excute(sql);
                mytools.Excute(sql1);
                MessageBox.Show("添加成功！");
                this.Hide();
            }
            else
            {
                MessageBox.Show("请写入信息！");
            }
        }
    }
}