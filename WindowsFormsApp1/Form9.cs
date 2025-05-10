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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
            for (int i = 0; i < Dataclass.manager.History.Count; i++) 
            {
                listBox1.Items.Add(Dataclass.manager.History[i++]);
                listBox1.Items.Add(Dataclass.manager.History[i]);
                listBox1.Items.Add("-----------------------------------------------------");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 FR3 = new Form3(Dataclass.manager);
            FR3.Show();
            this.Hide();
        }

        private void Form9_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
