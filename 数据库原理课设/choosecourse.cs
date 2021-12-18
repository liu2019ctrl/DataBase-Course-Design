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
    public partial class choosecourse : Form
    {
        private showcourse s;

        public choosecourse(showcourse s1)
        {
            InitializeComponent();
            this.s = s1;
        }

        private void choosecourse_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“designDataSet1.courseinfo”中。您可以根据需要移动或删除它。
            this.courseinfoTableAdapter1.Fill(this.designDataSet1.courseinfo);
            // TODO: 这行代码将数据加载到表“designDataSet.courseinfo”中。您可以根据需要移动或删除它。
            this.courseinfoTableAdapter.Fill(this.designDataSet.courseinfo);
            time.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        //搜索图书余量
        private void btn_search_Click(object sender, EventArgs e)
        {
            int a = Restcourse(course_Cno.Text);
            MessageBox.Show("课程余量" + a);
        }

        //查看课余量方法
        private int Restcourse(string cno)
        {
            string rest = "";
            int ret = 0;
            string sql = "select 课程余量 from courseinfo where 课程号='" + cno + "'";
            Mytools mytools = new Mytools();
            IDataReader dr = mytools.@select(sql);
            dr.Read();

            rest = dr["课程余量"].ToString();
            ret = Convert.ToInt32(rest);

            dr.Close();
            return ret;
        }

        //提交选课结果
        private void btn_choose_Click(object sender, EventArgs e)
        {
            int ret = 0;
            string cno1 = course_Cno.Text;
            if (course_Sno.Text != "" && course_Sname.Text != "" && course_Cname.Text != null &&
                course_Cno.Text != null)
            {
                string sname = course_Sname.Text;
                string sno = course_Sno.Text;
                string cname = course_Cname.Text;
                string cno = course_Cno.Text;
                string rest;

                ret = Restcourse(cno);
                if (ret > 0)
                {
                    string sql1 = "insert into sc(学号,课程号) values('" + sno + "','" + cno + "')";
                    Mytools mytools1 = new Mytools();
                    mytools1.Excute(sql1);
                    ret -= 1;
                    rest = Convert.ToString(ret);
                    string sql2 = "update courseinfo set 课程余量='" + rest + "'where 课程号='" + course_Cno.Text + "'";
                    mytools1.Excute(sql2);
                    MessageBox.Show("选课成功！,当前课程课余量为：" + ret);
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("请输入需要选的课程！");
            }
        }

 

        private void 查看已选择课程ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showcourse showcourse = new showcourse();
            showcourse.ShowDialog();
        }

        private void 退出系统ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void course_Cname_SelectedIndexChanged(object sender, EventArgs e)
        {
            //课程名称和课程号绑定
            course_Cno.SelectedIndex = course_Cname.SelectedIndex;
        }

        private void course_Cno_SelectedIndexChanged(object sender, EventArgs e)
        {
            //课程名称和课程号绑定
            course_Cname.SelectedIndex = course_Cno.SelectedIndex;
        }
    }
}