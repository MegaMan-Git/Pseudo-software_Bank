using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button; //static add

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
       
       Manager Master = new Manager();
        
        public Form3(Manager manager)
        {            
            InitializeComponent ();
            this.Text = "خوش آمدید مدیر محترم";
            Master = manager;
            group_Manage.Visible = true;
          
            group_Manage.BringToFront();
            group_clint.Visible = false;
          
            group_Employe.Visible = false;
            
            
        }
        public Form3(Client client)
        {
            InitializeComponent ();
            this.Text = "خوش آمدید مشتری گرامی";
            for (int i = 0; i < Dataclass.Clients.Count; i++) {
                if (client.Username == Dataclass.Clients[i].Username) { Dataclass.NEED = i; break; }
            }
            group_clint.Visible = true;
          
            group_Employe.Visible = false;
           
            group_Manage.Visible = false;
            
        }
        public Form3(Employee log)
        {
            InitializeComponent ();
            this.Text = "خوش آمدید کارمند گرامی";
                for (int i = 0; i < Dataclass.Employees.Count; i++)
                {
                    if (log.Em_username == Dataclass.Employees[i].Em_username) { Dataclass.NEED = i; break; }
                }
            group_clint.Visible = false;
            
            group_Employe.Visible = true;
                
            group_Manage.Visible = false;
            
        }

        private void btnuseroptionfirst_Click(object sender, EventArgs e)
        {
            // X==1 == Client
            int X=1;
            
            if (group_clint.Visible == true)
            {
                
                if(radio_send.Checked == true)
                {
                    
                    Form4 FR4 = new Form4(X,Dataclass.Clients[Dataclass.NEED].Deposite,true);
                    FR4.Show();
                    this.Hide();
                }
                else if(radio_withraw.Checked== true)
                {
                    
                    Form4 FR4 = new Form4(X,Dataclass.Clients[Dataclass.NEED].Withraw);
                    FR4.Show();
                    this.Hide();
                }
                else if(radio_check.Checked == true)
                {
                    Form5 FR5 =new Form5(X);
                    FR5.Show();
                    this.Hide();
                }
                else if(rad_TIME.Checked == true)
                {
                    
                    Form8 FR8 = new Form8(X);
                    FR8.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("لطفا یکی از گزینه های زیر را وارد کنید","توجه",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }

            else if (group_Employe.Visible == true)
            {
                // X==0 == Employee
                X = 0;
                if (radioE_send.Checked == true)
                {
                    Form4 FR4 = new Form4(X,Dataclass.Employees[Dataclass.NEED].Deposite,true);
                    FR4.Show();
                    this.Hide();
                }
                else if (radioE_withraw.Checked == true)
                {
                    Form4 FR4 = new Form4(X, Dataclass.Employees[Dataclass.NEED].Withraw);
                    FR4.Show();
                    this.Hide();
                }
                else if (radioE_Check.Checked == true)
                {
                    Form5 FR5 = new Form5(X);
                    FR5.Show();
                    this.Hide();
                }
                else if(radE_TIME.Checked == true)
                {
                    Form8 FR8 = new Form8(X);
                    FR8.Show();
                    this.Hide();
                }
                else if (radioBan.Checked == true)
                {
                    Form6 FR6 = new Form6(3);
                    FR6.Show();
                    this.Hide();
                }
                else if (radioUnban.Checked == true)
                {
                    Form6 FR6 = new Form6(4);
                    FR6.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("لطفا یکی از گزینه های زیر را وارد کنید", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            else
            {
                // manager X==2
                X = 2;
               if(radioM_Em_Add.Checked == true)
                {
                    Form6 FR6 = new Form6(1);
                    FR6.Show();
                    this.Hide();
                }
                else if(radioDelete.Checked == true)
                {
                    Form6 FR6 = new Form6(2);
                    FR6.Show();
                    this.Hide();
                }
               else if(radioM_Em_send.Checked == true)
                {
                    Form7 FR7 = new Form7();
                    FR7.Show();
                    this.Hide();
                }
               else if(radio_History.Checked == true)
                {
                    Form8 FR8 = new Form8(X);
                    FR8.Show();
                    this.Hide();
                }
                else 
                { 
                    MessageBox.Show("لطفا یکی از گزینه های زیر را وارد کنید", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string today;
            string now;
            DateTime Time = new DateTime();
            Time = DateTime.Now;
            today = Time.Year.ToString();
            today += "/" + Time.Month.ToString();
            today += "/" + Time.Day.ToString();
            now = Time.Hour.ToString();
            now += ":" + Time.Minute.ToString();
            now += ":" + Time.Second.ToString();

            if (group_clint.Visible == true)
            {
                
                Dataclass.manager.History.Add("خروج در تاریخ :   " + today + "  " + now);
                Dataclass.manager.History.Add("خروج مشتری :" + Dataclass.Clients[Dataclass.NEED].Username);
            }
            else if (group_Employe.Visible == true)
            {
                Dataclass.manager.History.Add("خروج در تاریخ :   " + today + "  " + now);
                Dataclass.manager.History.Add("خروج کارمند :" + Dataclass.Employees[Dataclass.NEED].Em_username);
            }
            else
            {
                Dataclass.manager.History.Add("خروج در تاریخ :   " + today + "  " + now);
                Dataclass.manager.History.Add("خروج مدیر :" + Dataclass.manager.MAIN_User);
            }
            new Form1().Show();
            this.Hide();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
           
          
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
