namespace 数据库原理课设
{
    partial class addstudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addstudent));
            this.add_sno1 = new System.Windows.Forms.Label();
            this.add_sname1 = new System.Windows.Forms.Label();
            this.add_sclass1 = new System.Windows.Forms.Label();
            this.add_sno = new System.Windows.Forms.TextBox();
            this.add_sname = new System.Windows.Forms.TextBox();
            this.add_sclass = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_amend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // add_sno1
            // 
            this.add_sno1.AutoSize = true;
            this.add_sno1.Font = new System.Drawing.Font("宋体", 14F);
            this.add_sno1.Location = new System.Drawing.Point(146, 94);
            this.add_sno1.Name = "add_sno1";
            this.add_sno1.Size = new System.Drawing.Size(58, 24);
            this.add_sno1.TabIndex = 0;
            this.add_sno1.Text = "学号";
            // 
            // add_sname1
            // 
            this.add_sname1.AutoSize = true;
            this.add_sname1.Font = new System.Drawing.Font("宋体", 14F);
            this.add_sname1.Location = new System.Drawing.Point(146, 167);
            this.add_sname1.Name = "add_sname1";
            this.add_sname1.Size = new System.Drawing.Size(58, 24);
            this.add_sname1.TabIndex = 1;
            this.add_sname1.Text = "姓名";
            // 
            // add_sclass1
            // 
            this.add_sclass1.AutoSize = true;
            this.add_sclass1.Font = new System.Drawing.Font("宋体", 14F);
            this.add_sclass1.Location = new System.Drawing.Point(146, 237);
            this.add_sclass1.Name = "add_sclass1";
            this.add_sclass1.Size = new System.Drawing.Size(58, 24);
            this.add_sclass1.TabIndex = 2;
            this.add_sclass1.Text = "班级";
            // 
            // add_sno
            // 
            this.add_sno.Location = new System.Drawing.Point(278, 92);
            this.add_sno.Name = "add_sno";
            this.add_sno.Size = new System.Drawing.Size(129, 25);
            this.add_sno.TabIndex = 3;
            // 
            // add_sname
            // 
            this.add_sname.Location = new System.Drawing.Point(278, 166);
            this.add_sname.Name = "add_sname";
            this.add_sname.Size = new System.Drawing.Size(129, 25);
            this.add_sname.TabIndex = 4;
            // 
            // add_sclass
            // 
            this.add_sclass.Location = new System.Drawing.Point(278, 237);
            this.add_sclass.Name = "add_sclass";
            this.add_sclass.Size = new System.Drawing.Size(129, 25);
            this.add_sclass.TabIndex = 5;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(218, 314);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(100, 43);
            this.btn_add.TabIndex = 6;
            this.btn_add.Text = "提交";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_amend
            // 
            this.btn_amend.Location = new System.Drawing.Point(218, 314);
            this.btn_amend.Name = "btn_amend";
            this.btn_amend.Size = new System.Drawing.Size(100, 43);
            this.btn_amend.TabIndex = 8;
            this.btn_amend.Text = "修改";
            this.btn_amend.UseVisualStyleBackColor = true;
            this.btn_amend.Click += new System.EventHandler(this.btn_amend_Click);
            // 
            // addstudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 422);
            this.Controls.Add(this.btn_amend);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.add_sclass);
            this.Controls.Add(this.add_sname);
            this.Controls.Add(this.add_sno);
            this.Controls.Add(this.add_sclass1);
            this.Controls.Add(this.add_sname1);
            this.Controls.Add(this.add_sno1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "addstudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "学生信息";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label add_sno1;
        private System.Windows.Forms.Label add_sname1;
        private System.Windows.Forms.Label add_sclass1;
        private System.Windows.Forms.TextBox add_sno;
        private System.Windows.Forms.TextBox add_sname;
        private System.Windows.Forms.TextBox add_sclass;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_amend;
    }
}