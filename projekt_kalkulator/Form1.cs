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
    }
}
