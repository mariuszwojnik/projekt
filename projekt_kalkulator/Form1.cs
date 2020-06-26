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
        float iCelsius, iFahrenheit, iKelvin;
        char iOperation;
        public Form1()
        {
            InitializeComponent();

        }

        private void standardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 330;
            textBox1.Width = 286;
        }

        private void button1_Click(object sender, EventArgs e) //BACKSPACE
        {
            if (textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
            }
            if (textBox1.Text == "") //wyświetlanie zera kiedy wyświetlacz jest pusty
            {
                textBox1.Text = "0";
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            double a;

            a = Convert.ToDouble(textBox1.Text) / Convert.ToDouble(100);
            textBox1.Text = System.Convert.ToString(a);
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
            textBox2.Focus();

            groupBox1.Visible = true;
            groupBox2.Visible = true;
            groupBox3.Visible = false;
            groupBox1.Location = new Point(624, 27);


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
            txtMultiply.Focus();
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = true;

            groupBox3.Location = new Point(624, 27);
            groupBox3.Width = 435;
            groupBox3.Height = 394;
        }

        private void button_Click(object sender, EventArgs e)  //wprowadzanie do "wyświetlacza" symboli z przycisków
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

        private void button2_Click(object sender, EventArgs e) //CE
        {
            textBox1.Text = "0"; 
            lblShow.Text = "";
        }

        private void button3_Click(object sender, EventArgs e) //C
        {
            textBox1.Text = "0";
            lblShow.Text = "";
        }

        private void button20_Click_1(object sender, EventArgs e)
        {

        }

        private void Arithmetic_Operator(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            operation = num.Text;
            results = Double.Parse(textBox1.Text);
            textBox1.Text = "";
            lblShow.Text = System.Convert.ToString(results) + " " + operation;
        }

        private void button19_Click(object sender, EventArgs e) // znak równości
        {
            lblShow.Text = " ";
            switch(operation)
            {
                case "+": 
                    textBox1.Text = (results + Double.Parse(textBox1.Text)).ToString();
                    break;
                case "-":
                    textBox1.Text = (results - Double.Parse(textBox1.Text)).ToString();
                    break;
                case "*":
                    textBox1.Text = (results * Double.Parse(textBox1.Text)).ToString();
                    break;
                case "/":
                    textBox1.Text = (results / Double.Parse(textBox1.Text)).ToString();
                    break;
                case "Mod":
                    textBox1.Text = (results % Double.Parse(textBox1.Text)).ToString();
                    break;
                case "Exp":
                    double i = Double.Parse(textBox1.Text);
                    double q;
                    q = (results);
                    textBox1.Text = Math.Exp(i * Math.Log(q * 4)).ToString();
                    break;

            }
        }

        private void button21_Click(object sender, EventArgs e) //liczba PI
        {
            textBox1.Text = "3.14159265359";
        }

        private void button26_Click(object sender, EventArgs e) //logarytm
        {
            double ilog = Double.Parse(textBox1.Text);
            lblShow.Text = System.Convert.ToString("log" + "(" + (textBox1.Text) + ")");// kontrolka lblShow słuzy do wyświetlania aktualnie wykonywanego działania
            ilog = Math.Log10(ilog);
            textBox1.Text = System.Convert.ToString(ilog);
            
        }

        private void button31_Click(object sender, EventArgs e) //pierwiastek kwadratowy
        {
            double sq = Double.Parse(textBox1.Text);
            lblShow.Text = System.Convert.ToString("sqrt" + "(" + (textBox1.Text) + ")");// kontrolka lblShow słuzy do wyświetlania aktualnie wykonywanego działania
            sq = Math.Sqrt(sq);
            textBox1.Text = System.Convert.ToString(sq);

        }

        private void button22_Click(object sender, EventArgs e) //Sinus h
        {
            double qSinh = Double.Parse(textBox1.Text);
            lblShow.Text = System.Convert.ToString("sinh" + "(" + (textBox1.Text) + ")");// kontrolka lblShow słuzy do wyświetlania aktualnie wykonywanego działania
            qSinh = Math.Sinh(qSinh);
            textBox1.Text = System.Convert.ToString(qSinh);
        }

        private void button27_Click(object sender, EventArgs e) //sinus
        {
           
                double qSin = Double.Parse(textBox1.Text);
                lblShow.Text = System.Convert.ToString("sin" + "(" + (textBox1.Text) + ")");// kontrolka lblShow słuzy do wyświetlania aktualnie wykonywanego działania
                qSin= Math.Sin(qSin);
                textBox1.Text = System.Convert.ToString(qSin);
            
        }

        private void button23_Click(object sender, EventArgs e) //cosinus h
        {
            double qCosh = Double.Parse(textBox1.Text);
            lblShow.Text = System.Convert.ToString("Cosh" + "(" + (textBox1.Text) + ")");// kontrolka lblShow słuzy do wyświetlania aktualnie wykonywanego działania
            qCosh = Math.Cosh(qCosh);
            textBox1.Text = System.Convert.ToString(qCosh);
        }

        private void button28_Click(object sender, EventArgs e) //cosinus
        {
            double qCos = Double.Parse(textBox1.Text);
            lblShow.Text = System.Convert.ToString("Cos" + "(" + (textBox1.Text) + ")");// kontrolka lblShow słuzy do wyświetlania aktualnie wykonywanego działania
            qCos = Math.Cos(qCos);
            textBox1.Text = System.Convert.ToString(qCos);
        }

        private void button24_Click(object sender, EventArgs e) //Tanges h
        {
            double qTanh = Double.Parse(textBox1.Text);
            lblShow.Text = System.Convert.ToString("Tanh" + "(" + (textBox1.Text) + ")");// kontrolka lblShow słuzy do wyświetlania aktualnie wykonywanego działania
            qTanh = Math.Tanh(qTanh);
            textBox1.Text = System.Convert.ToString(qTanh);
        }

        private void button29_Click(object sender, EventArgs e) // Tanges
        {
            double qTan = Double.Parse(textBox1.Text);
            lblShow.Text = System.Convert.ToString("Tan" + "(" + (textBox1.Text) + ")");// kontrolka lblShow słuzy do wyświetlania aktualnie wykonywanego działania
            qTan = Math.Tan(qTan);
            textBox1.Text = System.Convert.ToString(qTan);
        }

        private void button33_Click(object sender, EventArgs e) // binarne
        {
            int a = int.Parse(textBox1.Text);
            textBox1.Text = System.Convert.ToString(a, 2);
        }

        private void button34_Click(object sender, EventArgs e) //hexadecymalne
        {
            int a = int.Parse(textBox1.Text);
            textBox1.Text = System.Convert.ToString(a, 16);
        }

        private void button35_Click(object sender, EventArgs e) //oktalne
        {
            int a = int.Parse(textBox1.Text);
            textBox1.Text = System.Convert.ToString(a, 8);
        }

        private void button32_Click(object sender, EventArgs e) //decymalne
        {
            int a = int.Parse(textBox1.Text);
            textBox1.Text = System.Convert.ToString(a);
        }

        private void button36_Click(object sender, EventArgs e) //kwadrat
        {
            double a;

            a = Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox1.Text);
            textBox1.Text = System.Convert.ToString(a);
        }

        private void button37_Click(object sender, EventArgs e)// potęgowanie 3
        {
            double a;

            a = Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox1.Text);
            textBox1.Text = System.Convert.ToString(a);
        }

        private void button38_Click(object sender, EventArgs e) //1/x
        {
            double a;

            a = Convert.ToDouble(1.0 / Convert.ToDouble(textBox1.Text));
            textBox1.Text = System.Convert.ToString(a);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)// radio cel-fah
        {
            iOperation = 'C';
        }

        private void rbFahToCel_CheckedChanged(object sender, EventArgs e)// radio fah-cel
        {
            iOperation = 'F';
        }

        private void rbKelvin_CheckedChanged(object sender, EventArgs e)// radio kelvin
        {
            iOperation = 'K';
        }

        private void button42_Click(object sender, EventArgs e)//reset
        {
            textBox2.Clear();
            lblConvert.Text = "";
            rbCelToFah.Checked = false;
            rbFahToCel.Checked = false;
            rbKelvin.Checked = false;


        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            int a;
            a = Convert.ToInt32(txtMultiply.Text);
            for (int i = 1; i <13; i++)
            {
                lstMultiply.Items.Add(i + " x" + a + " = "+ a * i);
            }
        }

        private void wyjścieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnResetM_Click(object sender, EventArgs e)
        {
            lstMultiply.Items.Clear();
            txtMultiply.Clear();
        }

        private void button39_Click(object sender, EventArgs e) // logarytm naturalny z x
        {
            double ilog = Double.Parse(textBox1.Text);
            lblShow.Text = System.Convert.ToString("log" + "(" + (textBox1.Text) + ")");// kontrolka lblShow słuzy do wyświetlania aktualnie wykonywanego działania
            ilog = Math.Log(ilog);
            textBox1.Text = System.Convert.ToString(ilog);
        }

        private void button41_Click(object sender, EventArgs e) //zachowanie przycisku konwertuj
        {
            switch(iOperation)
            {
                case 'C':
                    //cel-fah
                    iCelsius = float.Parse(textBox2.Text);
                    lblConvert.Text = ((((9 * iCelsius) / 5) + 32).ToString());
                    break;
                case 'F': 
                    //cel-fah
                    iFahrenheit = float.Parse(textBox2.Text);
                    lblConvert.Text = (((((iFahrenheit) - 32) * 5) / 9).ToString());
                    break;
                case 'K':
                    //cel-fah
                    iKelvin = float.Parse(textBox2.Text);
                    lblConvert.Text = (((((9 * iKelvin) / 5) + 32) + 273.15).ToString());
                    break;
            }
        }
    }
}
