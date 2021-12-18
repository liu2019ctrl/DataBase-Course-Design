namespace 数据库原理课设
{
    partial class addclass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addclass));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.C_name = new System.Windows.Forms.TextBox();
            this.btn_amend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 14F);
            this.label1.Location = new System.Drawing.Point(95, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "班级名称";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(171, 231);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(162, 74);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "添加";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.button1_Click);
            // 
            // C_name
            // 
            this.C_name.Location = new System.Drawing.Point(254, 133);
            this.C_name.Name = "C_name";
            this.C_name.Size = new System.Drawing.Size(131, 25);
            this.C_name.TabIndex = 2;
            // 
            // btn_amend
            // 
            this.btn_amend.Location = new System.Drawing.Point(171, 231);
            this.btn_amend.Name = "btn_amend";
            this.btn_amend.Size = new System.Drawing.Size(162, 74);
            this.btn_amend.TabIndex = 3;
            this.btn_amend.Text = "修改";
            this.btn_amend.UseVisualStyleBackColor = true;
            this.btn_amend.Click += new System.EventHandler(this.btn_amend_Click);
            // 
            // addclass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 422);
            this.Controls.Add(this.btn_amend);
            this.Controls.Add(this.C_name);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "addclass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "添加班级";
            this.Load += new System.EventHandler(this.addclass_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox C_name;
        private System.Windows.Forms.Button btn_amend;
    }
}