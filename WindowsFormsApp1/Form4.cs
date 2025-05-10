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
    public partial class Form4 : Form
    {
        private Action<int> depositMethod;
        private Action<int> withdrawMethod;
        bool Depo= false;
        int X;
        public Form4(int x,Action<int>Deposite,bool dep)
        {
            InitializeComponent();
           depositMethod = Deposite;
            Depo = dep;
           X = x;
        }
        public Form4(int x,Action<int>Withraw)
        {
            InitializeComponent();
            withdrawMethod = Withraw;
            X = x;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int amount = 0;
            string today;
            string now;
            if (Depo == true)
            {
                    
                    //تبدیل متن به عدد و ریختن (out) int amount 
                    if (int.TryParse(textBox1.Text, out amount) && amount > 0)
                    {
                        

                          if (X == 1)
                          {
                              DateTime Time = new DateTime();
                              Time = DateTime.Now;
                              today = Time.Year.ToString();
                              today += "/" + Time.Month.ToString();
                              today += "/" + Time.Day.ToString();
                              now = Time.Hour.ToString();
                              now += ":" + Time.Minute.ToString();
                              now += ":" + Time.Second.ToString();

                              if (Dataclass.TimeNEED < 3)
                              {
                                  Dataclass.Clients[Dataclass.NEED].Timesave[Dataclass.TimeNEED++] = today + "    " + now;
                              }
                              else
                              {
                                  Dataclass.TimeNEED = 0;
                                  Dataclass.Clients[Dataclass.NEED].Timesave[Dataclass.TimeNEED++] = today + "    " + now;
                              }

                              if (Dataclass.WithDepNEED < 3)
                              {
                                  Dataclass.Clients[Dataclass.NEED].WithDepMoney[Dataclass.WithDepNEED++] = "واریز ==> " + textBox1.Text;
                              }
                              else 
                              {
                                  Dataclass.WithDepNEED = 0;
                                  Dataclass.Clients[Dataclass.NEED].WithDepMoney[Dataclass.WithDepNEED++] = "واریز ==> " + textBox1.Text;
                              }

                            Form3 FR3 = new Form3(Dataclass.Clients[Dataclass.NEED]);
                           depositMethod(amount);
                           MessageBox.Show("واریز موفقیت آمیز بود");
                           this.Hide();
                            FR3.Show();
                          }

                          else if(X == 0)
                          {
                        DateTime Time = new DateTime();
                        Time = DateTime.Now;
                        today = Time.Year.ToString();
                        today += "/" + Time.Month.ToString();
                        today += "/" + Time.Day.ToString();
                        now = Time.Hour.ToString();
                        now += ":" + Time.Minute.ToString();
                        now += ":" + Time.Second.ToString();

                        if (Dataclass.TimeNEED < 3)
                        {
                            Dataclass.Employees[Dataclass.NEED].Timesave[Dataclass.TimeNEED++] = today + "    " + now;
                        }
                        else
                        {
                            Dataclass.TimeNEED = 0;
                            Dataclass.Employees[Dataclass.NEED].Timesave[Dataclass.TimeNEED++] = today + "    " + now;
                        }

                        if (Dataclass.WithDepNEED < 3)
                        {
                            Dataclass.Employees[Dataclass.NEED].WithDepMoney[Dataclass.WithDepNEED++] = "واریز ==> " + textBox1.Text;
                        }
                        else
                        {
                            Dataclass.WithDepNEED = 0;
                            Dataclass.Employees[Dataclass.NEED].WithDepMoney[Dataclass.WithDepNEED++] = "واریز ==> " + textBox1.Text;
                        }
                        Form3 FR3 = new Form3(Dataclass.Employees[Dataclass.NEED]);
                           depositMethod(amount);
                           MessageBox.Show("واریز موفقیت آمیز بود");
                           this.Hide();
                            FR3.Show();
                          }
                    }

                    else
                    {
                        MessageBox.Show("لطفا مبلغ را به درستی وارد کنید");
                    }
            }

            else if(Depo == false)
            {
                    
                    if (int.TryParse(textBox1.Text, out amount) && amount > 0)
                    {
                        
                        

                            if (X == 1 && amount < Dataclass.Clients[Dataclass.NEED].Money)
                            {
                                DateTime Time = new DateTime();
                                Time = DateTime.Now;
                                today = Time.Year.ToString();
                                today += "/" + Time.Month.ToString();
                                today += "/" + Time.Day.ToString();
                                now = Time.Hour.ToString();
                                now += ":" + Time.Minute.ToString();
                                now += ":" + Time.Second.ToString();

                                if (Dataclass.TimeNEED < 3)
                                {
                                    Dataclass.Clients[Dataclass.NEED].Timesave[Dataclass.TimeNEED++] = today + "    " + now;
                                }
                                else
                                {
                                    Dataclass.TimeNEED = 0;
                                    Dataclass.Clients[Dataclass.NEED].Timesave[Dataclass.TimeNEED++] = today + "    " + now;
                                }

                                if (Dataclass.WithDepNEED < 3)
                                {
                                    Dataclass.Clients[Dataclass.NEED].WithDepMoney[Dataclass.WithDepNEED++] = "برداشت ==> " + textBox1.Text;
                                }
                                else
                                {
                                    Dataclass.WithDepNEED = 0;
                                    Dataclass.Clients[Dataclass.NEED].WithDepMoney[Dataclass.WithDepNEED++] = "برداشت ==> " + textBox1.Text;
                                }
                                withdrawMethod(amount);
                                
                             Form3 FR3 = new Form3(Dataclass.Clients[Dataclass.NEED]); 
                             this.Hide();
                             FR3.Show();
                             
                            }
                            else if (X==0 && amount < Dataclass.Employees[Dataclass.NEED].Money)
                            {
                              DateTime Time = new DateTime();
                              Time = DateTime.Now;
                              today = Time.Year.ToString();
                              today += "/" + Time.Month.ToString();
                              today += "/" + Time.Day.ToString();
                              now = Time.Hour.ToString();
                              now += ":" + Time.Minute.ToString();
                              now += ":" + Time.Second.ToString();

                             if (Dataclass.TimeNEED < 3)
                             {
                               Dataclass.Employees[Dataclass.NEED].Timesave[Dataclass.TimeNEED++] = today + "    " + now;
                             }
                             else
                             {
                              Dataclass.TimeNEED = 0;
                              Dataclass.Employees[Dataclass.NEED].Timesave[Dataclass.TimeNEED++] = today + "    " + now;
                             }

                             if (Dataclass.WithDepNEED < 3)
                             {
                               Dataclass.Employees[Dataclass.NEED].WithDepMoney[Dataclass.WithDepNEED++] = "برداشت ==> " + textBox1.Text;
                             }
                             else
                             {
                              Dataclass.WithDepNEED = 0;
                              Dataclass.Employees[Dataclass.NEED].WithDepMoney[Dataclass.WithDepNEED++] = "برداشت ==> " + textBox1.Text;
                             }
                             withdrawMethod(amount);
                                
                                Form3 FR3 = new Form3(Dataclass.Employees[Dataclass.NEED]);
                                this.Hide();
                                FR3.Show();
                            }
                            else 
                            {
                                MessageBox.Show("موجودی کافی نیست");
                            }
                    }
                       
                   
                    else
                    {
                        MessageBox.Show("لطفا مبلغ را به درستی وارد کنید");
                        
                    }
            }  
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(X == 1)
            {
                Form3 FR3 = new Form3(Dataclass.Clients[Dataclass.NEED]);
                FR3.Show();
                this.Hide();
            }
            else if(X == 0)
            {
                Form3 FR3 = new Form3(Dataclass.Employees[Dataclass.NEED]);
                FR3.Show();
                this.Hide();
            }
        }
    }
}
