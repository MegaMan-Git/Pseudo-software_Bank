using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace WindowsFormsApp1
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string today;
            string now;
            try
            {
                for (int i = 0; i < Dataclass.Clients.Count; i++)
                {
                    if (Dataclass.Clients[i].Username == textBox1.Text)
                    {
                        DateTime Time = new DateTime();
                        Time = DateTime.Now;
                        today = Time.Year.ToString();
                        today += "/" + Time.Month.ToString();
                        today += "/" + Time.Day.ToString();
                        now = Time.Hour.ToString();
                        now += ":" + Time.Minute.ToString();
                        now += ":" + Time.Second.ToString();

                        Dataclass.Clients[i].Money += int.Parse(textBox2.Text);

                        if (Dataclass.TimeNEED < 3)
                        {
                            Dataclass.Clients[i].Timesave[Dataclass.TimeNEED++] = today + "    " + now;
                        }
                        else
                        {
                            Dataclass.TimeNEED = 0;
                            Dataclass.Clients[i].Timesave[Dataclass.TimeNEED++] = today + "    " + now;
                        }

                        if (Dataclass.WithDepNEED < 3)
                        {
                            Dataclass.Clients[i].WithDepMoney[Dataclass.WithDepNEED++] = "واریز مدیر ==> " + textBox2.Text;
                        }
                        else
                        {
                            Dataclass.WithDepNEED = 0;
                            Dataclass.Clients[i].WithDepMoney[Dataclass.WithDepNEED++] = "واریز مدیر ==> " + textBox2.Text;
                        }
                        Dataclass.Clients[i].Money += int.Parse(textBox2.Text);
                        MessageBox.Show("واریز شد");
                        Form3 FR3 = new Form3(Dataclass.manager);
                        FR3.Show();
                        this.Hide();
                        return;
                    }
                }
                for (int i = 0; i < Dataclass.Employees.Count; i++)
                {
                    if (Dataclass.Employees[i].Em_username == textBox1.Text)
                    {

                        DateTime Time = new DateTime();
                        Time = DateTime.Now;
                        today = Time.Year.ToString();
                        today += "/" + Time.Month.ToString();
                        today += "/" + Time.Day.ToString();
                        now = Time.Hour.ToString();
                        now += ":" + Time.Minute.ToString();
                        now += ":" + Time.Second.ToString();

                        Dataclass.Employees[i].Money += int.Parse(textBox2.Text);

                        if (Dataclass.TimeNEED < 3)
                        {
                            Dataclass.Employees[i].Timesave[Dataclass.TimeNEED++] = today + "    " + now;
                        }
                        else
                        {
                            Dataclass.TimeNEED = 0;
                            Dataclass.Employees[i].Timesave[Dataclass.TimeNEED++] = today + "    " + now;
                        }

                        if (Dataclass.WithDepNEED < 3)
                        {
                            Dataclass.Employees[i].WithDepMoney[Dataclass.WithDepNEED++] = "واریز ==> " + textBox2.Text;
                        }
                        else
                        {
                            Dataclass.WithDepNEED = 0;
                            Dataclass.Employees[i].WithDepMoney[Dataclass.WithDepNEED++] = "واریز ==> " + textBox2.Text;
                        }
                        
                        MessageBox.Show("واریز شد");
                        Form3 FR3 = new Form3(Dataclass.manager);
                        FR3.Show();
                        this.Hide();
                        return;

                    }
                }
                MessageBox.Show("نام کاربری پیدا نشد");
            }
            catch { MessageBox.Show("مبلغ را به درستی وارد کنید"); textBox2.Clear(); }
     
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 FR3 = new Form3(Dataclass.manager);
            FR3.Show();
            this.Hide();
        }

        private void Form7_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
