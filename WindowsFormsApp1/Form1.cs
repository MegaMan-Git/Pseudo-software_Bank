using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar; //
using static System.Windows.Forms.VisualStyles.VisualStyleElement;  //
using System.IO;
using System.Runtime.Remoting.Messaging;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace WindowsFormsApp1
{

    public partial class Form1 : Form
    {
        Manager manager= new Manager();
        public Form1()
        {
            InitializeComponent();

        }


        private void BtnFirstEnter_Click(object sender, EventArgs e)
        {
            string today;
            string now;
            if (txt1user.Text == Dataclass.manager.MAIN_User && txt1pass.Text == Dataclass.manager.MAIN_Pass)
            {
                DateTime Time = new DateTime();
                Time = DateTime.Now;
                today = Time.Year.ToString();
                today += "/" + Time.Month.ToString();
                today += "/" + Time.Day.ToString();
                now = Time.Hour.ToString();
                now += ":" + Time.Minute.ToString();
                now += ":" + Time.Second.ToString();
                Dataclass.manager.History.Add("ورود در تاریخ :  " + today + "     " + now);
                Dataclass.manager.History.Add("ورود مدیر : " + Dataclass.manager.MAIN_User);
                Form3 Fr3 = new Form3(manager);
                Fr3.Show();
                this.Hide();
                
                return;
            }
            else
            {
                for (int j = 0; j < Dataclass.Clients.Count; j++)
                {
                
                if (Dataclass.Clients[j] != null && txt1user.Text == Dataclass.Clients[j].Username && txt1pass.Text == Dataclass.Clients[j].Password)
                {
                        if (Dataclass.Clients[j].Cl_ban == true)
                        {
                            MessageBox.Show("حساب کاربری مسدود است","اطلاعیه",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                            return;
                        }
                        DateTime Time = new DateTime();
                        Time = DateTime.Now;
                        today = Time.Year.ToString();
                        today += "/" + Time.Month.ToString();
                        today += "/" + Time.Day.ToString();
                        now = Time.Hour.ToString();
                        now += ":" + Time.Minute.ToString();
                        now += ":" + Time.Second.ToString();
                        Dataclass.manager.History.Add("ورود در تاریخ : "+today+"    "+ now);
                        Dataclass.manager.History.Add("نام کاربری مشتری : " + Dataclass.Clients[j].Username);
                        Form3 Fr3 = new Form3(Dataclass.Clients[j]);

                    Fr3.Show();
                    this.Hide();
                    return;
                }
            }
                for (int j = 0; j < Dataclass.Employees.Count; j++)
                {

                    if (Dataclass.Employees[j] != null && txt1user.Text == Dataclass.Employees[j].Em_username && txt1pass.Text == Dataclass.Employees[j].Em_password)
                    {
                        DateTime Time = new DateTime();
                        Time = DateTime.Now;
                        today = Time.Year.ToString();
                        today += "/" + Time.Month.ToString();
                        today += "/" + Time.Day.ToString();
                        now = Time.Hour.ToString();
                        now += ":" + Time.Minute.ToString();
                        now += ":" + Time.Second.ToString();
                        Dataclass.manager.History.Add("ورود در تاریخ : " + today + "    " + now);
                        Dataclass.manager.History.Add("نام کاربری کارمند : " + Dataclass.Employees[j].Em_username); 
                        Form3 Fr3 = new Form3(Dataclass.Employees[j]);

                        Fr3.Show();
                        this.Hide();
                        return;
                    }
                }
                
                MessageBox.Show("اطلاعات وارد شده وجود ندارد");
                return;
            }
        }

        private void linksign_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            new Form2sign().Show();
            this.Hide();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

      

        private void label2_MouseUp(object sender, MouseEventArgs e)
        {
            txt1pass.PasswordChar = '*';
        }

        private void label2_MouseDown(object sender, MouseEventArgs e)
        {
            txt1pass.PasswordChar = '\0';
        }
    }
}