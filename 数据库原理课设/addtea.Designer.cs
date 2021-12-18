namespace 数据库原理课设
{
    partial class addtea
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addtea));
            this.add_course = new System.Windows.Forms.TextBox();
            this.add_tname = new System.Windows.Forms.TextBox();
            this.add_tno = new System.Windows.Forms.TextBox();
            this.add_sclass1 = new System.Windows.Forms.Label();
            this.add_sname1 = new System.Windows.Forms.Label();
            this.add_sno1 = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_amend = new System.Windows.Forms.Button();
            this.add_cno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.add_rest = new System.Windows.Forms.TextBox();
            this.ss = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // add_course
            // 
            this.add_course.Location = new System.Drawing.Point(279, 152);
            this.add_course.Name = "add_course";
            this.add_course.Size = new System.Drawing.Size(129, 25);
            this.add_course.TabIndex = 11;
            // 
            // add_tname
            // 
            this.add_tname.Location = new System.Drawing.Point(279, 92);
            this.add_tname.Name = "add_tname";
            this.add_tname.Size = new System.Drawing.Size(129, 25);
            this.add_tname.TabIndex = 10;
            // 
            // add_tno
            // 
            this.add_tno.Location = new System.Drawing.Point(279, 38);
            this.add_tno.Name = "add_tno";
            this.add_tno.Size = new System.Drawing.Size(129, 25);
            this.add_tno.TabIndex = 9;
            // 
            // add_sclass1
            // 
            this.add_sclass1.AutoSize = true;
            this.add_sclass1.Font = new System.Drawing.Font("宋体", 14F);
            this.add_sclass1.Location = new System.Drawing.Point(147, 152);
            this.add_sclass1.Name = "add_sclass1";
            this.add_sclass1.Size = new System.Drawing.Size(106, 24);
            this.add_sclass1.TabIndex = 8;
            this.add_sclass1.Text = "教授课程";
            // 
            // add_sname1
            // 
            this.add_sname1.AutoSize = true;
            this.add_sname1.Font = new System.Drawing.Font("宋体", 14F);
            this.add_sname1.Location = new System.Drawing.Point(147, 93);
            this.add_sname1.Name = "add_sname1";
            this.add_sname1.Size = new System.Drawing.Size(58, 24);
            this.add_sname1.TabIndex = 7;
            this.add_sname1.Text = "姓名";
            // 
            // add_sno1
            // 
            this.add_sno1.AutoSize = true;
            this.add_sno1.Font = new System.Drawing.Font("宋体", 14F);
            this.add_sno1.Location = new System.Drawing.Point(147, 40);
            this.add_sno1.Name = "add_sno1";
            this.add_sno1.Size = new System.Drawing.Size(82, 24);
            this.add_sno1.TabIndex = 6;
            this.add_sno1.Text = "职工号";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(194, 334);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(157, 43);
            this.btn_add.TabIndex = 12;
            this.btn_add.Text = "添加";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click_1);
            // 
            // btn_amend
            // 
            this.btn_amend.Location = new System.Drawing.Point(194, 334);
            this.btn_amend.Name = "btn_amend";
            this.btn_amend.Size = new System.Drawing.Size(157, 43);
            this.btn_amend.TabIndex = 13;
            this.btn_amend.Text = "修改";
            this.btn_amend.UseVisualStyleBackColor = true;
            this.btn_amend.Click += new System.EventHandler(this.btn_amend_Click_1);
            // 
            // add_cno
            // 
            this.add_cno.Location = new System.Drawing.Point(279, 212);
            this.add_cno.Name = "add_cno";
            this.add_cno.Size = new System.Drawing.Size(129, 25);
            this.add_cno.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 14F);
            this.label1.Location = new System.Drawing.Point(147, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "教授课程号";
            // 
            // add_rest
            // 
            this.add_rest.Location = new System.Drawing.Point(279, 265);
            this.add_rest.Name = "add_rest";
            this.add_rest.Size = new System.Drawing.Size(129, 25);
            this.add_rest.TabIndex = 17;
            // 
            // ss
            // 
            this.ss.AutoSize = true;
            this.ss.Font = new System.Drawing.Font("宋体", 14F);
            this.ss.Location = new System.Drawing.Point(147, 265);
            this.ss.Name = "ss";
            this.ss.Size = new System.Drawing.Size(82, 24);
            this.ss.TabIndex = 16;
            this.ss.Text = "课余量";
            // 
            // addtea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 422);
            this.Controls.Add(this.add_rest);
            this.Controls.Add(this.ss);
            this.Controls.Add(this.add_cno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_amend);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.add_course);
            this.Controls.Add(this.add_tname);
            this.Controls.Add(this.add_tno);
            this.Controls.Add(this.add_sclass1);
            this.Controls.Add(this.add_sname1);
            this.Controls.Add(this.add_sno1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "addtea";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加教师";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox add_course;
        private System.Windows.Forms.TextBox add_tname;
        private System.Windows.Forms.TextBox add_tno;
        private System.Windows.Forms.Label add_sclass1;
        private System.Windows.Forms.Label add_sname1;
        private System.Windows.Forms.Label add_sno1;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_amend;
        private System.Windows.Forms.TextBox add_cno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox add_rest;
        private System.Windows.Forms.Label ss;
    }
}