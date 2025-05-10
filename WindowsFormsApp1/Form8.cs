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
    public partial class Form8 : Form
    {
        int X;
        ListBox listBox1 = new ListBox();
        public Form8(int x)
        {
            InitializeComponent();
            
            X = x;
            if (X < 2) 
            {
                
                listBox1.Location = new Point(215, 70);
                listBox1.Size = new Size(211,202);
                listBox1.TabIndex = 0;
                listBox1.Font = new Font("Microsoft Sans Serif", 9);
                this.Controls.Add(listBox1);
                if (X == 1)
                {
                    
                    for (int i = 0; i < 3; i++)
                    {
                        if (Dataclass.Clients[Dataclass.NEED].Timesave[i] != null)
                        {
                            listBox1.Items.Add(Dataclass.Clients[Dataclass.NEED].Timesave[i]);
                            listBox1.Items.Add(Dataclass.Clients[Dataclass.NEED].WithDepMoney[i]);
                            listBox1.Items.Add("---------------------------------");
                        }   
                    }
                }
                else if (X == 0)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        if (Dataclass.Employees[Dataclass.NEED].Timesave[i] != null)
                        {
                            listBox1.Items.Add(Dataclass.Employees[Dataclass.NEED].Timesave[i]);
                            listBox1.Items.Add(Dataclass.Employees[Dataclass.NEED].WithDepMoney[i]);
                            listBox1.Items.Add("---------------------------------");
                        }
                    }
                        
                    
                }
            }
            else if (X == 2)  
            {
                
                listBox1.Location = new Point(190, 35);
                listBox1.Size = new Size(273, 279);
                listBox1.TabIndex = 0;
                listBox1.Font = new Font("Microsoft Sans Serif", 12);
                this.Controls.Add(listBox1);
                
                for (int i = 0; i < Dataclass.manager.History.Count; i++)
                {
                    listBox1.Items.Add(Dataclass.manager.History[i++]);
                    listBox1.Items.Add(Dataclass.manager.History[i]);
                    listBox1.Items.Add("-----------------------------------------------------");
                }
            }

        }
            private void button1_Click(object sender, EventArgs e)
            {
            listBox1.Items.Clear();
                if (X == 1)
                {
                
                Form3 FR3 = new Form3(Dataclass.Clients[Dataclass.NEED]);
                    FR3.Show();
                    this.Hide();
                }
                else if (X == 0)
                {
                    Form3 FR3 = new Form3(Dataclass.Employees[Dataclass.NEED]);
                    FR3.Show();
                    this.Hide();
                }
                else
                {
                    Form3 FR3 = new Form3(Dataclass.manager);
                    FR3.Show();
                    this.Hide();
                }
            }

        private void Form8_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }
    }
}
