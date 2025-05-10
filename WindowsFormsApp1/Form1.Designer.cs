namespace WindowsFormsApp1
{
    partial class Form1
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
            this.BtnFirstEnter = new System.Windows.Forms.Button();
            this.lbl1pass = new System.Windows.Forms.Label();
            this.LBL1user = new System.Windows.Forms.Label();
            this.txt1user = new System.Windows.Forms.TextBox();
            this.txt1pass = new System.Windows.Forms.TextBox();
            this.linksign = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnFirstEnter
            // 
            this.BtnFirstEnter.AutoSize = true;
            this.BtnFirstEnter.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BtnFirstEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFirstEnter.Location = new System.Drawing.Point(314, 320);
            this.BtnFirstEnter.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.BtnFirstEnter.Name = "BtnFirstEnter";
            this.BtnFirstEnter.Size = new System.Drawing.Size(128, 52);
            this.BtnFirstEnter.TabIndex = 3;
            this.BtnFirstEnter.Text = "ورود";
            this.BtnFirstEnter.UseVisualStyleBackColor = false;
            this.BtnFirstEnter.Click += new System.EventHandler(this.BtnFirstEnter_Click);
            // 
            // lbl1pass
            // 
            this.lbl1pass.AutoSize = true;
            this.lbl1pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1pass.Location = new System.Drawing.Point(91, 210);
            this.lbl1pass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl1pass.Name = "lbl1pass";
            this.lbl1pass.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl1pass.Size = new System.Drawing.Size(123, 32);
            this.lbl1pass.TabIndex = 5;
            this.lbl1pass.Text = "رمز عبور :";
            // 
            // LBL1user
            // 
            this.LBL1user.AutoSize = true;
            this.LBL1user.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL1user.Location = new System.Drawing.Point(76, 112);
            this.LBL1user.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL1user.Name = "LBL1user";
            this.LBL1user.Size = new System.Drawing.Size(138, 32);
            this.LBL1user.TabIndex = 4;
            this.LBL1user.Text = " نام کاربری :";
            // 
            // txt1user
            // 
            this.txt1user.AcceptsTab = true;
            this.txt1user.Location = new System.Drawing.Point(269, 112);
            this.txt1user.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txt1user.MaxLength = 40;
            this.txt1user.Multiline = true;
            this.txt1user.Name = "txt1user";
            this.txt1user.Size = new System.Drawing.Size(246, 32);
            this.txt1user.TabIndex = 0;
            // 
            // txt1pass
            // 
            this.txt1pass.Location = new System.Drawing.Point(269, 210);
            this.txt1pass.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txt1pass.Multiline = true;
            this.txt1pass.Name = "txt1pass";
            this.txt1pass.PasswordChar = '*';
            this.txt1pass.Size = new System.Drawing.Size(246, 30);
            this.txt1pass.TabIndex = 1;
            // 
            // linksign
            // 
            this.linksign.AutoSize = true;
            this.linksign.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linksign.Location = new System.Drawing.Point(309, 293);
            this.linksign.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linksign.Name = "linksign";
            this.linksign.Size = new System.Drawing.Size(168, 25);
            this.linksign.TabIndex = 2;
            this.linksign.TabStop = true;
            this.linksign.Text = "هنوز ثبت نام نکرده اید؟";
            this.linksign.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linksign_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(336, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 27);
            this.label1.TabIndex = 6;
            this.label1.Text = "به نام خدا";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(512, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "نمایش";
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label2_MouseDown);
            this.label2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.label2_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(702, 449);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linksign);
            this.Controls.Add(this.txt1pass);
            this.Controls.Add(this.txt1user);
            this.Controls.Add(this.LBL1user);
            this.Controls.Add(this.lbl1pass);
            this.Controls.Add(this.BtnFirstEnter);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "مدیریت بانکی";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnFirstEnter;
        private System.Windows.Forms.Label lbl1pass;
        private System.Windows.Forms.Label LBL1user;
        private System.Windows.Forms.TextBox txt1user;
        private System.Windows.Forms.TextBox txt1pass;
        private System.Windows.Forms.LinkLabel linksign;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

