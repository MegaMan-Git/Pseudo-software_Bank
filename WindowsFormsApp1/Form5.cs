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
    public partial class Form5 : Form
    {
        bool FlagCheckClinet =false;
        bool FlagCheckEmployee =false;
        int X;
        public Form5(int x)
        {
            InitializeComponent();
            X = x;
            if (X == 1)
            {
                FlagCheckClinet = true;
            }
            else 
            {
                FlagCheckEmployee = true;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (X == 1)
            { 
                Form3 FR3 = new Form3(Dataclass.Clients[Dataclass.NEED]);
                this.Hide();
                FR3.Show();
            }
            else
            {
                Form3 FR3 = new Form3(Dataclass.Employees[Dataclass.NEED]);
                this.Hide();
                FR3.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 FR1 = new Form1();
            this.Hide();
            FR1.Show();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            if (FlagCheckClinet)
            {
                lbl_mojody.Text = Convert.ToString(Dataclass.Clients[Dataclass.NEED].Money);
            }

            else if (FlagCheckEmployee) 
            {
                lbl_mojody.Text = Convert.ToString(Dataclass.Employees[Dataclass.NEED].Money);
            }
        }

        private void Form5_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
