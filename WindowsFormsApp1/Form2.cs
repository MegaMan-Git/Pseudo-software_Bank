using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{

    public partial class Form2sign : Form
    {
        
        public Form2sign()
        {
            InitializeComponent();
        }

        private void BtnSign_Click(object sender, EventArgs e)
        {
            string today;
            string now;
                    if (txtsignuser.Text != "" && txtsignpas1.TextLength > 7 && txtsignpas2.Text == txtsignpas1.Text)
                    {
                        bool Tekrary = false;
                        for (int i = 0; i < Dataclass.Clients.Count; i++)
                        {
                            if (Dataclass.Clients[i].Username == txtsignuser.Text )
                            {
                                Tekrary = true;
                                break;
                            }
                        }
                        for (int i = 0; i < Dataclass.Employees.Count; i++)
                        {
                           if (Dataclass.Employees[i].Em_username == txtsignuser.Text)
                           {
                              Tekrary = true;
                              break;
                           }
                        }
                        if(Dataclass.manager.MAIN_User == txtsignuser.Text)
                        {
                          Tekrary = true;
                        }

                    if (Tekrary)
                        {
                            MessageBox.Show("این نام کاربری قبلاً ثبت شده است.");
                            return;
                        }

                Dataclass.Clients.Add(new Client { Username = txtsignuser.Text, Password = txtsignpas1.Text});
                      
                        MessageBox.Show("ثبت‌نام با موفقیت انجام شد.","",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        DateTime Time = new DateTime();
                        Time = DateTime.Now;
                        today = Time.Year.ToString();
                        today += "/" + Time.Month.ToString();
                        today += "/" + Time.Day.ToString();
                        now = Time.Hour.ToString();
                        now += ":" + Time.Minute.ToString();
                        now += ":" + Time.Second.ToString();
                        Dataclass.manager.History.Add("ثبت نام در تاریخ : "+today+"    "+ now);
                        Dataclass.manager.History.Add("نام کاربری مشتری : " + Dataclass.Clients[Dataclass.Clients.Count - 1].Username);
                        Form3 FR3 = new Form3(Dataclass.Clients[Dataclass.Clients.Count - 1]);
                        FR3.Show();
                        this.Hide();
                    }
                    else if (txtsignuser.Text == "")
                    {
                        label1.Text = "نام کاربری نمیتواند خالی باشد";
                    }
                    else if (txtsignpas1.Text != txtsignpas2.Text)
                    {
                        MessageBox.Show("تکرار رمز عبور یکسان نمیباشد");
                    }
                    else
                    {
                        MessageBox.Show("رمز عبور نمیتواند کمتر از هشت حرف");
                        label1.Text = "";
                    }

        }

        private void Form2sign_Load(object sender, EventArgs e)
        {

        }

        private void Login_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            new Form1().Show();
            this.Hide();
        }

        private void label2_MouseDown(object sender, MouseEventArgs e)
        {
            txtsignpas1.PasswordChar = '\0';
        }

        private void label2_MouseUp(object sender, MouseEventArgs e)
        {
            txtsignpas1.PasswordChar = '*';
        }

        private void Form2sign_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }

}

