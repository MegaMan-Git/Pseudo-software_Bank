namespace WindowsFormsApp1
{
    partial class Form3
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
            this.btnuseroptionfirst = new System.Windows.Forms.Button();
            this.radio_send = new System.Windows.Forms.RadioButton();
            this.radio_withraw = new System.Windows.Forms.RadioButton();
            this.radio_check = new System.Windows.Forms.RadioButton();
            this.group_clint = new System.Windows.Forms.GroupBox();
            this.rad_TIME = new System.Windows.Forms.RadioButton();
            this.radioDelete = new System.Windows.Forms.RadioButton();
            this.radioM_Em_Add = new System.Windows.Forms.RadioButton();
            this.radioM_Em_send = new System.Windows.Forms.RadioButton();
            this.group_Employe = new System.Windows.Forms.GroupBox();
            this.radE_TIME = new System.Windows.Forms.RadioButton();
            this.radioE_Check = new System.Windows.Forms.RadioButton();
            this.radioBan = new System.Windows.Forms.RadioButton();
            this.radioUnban = new System.Windows.Forms.RadioButton();
            this.radioE_send = new System.Windows.Forms.RadioButton();
            this.radioE_withraw = new System.Windows.Forms.RadioButton();
            this.group_Manage = new System.Windows.Forms.GroupBox();
            this.radio_History = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.group_clint.SuspendLayout();
            this.group_Employe.SuspendLayout();
            this.group_Manage.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnuseroptionfirst
            // 
            this.btnuseroptionfirst.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnuseroptionfirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnuseroptionfirst.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnuseroptionfirst.Location = new System.Drawing.Point(443, 396);
            this.btnuseroptionfirst.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnuseroptionfirst.Name = "btnuseroptionfirst";
            this.btnuseroptionfirst.Size = new System.Drawing.Size(117, 49);
            this.btnuseroptionfirst.TabIndex = 1;
            this.btnuseroptionfirst.Text = "بعدی";
            this.btnuseroptionfirst.UseVisualStyleBackColor = false;
            this.btnuseroptionfirst.Click += new System.EventHandler(this.btnuseroptionfirst_Click);
            // 
            // radio_send
            // 
            this.radio_send.AutoSize = true;
            this.radio_send.Location = new System.Drawing.Point(220, 67);
            this.radio_send.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radio_send.Name = "radio_send";
            this.radio_send.Size = new System.Drawing.Size(149, 33);
            this.radio_send.TabIndex = 7;
            this.radio_send.TabStop = true;
            this.radio_send.Text = "واریز به حساب";
            this.radio_send.UseVisualStyleBackColor = true;
            // 
            // radio_withraw
            // 
            this.radio_withraw.AutoSize = true;
            this.radio_withraw.Location = new System.Drawing.Point(204, 133);
            this.radio_withraw.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radio_withraw.Name = "radio_withraw";
            this.radio_withraw.Size = new System.Drawing.Size(165, 33);
            this.radio_withraw.TabIndex = 8;
            this.radio_withraw.TabStop = true;
            this.radio_withraw.Text = "برداشت از حساب";
            this.radio_withraw.UseVisualStyleBackColor = true;
            // 
            // radio_check
            // 
            this.radio_check.AutoSize = true;
            this.radio_check.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.radio_check.CausesValidation = false;
            this.radio_check.Location = new System.Drawing.Point(220, 198);
            this.radio_check.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radio_check.Name = "radio_check";
            this.radio_check.Size = new System.Drawing.Size(149, 33);
            this.radio_check.TabIndex = 9;
            this.radio_check.TabStop = true;
            this.radio_check.Text = "موجودی حساب";
            this.radio_check.UseVisualStyleBackColor = true;
            // 
            // group_clint
            // 
            this.group_clint.Controls.Add(this.rad_TIME);
            this.group_clint.Controls.Add(this.radio_withraw);
            this.group_clint.Controls.Add(this.radio_check);
            this.group_clint.Controls.Add(this.radio_send);
            this.group_clint.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.group_clint.Location = new System.Drawing.Point(248, 34);
            this.group_clint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.group_clint.Name = "group_clint";
            this.group_clint.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.group_clint.Size = new System.Drawing.Size(564, 347);
            this.group_clint.TabIndex = 10;
            this.group_clint.TabStop = false;
            this.group_clint.Text = "لطفا یکی از موارد زیر را انتخاب کرده سپس گزینه بعدی را فشار دهید :";
            // 
            // rad_TIME
            // 
            this.rad_TIME.AutoSize = true;
            this.rad_TIME.Location = new System.Drawing.Point(175, 257);
            this.rad_TIME.Margin = new System.Windows.Forms.Padding(4);
            this.rad_TIME.Name = "rad_TIME";
            this.rad_TIME.Size = new System.Drawing.Size(194, 33);
            this.rad_TIME.TabIndex = 10;
            this.rad_TIME.TabStop = true;
            this.rad_TIME.Text = "سه گردش آخر حساب";
            this.rad_TIME.UseVisualStyleBackColor = true;
            // 
            // radioDelete
            // 
            this.radioDelete.AutoSize = true;
            this.radioDelete.Location = new System.Drawing.Point(348, 119);
            this.radioDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioDelete.Name = "radioDelete";
            this.radioDelete.Size = new System.Drawing.Size(161, 29);
            this.radioDelete.TabIndex = 8;
            this.radioDelete.TabStop = true;
            this.radioDelete.Text = "حذف حساب کارمند";
            this.radioDelete.UseVisualStyleBackColor = true;
            // 
            // radioM_Em_Add
            // 
            this.radioM_Em_Add.AutoSize = true;
            this.radioM_Em_Add.Location = new System.Drawing.Point(378, 163);
            this.radioM_Em_Add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioM_Em_Add.Name = "radioM_Em_Add";
            this.radioM_Em_Add.Size = new System.Drawing.Size(131, 29);
            this.radioM_Em_Add.TabIndex = 9;
            this.radioM_Em_Add.TabStop = true;
            this.radioM_Em_Add.Text = "افزودن  کارمند";
            this.radioM_Em_Add.UseVisualStyleBackColor = true;
            // 
            // radioM_Em_send
            // 
            this.radioM_Em_send.AutoSize = true;
            this.radioM_Em_send.Location = new System.Drawing.Point(375, 71);
            this.radioM_Em_send.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioM_Em_send.Name = "radioM_Em_send";
            this.radioM_Em_send.Size = new System.Drawing.Size(134, 29);
            this.radioM_Em_send.TabIndex = 7;
            this.radioM_Em_send.TabStop = true;
            this.radioM_Em_send.Text = "واریز به حساب";
            this.radioM_Em_send.UseVisualStyleBackColor = true;
            // 
            // group_Employe
            // 
            this.group_Employe.Controls.Add(this.radE_TIME);
            this.group_Employe.Controls.Add(this.radioE_Check);
            this.group_Employe.Controls.Add(this.radioBan);
            this.group_Employe.Controls.Add(this.radioUnban);
            this.group_Employe.Controls.Add(this.radioE_send);
            this.group_Employe.Controls.Add(this.radioE_withraw);
            this.group_Employe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.group_Employe.Location = new System.Drawing.Point(145, 56);
            this.group_Employe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.group_Employe.Name = "group_Employe";
            this.group_Employe.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.group_Employe.Size = new System.Drawing.Size(725, 310);
            this.group_Employe.TabIndex = 13;
            this.group_Employe.TabStop = false;
            this.group_Employe.Text = "یکی از موارد زیر را انتخاب کنید :";
            // 
            // radE_TIME
            // 
            this.radE_TIME.AutoSize = true;
            this.radE_TIME.Location = new System.Drawing.Point(531, 265);
            this.radE_TIME.Margin = new System.Windows.Forms.Padding(4);
            this.radE_TIME.Name = "radE_TIME";
            this.radE_TIME.Size = new System.Drawing.Size(175, 29);
            this.radE_TIME.TabIndex = 11;
            this.radE_TIME.TabStop = true;
            this.radE_TIME.Text = "سه گردش آخر حساب";
            this.radE_TIME.UseVisualStyleBackColor = true;
            // 
            // radioE_Check
            // 
            this.radioE_Check.AutoSize = true;
            this.radioE_Check.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.radioE_Check.Location = new System.Drawing.Point(572, 220);
            this.radioE_Check.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioE_Check.Name = "radioE_Check";
            this.radioE_Check.Size = new System.Drawing.Size(134, 29);
            this.radioE_Check.TabIndex = 10;
            this.radioE_Check.TabStop = true;
            this.radioE_Check.Text = "موجودی حساب";
            this.radioE_Check.UseVisualStyleBackColor = true;
            // 
            // radioBan
            // 
            this.radioBan.AutoSize = true;
            this.radioBan.Location = new System.Drawing.Point(488, 80);
            this.radioBan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioBan.Name = "radioBan";
            this.radioBan.Size = new System.Drawing.Size(218, 29);
            this.radioBan.TabIndex = 7;
            this.radioBan.TabStop = true;
            this.radioBan.Text = "مسدود کردن حساب مشتری ";
            this.radioBan.UseVisualStyleBackColor = true;
            // 
            // radioUnban
            // 
            this.radioUnban.AutoSize = true;
            this.radioUnban.Location = new System.Drawing.Point(482, 172);
            this.radioUnban.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioUnban.Name = "radioUnban";
            this.radioUnban.Size = new System.Drawing.Size(224, 29);
            this.radioUnban.TabIndex = 9;
            this.radioUnban.TabStop = true;
            this.radioUnban.Text = "حذف مسدودی حساب مشتری";
            this.radioUnban.UseVisualStyleBackColor = true;
            // 
            // radioE_send
            // 
            this.radioE_send.AutoSize = true;
            this.radioE_send.Location = new System.Drawing.Point(544, 34);
            this.radioE_send.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioE_send.Name = "radioE_send";
            this.radioE_send.Size = new System.Drawing.Size(162, 29);
            this.radioE_send.TabIndex = 6;
            this.radioE_send.TabStop = true;
            this.radioE_send.Text = "واریز پول به حساب";
            this.radioE_send.UseVisualStyleBackColor = true;
            // 
            // radioE_withraw
            // 
            this.radioE_withraw.AutoSize = true;
            this.radioE_withraw.Location = new System.Drawing.Point(524, 128);
            this.radioE_withraw.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioE_withraw.Name = "radioE_withraw";
            this.radioE_withraw.Size = new System.Drawing.Size(182, 29);
            this.radioE_withraw.TabIndex = 8;
            this.radioE_withraw.TabStop = true;
            this.radioE_withraw.Text = "برداشت پول از حساب ";
            this.radioE_withraw.UseVisualStyleBackColor = true;
            // 
            // group_Manage
            // 
            this.group_Manage.Controls.Add(this.radio_History);
            this.group_Manage.Controls.Add(this.radioM_Em_Add);
            this.group_Manage.Controls.Add(this.radioDelete);
            this.group_Manage.Controls.Add(this.radioM_Em_send);
            this.group_Manage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.group_Manage.Location = new System.Drawing.Point(176, 65);
            this.group_Manage.Name = "group_Manage";
            this.group_Manage.Size = new System.Drawing.Size(566, 273);
            this.group_Manage.TabIndex = 15;
            this.group_Manage.TabStop = false;
            this.group_Manage.Text = "لطفا یکی از موارد زیر را انتخاب کنید :           ";
            this.group_Manage.Visible = false;
            // 
            // radio_History
            // 
            this.radio_History.AutoSize = true;
            this.radio_History.Location = new System.Drawing.Point(325, 211);
            this.radio_History.Name = "radio_History";
            this.radio_History.Size = new System.Drawing.Size(184, 29);
            this.radio_History.TabIndex = 10;
            this.radio_History.TabStop = true;
            this.radio_History.Text = "تاریخچه ورود و خروج";
            this.radio_History.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Coral;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(794, 398);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 47);
            this.button1.TabIndex = 2;
            this.button1.Text = "خروج از حساب";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(1016, 485);
            this.Controls.Add(this.group_Manage);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.group_Employe);
            this.Controls.Add(this.group_clint);
            this.Controls.Add(this.btnuseroptionfirst);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form3";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "خوش امدید مشتری گرامی";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form3_FormClosing);
            this.Load += new System.EventHandler(this.Form3_Load);
            this.group_clint.ResumeLayout(false);
            this.group_clint.PerformLayout();
            this.group_Employe.ResumeLayout(false);
            this.group_Employe.PerformLayout();
            this.group_Manage.ResumeLayout(false);
            this.group_Manage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnuseroptionfirst;
        private System.Windows.Forms.RadioButton radio_send;
        private System.Windows.Forms.RadioButton radio_withraw;
        private System.Windows.Forms.RadioButton radio_check;
        private System.Windows.Forms.GroupBox group_clint;
        private System.Windows.Forms.RadioButton radioDelete;
        private System.Windows.Forms.RadioButton radioM_Em_Add;
        private System.Windows.Forms.RadioButton radioM_Em_send;
        private System.Windows.Forms.GroupBox group_Employe;
        private System.Windows.Forms.RadioButton radioE_Check;
        private System.Windows.Forms.RadioButton radioBan;
        private System.Windows.Forms.RadioButton radioUnban;
        private System.Windows.Forms.RadioButton radioE_send;
        private System.Windows.Forms.RadioButton radioE_withraw;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rad_TIME;
        private System.Windows.Forms.RadioButton radE_TIME;
        private System.Windows.Forms.GroupBox group_Manage;
        private System.Windows.Forms.RadioButton radio_History;
    }
}