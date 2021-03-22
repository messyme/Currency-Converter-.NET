using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurrencyConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                // USD
                label2.Text = radioButton1.Text;

                if (string.IsNullOrEmpty(textBox1.Text))
                {
                    label3.Text = "Insert a number.";
                    label3.ForeColor = Color.Red;
                }
                else
                {
                    double curr = double.Parse(textBox1.Text);
                    curr = curr * 0.000069;

                    label3.Text = curr.ToString();
                    label3.ForeColor = Color.Black;
                }
            }
            else if (radioButton2.Checked == true)
            {
                // EUR
                label2.Text = radioButton2.Text;

                if (string.IsNullOrEmpty(textBox1.Text))
                {
                    label3.Text = "Insert a number.";
                    label3.ForeColor = Color.Red;
                }
                else
                {
                    double curr = double.Parse(textBox1.Text);
                    curr = curr * 0.000058;

                    label3.Text = curr.ToString();
                    label3.ForeColor = Color.Black;
                }
            }
            else if (radioButton3.Checked == true)
            {
                // SGD
                label2.Text = radioButton3.Text;

                if (string.IsNullOrEmpty(textBox1.Text))
                {
                    label3.Text = "Insert a number.";
                    label3.ForeColor = Color.Red;
                }
                else
                {
                    double curr = double.Parse(textBox1.Text);
                    curr = curr * 0.000093;

                    label3.Text = curr.ToString();
                    label3.ForeColor = Color.Black;
                }
            }
            else if (radioButton4.Checked == true)
            {
                // JPY
                label2.Text = radioButton4.Text;

                if (string.IsNullOrEmpty(textBox1.Text))
                {
                    label3.Text = "Insert a number.";
                    label3.ForeColor = Color.Red;
                }
                else
                {
                    double curr = double.Parse(textBox1.Text);
                    curr = curr * 0.0076;

                    label3.Text = curr.ToString();
                    label3.ForeColor = Color.Black;
                }
            }
            else if (radioButton5.Checked == true)
            {
                // CNY
                label2.Text = radioButton5.Text;

                if (string.IsNullOrEmpty(textBox1.Text))
                {
                    label3.Text = "Insert a number.";
                    label3.ForeColor = Color.Red;
                }
                else
                {
                    double curr = double.Parse(textBox1.Text);
                    curr = curr * 0.00045;

                    label3.Text = curr.ToString();
                    label3.ForeColor = Color.Black;
                }
            }
            else
            {
                label2.Text = "";
                label3.Text = "Choose one of the currency first.";
                label3.ForeColor = Color.Red;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
