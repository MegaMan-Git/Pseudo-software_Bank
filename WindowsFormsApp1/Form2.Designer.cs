namespace WindowsFormsApp1
{
    partial class Form2sign
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
            this.BtnSign = new System.Windows.Forms.Button();
            this.txtsignpas2 = new System.Windows.Forms.TextBox();
            this.txtsignpas1 = new System.Windows.Forms.TextBox();
            this.txtsignuser = new System.Windows.Forms.TextBox();
            this.NewUser = new System.Windows.Forms.Label();
            this.lblnewpas = new System.Windows.Forms.Label();
            this.lblDnewpas = new System.Windows.Forms.Label();
            this.Login = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnSign
            // 
            this.BtnSign.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.BtnSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSign.Location = new System.Drawing.Point(376, 403);
            this.BtnSign.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.BtnSign.Name = "BtnSign";
            this.BtnSign.Size = new System.Drawing.Size(146, 50);
            this.BtnSign.TabIndex = 4;
            this.BtnSign.Text = "ثبت نام";
            this.BtnSign.UseVisualStyleBackColor = false;
            this.BtnSign.Click += new System.EventHandler(this.BtnSign_Click);
            // 
            // txtsignpas2
            // 
            this.txtsignpas2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtsignpas2.Location = new System.Drawing.Point(395, 274);
            this.txtsignpas2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtsignpas2.Name = "txtsignpas2";
            this.txtsignpas2.PasswordChar = '*';
            this.txtsignpas2.Size = new System.Drawing.Size(260, 26);
            this.txtsignpas2.TabIndex = 2;
            // 
            // txtsignpas1
            // 
            this.txtsignpas1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtsignpas1.Location = new System.Drawing.Point(395, 171);
            this.txtsignpas1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtsignpas1.Name = "txtsignpas1";
            this.txtsignpas1.PasswordChar = '*';
            this.txtsignpas1.Size = new System.Drawing.Size(260, 26);
            this.txtsignpas1.TabIndex = 1;
            // 
            // txtsignuser
            // 
            this.txtsignuser.Location = new System.Drawing.Point(395, 74);
            this.txtsignuser.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtsignuser.Name = "txtsignuser";
            this.txtsignuser.Size = new System.Drawing.Size(260, 27);
            this.txtsignuser.TabIndex = 0;
            // 
            // NewUser
            // 
            this.NewUser.AutoSize = true;
            this.NewUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewUser.Location = new System.Drawing.Point(156, 70);
            this.NewUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NewUser.Name = "NewUser";
            this.NewUser.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.NewUser.Size = new System.Drawing.Size(131, 32);
            this.NewUser.TabIndex = 5;
            this.NewUser.Text = "نام کاربری :";
            // 
            // lblnewpas
            // 
            this.lblnewpas.AutoSize = true;
            this.lblnewpas.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnewpas.Location = new System.Drawing.Point(164, 166);
            this.lblnewpas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblnewpas.Name = "lblnewpas";
            this.lblnewpas.Size = new System.Drawing.Size(123, 32);
            this.lblnewpas.TabIndex = 6;
            this.lblnewpas.Text = "رمز عبور :";
            // 
            // lblDnewpas
            // 
            this.lblDnewpas.AutoSize = true;
            this.lblDnewpas.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDnewpas.Location = new System.Drawing.Point(156, 268);
            this.lblDnewpas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDnewpas.Name = "lblDnewpas";
            this.lblDnewpas.Size = new System.Drawing.Size(183, 32);
            this.lblDnewpas.TabIndex = 7;
            this.lblDnewpas.Text = "تکرار رمز عبور :";
            this.lblDnewpas.UseMnemonic = false;
            // 
            // Login
            // 
            this.Login.AutoSize = true;
            this.Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login.Location = new System.Drawing.Point(381, 372);
            this.Login.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(175, 29);
            this.Login.TabIndex = 3;
            this.Login.TabStop = true;
            this.Login.Text = "قبلا ثبت نام کرده اید؟";
            this.Login.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Login_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(390, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(672, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "نمایش";
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label2_MouseDown);
            this.label2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.label2_MouseUp);
            // 
            // Form2sign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 500);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.lblDnewpas);
            this.Controls.Add(this.lblnewpas);
            this.Controls.Add(this.NewUser);
            this.Controls.Add(this.txtsignuser);
            this.Controls.Add(this.txtsignpas1);
            this.Controls.Add(this.txtsignpas2);
            this.Controls.Add(this.BtnSign);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2sign";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ثبت نام";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2sign_FormClosing);
            this.Load += new System.EventHandler(this.Form2sign_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSign;
        private System.Windows.Forms.TextBox txtsignpas2;
        private System.Windows.Forms.TextBox txtsignpas1;
        private System.Windows.Forms.TextBox txtsignuser;
        private System.Windows.Forms.Label NewUser;
        private System.Windows.Forms.Label lblnewpas;
        private System.Windows.Forms.Label lblDnewpas;
        private System.Windows.Forms.LinkLabel Login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}