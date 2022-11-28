using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace generateTablesOfValuesOfFunctions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public double radian = 180 / Math.PI;
        public float step = 1.0f;

        public void generate(string s)
        {

            for (float i = 0.0f; i < 360.0f; i += step)
            {
                label2.Text = i.ToString();
                label2.Refresh();
                if (s == "sin")
                {
                    textBox1.Text += "\r\n" + Math.Sin(i) + " , " + i.ToString();
                }
                else if (s == "cos")
                {
                    textBox1.Text += "\r\n" + Math.Cos(i) + " , " + i.ToString();
                }
                else if (s == "tan")
                {
                    textBox1.Text += "\r\n" + Math.Tan(i) + " , " + i.ToString();
                }
                else if (s == "ctg")
                {
                    textBox1.Text += "\r\n" + Math.Cos(i)/Math.Sin(i) + " , " + i.ToString();
                }
                else if (s == "sec")
                {
                    textBox1.Text += "\r\n" + 1/Math.Sin(i)  + " , " + i.ToString();
                }
                else if (s == "cosec")
                {
                    textBox1.Text += "\r\n" + 1/Math.Cos(i) / Math.Sin(i) + " , " + i.ToString();
                }
                else if (s == "pi")
                {
                    textBox1.Text += "\r\n" + Math.PI + " , " + i.ToString();
                    i = 359;
                }
                else if (s == "log")
                {
                    textBox1.Text += "\r\n" + Math.Log(i) + " , " + i.ToString();
                }
                else if (s == "exp")
                {
                    textBox1.Text += "\r\n" + Math.Exp(i) + " , " + i.ToString();
                }
                else if (s == "pow")
                {
                    textBox1.Text += "\r\n" + Math.Pow(i,2) + " , " + i.ToString();
                }
                else if (s == "sqrt")
                {
                    textBox1.Text += "\r\n" + Math.Sqrt(i) + " , " + i.ToString();
                }
                else if (s == "rad")
                {
                    textBox1.Text += "\r\n" + i/radian + " , " + i.ToString();
                }
                else if (s == "grad")
                {
                    textBox1.Text += "\r\n" + radian*i + " , " + i.ToString();
                }
                else
                {
                    i = 360;
                    MessageBox.Show("Nimic");
                }
                textBox1.Refresh();
                /*
                 sin
cos
tan
ctg
sec
cosec
pi
log
exp
pow
sqrt
rad
grad
                 */
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
                    
                generate(comboBox1.Text);
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {
            char c = (char)e.KeyValue;

            if (Char.IsDigit(c) == true)
            {
                try
                {
                    step = (float)Convert.ToDouble(this.textBox2.Text);
                }
                catch { }
            }
            else
            {
                if (Char.IsLetter(c) == true)
                {
                    MessageBox.Show("error");
                }
                else
                {
                    try
                    {
                        step = (float)Convert.ToDouble(this.textBox2.Text);
                    }
                    catch { }
                }
            }
            label3.Text = step.ToString();
            label3.Refresh();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
             this.textBox1.Clear(); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.SelectAll();
            textBox1.Focus();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(this.textBox1.SelectedText);
            label4.Text = "Copiat";
            label4.Refresh();
            Thread.Sleep(500);
            label4.Text = ".............";

        }
    }
}
