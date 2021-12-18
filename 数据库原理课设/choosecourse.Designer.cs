namespace 数据库原理课设
{
    partial class choosecourse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(choosecourse));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.系统ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出系统ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.time = new System.Windows.Forms.ToolStripLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.course_Sno = new System.Windows.Forms.TextBox();
            this.btn_choose = new System.Windows.Forms.Button();
            this.course_Cname = new System.Windows.Forms.ComboBox();
            this.courseinfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.designDataSet = new 数据库原理课设.designDataSet();
            this.course_Cno = new System.Windows.Forms.ComboBox();
            this.courseinfoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.designDataSet1 = new 数据库原理课设.designDataSet1();
            this.courseinfoTableAdapter = new 数据库原理课设.designDataSetTableAdapters.courseinfoTableAdapter();
            this.courseinfoTableAdapter1 = new 数据库原理课设.designDataSet1TableAdapters.courseinfoTableAdapter();
            this.course_Sname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.courseinfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.designDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseinfoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.designDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.系统ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(661, 28);
            this.menuStrip1.TabIndex = 1;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 13F);
            this.label1.Location = new System.Drawing.Point(183, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "学号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 13F);
            this.label2.Location = new System.Drawing.Point(183, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "课程";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripLabel2,
            this.time});
            this.toolStrip1.Location = new System.Drawing.Point(0, 441);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(661, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(174, 22);
            this.toolStripLabel1.Text = "欢迎使用管理选课系统！";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(0, 22);
            // 
            // time
            // 
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(42, 22);
            this.time.Text = "time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 13F);
            this.label3.Location = new System.Drawing.Point(183, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "课程号";
            // 
            // course_Sno
            // 
            this.course_Sno.Location = new System.Drawing.Point(295, 59);
            this.course_Sno.Name = "course_Sno";
            this.course_Sno.Size = new System.Drawing.Size(165, 25);
            this.course_Sno.TabIndex = 6;
            // 
            // btn_choose
            // 
            this.btn_choose.Location = new System.Drawing.Point(178, 302);
            this.btn_choose.Name = "btn_choose";
            this.btn_choose.Size = new System.Drawing.Size(123, 49);
            this.btn_choose.TabIndex = 10;
            this.btn_choose.Text = "选课";
            this.btn_choose.UseVisualStyleBackColor = true;
            this.btn_choose.Click += new System.EventHandler(this.btn_choose_Click);
            // 
            // course_Cname
            // 
            this.course_Cname.DataSource = this.courseinfoBindingSource;
            this.course_Cname.DisplayMember = "课程名称";
            this.course_Cname.FormattingEnabled = true;
            this.course_Cname.Location = new System.Drawing.Point(295, 172);
            this.course_Cname.Name = "course_Cname";
            this.course_Cname.Size = new System.Drawing.Size(165, 23);
            this.course_Cname.TabIndex = 11;
            this.course_Cname.ValueMember = "课程名称";
            this.course_Cname.SelectedIndexChanged += new System.EventHandler(this.course_Cname_SelectedIndexChanged);
            // 
            // courseinfoBindingSource
            // 
            this.courseinfoBindingSource.DataMember = "courseinfo";
            this.courseinfoBindingSource.DataSource = this.designDataSet;
            // 
            // designDataSet
            // 
            this.designDataSet.DataSetName = "designDataSet";
            this.designDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // course_Cno
            // 
            this.course_Cno.DataSource = this.courseinfoBindingSource1;
            this.course_Cno.DisplayMember = "课程号";
            this.course_Cno.FormattingEnabled = true;
            this.course_Cno.Location = new System.Drawing.Point(295, 224);
            this.course_Cno.Name = "course_Cno";
            this.course_Cno.Size = new System.Drawing.Size(165, 23);
            this.course_Cno.TabIndex = 12;
            this.course_Cno.ValueMember = "课程号";
            this.course_Cno.SelectedIndexChanged += new System.EventHandler(this.course_Cno_SelectedIndexChanged);
            // 
            // courseinfoBindingSource1
            // 
            this.courseinfoBindingSource1.DataMember = "courseinfo";
            this.courseinfoBindingSource1.DataSource = this.designDataSet1;
            // 
            // designDataSet1
            // 
            this.designDataSet1.DataSetName = "designDataSet1";
            this.designDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // courseinfoTableAdapter
            // 
            this.courseinfoTableAdapter.ClearBeforeFill = true;
            // 
            // courseinfoTableAdapter1
            // 
            this.courseinfoTableAdapter1.ClearBeforeFill = true;
            // 
            // course_Sname
            // 
            this.course_Sname.Location = new System.Drawing.Point(295, 115);
            this.course_Sname.Name = "course_Sname";
            this.course_Sname.Size = new System.Drawing.Size(165, 25);
            this.course_Sname.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 13F);
            this.label4.Location = new System.Drawing.Point(183, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 22);
            this.label4.TabIndex = 13;
            this.label4.Text = "姓名";
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(389, 302);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(123, 49);
            this.btn_search.TabIndex = 15;
            this.btn_search.Text = "查询";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // choosecourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 466);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.course_Sname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.course_Cno);
            this.Controls.Add(this.course_Cname);
            this.Controls.Add(this.btn_choose);
            this.Controls.Add(this.course_Sno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "choosecourse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "选课页面";
            this.Load += new System.EventHandler(this.choosecourse_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.courseinfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.designDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseinfoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.designDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 系统ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出系统ToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripLabel time;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox course_Sno;
        private System.Windows.Forms.Button btn_choose;
        private System.Windows.Forms.ComboBox course_Cname;
        private System.Windows.Forms.ComboBox course_Cno;
        private designDataSet designDataSet;
        private System.Windows.Forms.BindingSource courseinfoBindingSource;
        private designDataSetTableAdapters.courseinfoTableAdapter courseinfoTableAdapter;
        private designDataSet1 designDataSet1;
        private System.Windows.Forms.BindingSource courseinfoBindingSource1;
        private designDataSet1TableAdapters.courseinfoTableAdapter courseinfoTableAdapter1;
        private System.Windows.Forms.TextBox course_Sname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_search;
    }
}