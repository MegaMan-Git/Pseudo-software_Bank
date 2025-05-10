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
    public partial class Form6 : Form
    {
        int Z;
        public Form6(int x)
        {
            InitializeComponent();
            Z = x;
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            if (Z == 1)
            {
                for (int i = Dataclass.Clients.Count - 1; i >= 0; i--)
                {

                    if (Dataclass.Clients[i].Username == textBox1.Text)
                    {
                        Dataclass.Employees.Add(new Employee
                        {
                            Em_username = Dataclass.Clients[i].Username,
                            Em_password = Dataclass.Clients[i].Password,
                            Money = Dataclass.Clients[i].Money,
                            Timesave = Dataclass.Clients[i].Timesave,
                            WithDepMoney = Dataclass.Clients[i].WithDepMoney,
                        });
                        Dataclass.Clients.RemoveAt(i);
                        MessageBox.Show("اضافه شد");
                        Form3 FR3 = new Form3(Dataclass.manager);
                        FR3.Show();
                        this.Hide();
                        return;
                    }
                }
                MessageBox.Show("نام کاربری وجود ندارد");
            }
            else if (Z == 2)
            {
                for (int i = Dataclass.Employees.Count - 1; i >= 0; i--)
                {
                    if (Dataclass.Employees[i].Em_username == textBox1.Text)
                    {
                        Dataclass.Employees.RemoveAt(i);
                        MessageBox.Show("حذف شد");
                        Form3 FR3 = new Form3(Dataclass.manager);
                        FR3.Show();
                        this.Hide();
                        return;
                    }
                }
                MessageBox.Show("نام کاربری وجود ندارد");
            }
            else if (Z == 3)
            {
                for (int i = Dataclass.Clients.Count - 1; i >= 0; i--)
                {
                    if (Dataclass.Clients[i].Username == textBox1.Text)
                    {
                        Dataclass.Clients[i].Cl_ban = true;
                        MessageBox.Show("مسدود شد");
                        Form3 FR3 = new Form3(Dataclass.Employees[Dataclass.NEED]);
                        FR3.Show();
                        this.Hide();
                        return;
                    }
                }
                MessageBox.Show("نام کاربری یافت نشد");
            }
            else if (Z == 4)
            {
                for (int i = Dataclass.Clients.Count - 1; i >= 0; i--)
                {
                    if (Dataclass.Clients[i].Username == textBox1.Text && Dataclass.Clients[i].Cl_ban != false)
                    {
                        Dataclass.Clients[i].Cl_ban = false;
                        MessageBox.Show("مسدودیت برداشته شده");
                        Form3 FR3 = new Form3(Dataclass.Employees[Dataclass.NEED]);
                        FR3.Show();
                        this.Hide();
                        return;
                    }
                }
                MessageBox.Show(" نام کاربری یافت نشد یا مسدود نیست");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Z == 1 || Z == 2)
            {
                Form3 FR3 = new Form3(Dataclass.manager);
                FR3.Show();
                this.Hide();
            }
            else if(Z == 3 || Z ==4)
            {
                Form3 FR3 = new Form3(Dataclass.Employees[Dataclass.NEED]);
                FR3.Show();
                this.Hide();
            }
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void Form6_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
