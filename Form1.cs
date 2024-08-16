using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography.X509Certificates;


namespace EnCal
{
    public partial class Form1 : Form
    {
        double a = 0.0;
        double b = 0.0;
        int count;
        bool checking = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //ThemeResolutionService.ApplicationThemeName = "Windows7";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void textBox1_TextChanged(object sender, EventArgs e, TextBox textBox1) //ввод
        {
            textBox1.ReadOnly = true;
        }

        private void button1_Click_1(object sender, EventArgs e) //C
        {
            textBox1.Text = null;
            label1.Text = null;
        }

        public void button2_Click(object sender, EventArgs e) // %
        {
            a = Double.Parse(textBox1.Text);
            textBox1.Clear();
            count = 5;
            label1.Text = a.ToString() + "%";
            checking = true;
        }

        public void button3_Click(object sender, EventArgs e) // +/-
        {
            if (checking)
            {
                textBox1.Text += "-";
                checking = false;
            }
            else
            {
                textBox1.Text = textBox1.Text.Replace("-", "");
                checking = true;
            }
        }

        public void button13_Click(object sender, EventArgs e) // <--
        {
            var deliteEl = textBox1.TextLength - 1;
            string str = textBox1.Text;
            textBox1.Clear();
            for (int i = 0; i < deliteEl; i++)
                textBox1.Text += str[i];
        }
        public void button4_Click(object sender, EventArgs e) //1
        {
            textBox1.Text += 1;
        }

        public void button5_Click(object sender, EventArgs e) //2
        {
            textBox1.Text += 2;
        }

        public void button6_Click(object sender, EventArgs e) //3
        {
            textBox1.Text += 3;
        }

        public void button7_Click(object sender, EventArgs e) //4
        {
            textBox1.Text += 4;
        }

        public void button8_Click(object sender, EventArgs e) //5
        {
            textBox1.Text += 5;
        }

        public void button9_Click(object sender, EventArgs e) //6
        {
            textBox1.Text += 6;
        }

        public void button10_Click(object sender, EventArgs e) //7
        {
            textBox1.Text += 7;
        }

        public void button11_Click(object sender, EventArgs e) //8
        {
            textBox1.Text += 8;
        }

        public void button12_Click(object sender, EventArgs e) //9
        {
            textBox1.Text += 9;
        }

        public void button18_Click(object sender, EventArgs e) //0
        {
            textBox1.Text += 0;
        }

        public void button17_Click(object sender, EventArgs e) // *
        {
            textBox1.Text += ",";
        }

        public void button19_Click(object sender, EventArgs e) // =
        {
            mathCalculate();
            label1.Text = "";
        }
        private void mathCalculate()
        {
            switch (count)
            {
                case 1:
                    b = a + Double.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 2:
                    b = a - Double.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 3:
                    b = a * Double.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 4:
                    b = a / Double.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 5:
                    b = a % Double.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;

                default:
                    break;
            }
        }

        public void button14_Click(object sender, EventArgs e)
        {
            a = Double.Parse(textBox1.Text);
            textBox1.Clear();
            count = 1;
            label1.Text = a.ToString() + "+";
            checking = true;
        }

        public void button15_Click(object sender, EventArgs e)
        {
            a = Double.Parse(textBox1.Text);
            textBox1.Clear();
            count = 2;
            label1.Text = a.ToString() + "-";
            checking = true;
        }

        public void button16_Click(object sender, EventArgs e)
        {
            a = Double.Parse(textBox1.Text);
            textBox1.Clear();
            count = 3;
            label1.Text = a.ToString() + "*";
            checking = true;
        }

        public void button20_Click(object sender, EventArgs e)
        {
            a = Double.Parse(textBox1.Text);
            textBox1.Clear();
            count = 4;
            label1.Text = a.ToString() + "÷";
            checking = true; 
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {

        }
    }
}
