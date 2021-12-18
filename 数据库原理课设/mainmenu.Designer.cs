namespace 数据库原理课设
{
    partial class mainmenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainmenu));
            this.btn_stu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.lable1 = new System.Windows.Forms.ToolStripLabel();
            this.time = new System.Windows.Forms.ToolStripLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_class = new System.Windows.Forms.Button();
            this.btn_grade = new System.Windows.Forms.Button();
            this.btn_course = new System.Windows.Forms.Button();
            this.btn_teacher = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.系统ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出系统ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_stu
            // 
            this.btn_stu.Font = new System.Drawing.Font("宋体", 10.5F);
            this.btn_stu.Location = new System.Drawing.Point(196, 109);
            this.btn_stu.Name = "btn_stu";
            this.btn_stu.Size = new System.Drawing.Size(176, 71);
            this.btn_stu.TabIndex = 0;
            this.btn_stu.Text = "对于学生功能";
            this.btn_stu.UseVisualStyleBackColor = true;
            this.btn_stu.Click += new System.EventHandler(this.btn_stu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "欢迎来到本教学管理系统！";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lable1,
            this.time});
            this.toolStrip1.Location = new System.Drawing.Point(0, 508);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(882, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // lable1
            // 
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(129, 22);
            this.lable1.Text = "欢迎使用本系统！";
            // 
            // time
            // 
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(42, 22);
            this.time.Text = "time";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_class
            // 
            this.btn_class.Font = new System.Drawing.Font("宋体", 10.5F);
            this.btn_class.Location = new System.Drawing.Point(196, 214);
            this.btn_class.Name = "btn_class";
            this.btn_class.Size = new System.Drawing.Size(176, 71);
            this.btn_class.TabIndex = 3;
            this.btn_class.Text = "对班级功能";
            this.btn_class.UseVisualStyleBackColor = true;
            this.btn_class.Click += new System.EventHandler(this.btn_class_Click);
            // 
            // btn_grade
            // 
            this.btn_grade.Font = new System.Drawing.Font("宋体", 10.5F);
            this.btn_grade.Location = new System.Drawing.Point(356, 330);
            this.btn_grade.Name = "btn_grade";
            this.btn_grade.Size = new System.Drawing.Size(176, 71);
            this.btn_grade.TabIndex = 4;
            this.btn_grade.Text = "对成绩功能";
            this.btn_grade.UseVisualStyleBackColor = true;
            this.btn_grade.Click += new System.EventHandler(this.btn_grade_Click);
            // 
            // btn_course
            // 
            this.btn_course.Font = new System.Drawing.Font("宋体", 10.5F);
            this.btn_course.Location = new System.Drawing.Point(508, 109);
            this.btn_course.Name = "btn_course";
            this.btn_course.Size = new System.Drawing.Size(176, 71);
            this.btn_course.TabIndex = 5;
            this.btn_course.Text = "对课程功能";
            this.btn_course.UseVisualStyleBackColor = true;
            this.btn_course.Click += new System.EventHandler(this.btn_course_Click);
            // 
            // btn_teacher
            // 
            this.btn_teacher.Font = new System.Drawing.Font("宋体", 10.5F);
            this.btn_teacher.Location = new System.Drawing.Point(508, 214);
            this.btn_teacher.Name = "btn_teacher";
            this.btn_teacher.Size = new System.Drawing.Size(176, 71);
            this.btn_teacher.TabIndex = 6;
            this.btn_teacher.Text = "对教师功能";
            this.btn_teacher.UseVisualStyleBackColor = true;
            this.btn_teacher.Click += new System.EventHandler(this.btn_teacher_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.系统ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(882, 28);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 系统ToolStripMenuItem
            // 
            this.系统ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.退出系统ToolStripMenuItem});
            this.系统ToolStripMenuItem.Name = "系统ToolStripMenuItem";
            this.系统ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.系统ToolStripMenuItem.Text = "系统";
            // 
            // 退出系统ToolStripMenuItem
            // 
            this.退出系统ToolStripMenuItem.Name = "退出系统ToolStripMenuItem";
            this.退出系统ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.退出系统ToolStripMenuItem.Text = "退出系统";
            this.退出系统ToolStripMenuItem.Click += new System.EventHandler(this.退出系统ToolStripMenuItem_Click);
            // 
            // mainmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 533);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btn_teacher);
            this.Controls.Add(this.btn_course);
            this.Controls.Add(this.btn_grade);
            this.Controls.Add(this.btn_class);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_stu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainmenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "主菜单";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.mainmenu_FormClosed);
            this.Load += new System.EventHandler(this.mainmenu_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_stu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel lable1;
        private System.Windows.Forms.ToolStripLabel time;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_class;
        private System.Windows.Forms.Button btn_grade;
        private System.Windows.Forms.Button btn_course;
        private System.Windows.Forms.Button btn_teacher;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 系统ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出系统ToolStripMenuItem;
    }
}