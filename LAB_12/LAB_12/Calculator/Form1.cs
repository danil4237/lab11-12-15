using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        float number1, number2;
        int count;
        bool operations = true;
        public Form1()
        {
            InitializeComponent();
        }

        
        




        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button0_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }
        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }
        private void button10_Click(object sender, EventArgs e)
        {
            int length = textBox1.Text.Length - 1;
            string text = textBox1.Text;
            textBox1.Clear();

            for (int i = 0; i < length; i++)
            {
                textBox1.Text = textBox1.Text + text[i];
            }
          
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            number1=float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 1;
            label2.Text = number1.ToString() + "+";
            operations = true;
        }
        private void buttonSub_Click(object sender, EventArgs e)
        {
            number1=float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 2;
            label2.Text=number1.ToString() + "-";   
            operations = true;
        }

        private void buttonMul_Click(object sender, EventArgs e)
        {
            number1=float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 3;
            label2.Text = number1.ToString() + "x";
            operations = true;
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            number1 = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 4;
            label2.Text = number1.ToString() + "/";
            operations = true;
        }

       

        private void buttonDot_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ",";
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            Calculate();
            label2.Text = "";
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label2.Text = "";
        }

        private void buttonSign_Click(object sender, EventArgs e)
        {
            if (operations == true)
            {
                textBox1.Text = "-" + textBox1.Text;
                operations = false;
            }
            else
            {
                textBox1.Text = textBox1.Text.Replace("-", "");
                operations = true;
            }
        }

        private void Calculate()
        {
            switch (count)
            {
            case 1:
                number2=number1+float.Parse(textBox1.Text);
                textBox1.Text=number2.ToString();
                    break;
            case 2:
                    number2=number1-float.Parse(textBox1.Text);
                    textBox1.Text=number2.ToString();
                    break;
            case 3:
                    number2=number1*float.Parse(textBox1.Text);
                    textBox1.Text=number2.ToString();
                    break;
            case 4:
                    number2=number1/float.Parse(textBox1.Text);
                    textBox1.Text=number2.ToString();
                    break;
            }
        }
    }
}
