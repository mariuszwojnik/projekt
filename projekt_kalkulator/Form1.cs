using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projekt_kalkulator
{
    public partial class Form1 : Form
    {
        Double results = 0;
        String operation = "";
        bool enter_value = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void standardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 330;
            textBox1.Width = 286;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text .Length > 0)
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {

        }

        private void naukowyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 628;
            textBox1.Width = 587;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void temperaturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 1087;
            textBox1.Width = 587;
            
        }

        private void konwerterJednostekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 1087;
            textBox1.Width = 587;
        }

        private void mnożenieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 1087;
            textBox1.Width = 587;
        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0") || (enter_value))
                textBox1.Text = "";
            enter_value = false;
            Button num = (Button)sender;
            if (num.Text == ".")
            {
                if (!textBox1.Text.Contains("."))
                    textBox1.Text = textBox1.Text + num.Text;
            }
            else
                textBox1.Text = textBox1.Text + num.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            lblShow.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            lblShow.Text = "";
        }
    }
}
