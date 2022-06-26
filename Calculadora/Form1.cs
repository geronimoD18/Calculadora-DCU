using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        private double n1, n2, result;
        private int ops;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            // Button 0
            textBox1.Text = textBox1.Text + "0";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            // Button 1
            textBox1.Text = textBox1.Text + "1";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            // Button 2
            textBox1.Text = textBox1.Text + "2";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            // Button 3
            textBox1.Text = textBox1.Text + "3";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            // Button 4
            textBox1.Text = textBox1.Text + "4";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // Button 5
            textBox1.Text = textBox1.Text + "5";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // Button 6
            textBox1.Text = textBox1.Text + "6";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Button 7
            textBox1.Text = textBox1.Text + "7";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Button 8
            textBox1.Text = textBox1.Text + "8";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Button 9
            textBox1.Text = textBox1.Text + "9";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Button Clear
            textBox1.Text = " ";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            // Button result
            n2 = Convert.ToDouble(textBox1.Text);

            switch (ops)
            {
                case 1:
                    result = n1 + n2;
                    break;
                case 2:
                    result = n1 - n2;
                    break;
                case 3:
                    result = n1 * n2;
                    break;
                case 4:
                    result = n1 / n2;
                    break;
            }

            textBox1.Text = result.ToString();
        }


        private void btnSuma_Click(object sender, EventArgs e)
        {
            // Button Add
            ops = 1;
            n1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            // Button Less
            ops = 2;
            n1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            // Button Times
            ops = 3;
            n1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            // Button Div
            ops = 4;
            n1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            // Button Dot
            textBox1.Text = textBox1.Text + ".";
        }
    }
}
