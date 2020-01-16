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
        public Form1()
        {
            InitializeComponent();
        }
        //Declaring variables globally that will be used later
        float num1, ans;
        int count;
        
        //Specifying all the button actions
        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += 1;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += 2;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += 3;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += 5;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += 6;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += 7;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += 8;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += 9;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += 0;
        }

        private bool Check(string text)
        {
            
            if (textBox1.TextLength == 0)
            { 
                MessageBox.Show("Please enter a value");
                return false;
            }
            else
                return true;
        }
       
 private void button11_Click(object sender, EventArgs e)
        {
            //multiply
            Check(textBox1.Text);
            num1 = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 1;
        }
        private void button12_Click(object sender, EventArgs e)
        {
            //divide
            if (Check(textBox1.Text))
            {
                num1 = float.Parse(textBox1.Text);
                textBox1.Clear();
                textBox1.Focus();
                count = 2;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //plus
            if (Check(textBox1.Text))
            {
                num1 = float.Parse(textBox1.Text);
                textBox1.Clear();
                textBox1.Focus();
                count = 3;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //Subtract
            if (Check(textBox1.Text))
            {
                num1 = float.Parse(textBox1.Text);
                textBox1.Clear();
                textBox1.Focus();
                count = 4;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            //Clear
            if (Check(textBox1.Text))
            {
                num1 = float.Parse(textBox1.Text);
                textBox1.Clear();
                textBox1.Focus();
                count = 5;
            }
        }
        private void button19_Click(object sender, EventArgs e)
        {
            //Remainder
            if (Check(textBox1.Text))
            {
                num1 = float.Parse(textBox1.Text);
                textBox1.Clear();
                textBox1.Focus();
                count = 6;
            }
        }
        private void button16_Click(object sender, EventArgs e)
        {
            //Power
            if (Check(textBox1.Text))
            {
                num1 = float.Parse(textBox1.Text);
                textBox1.Clear();
                textBox1.Focus();
                count = 7;
            }
        }
        private void button18_Click(object sender, EventArgs e)
        {
            //Equals button
            compute(count);
        }
        public void compute(int count)
        {
            //Using switch to calculate the value of the answer

            switch (count)
            {
                case 1:
                    ans = num1 * float.Parse(textBox1.Text);
                    textBox1.Text = ans.ToString();
                    break;
                case 2:
                    ans = num1 / float.Parse(textBox1.Text);
                    textBox1.Text = ans.ToString();
                    break;
                case 3:
                    ans = num1 + float.Parse(textBox1.Text);
                    textBox1.Text = ans.ToString();
                    break;
                case 4:
                    ans = num1 - float.Parse(textBox1.Text);
                    textBox1.Text = ans.ToString();
                    break;
                case 5:
                    textBox1.Clear();
                    break;
                case 6:
                    ans = num1 % float.Parse(textBox1.Text);
                    textBox1.Text = ans.ToString();
                    break;
                case 7:
                    ans = (float)Math.Pow(num1, float.Parse(textBox1.Text));
                    textBox1.Text = ans.ToString();
                    break;
                
            }
        }
      

        private void button15_Click(object sender, EventArgs e)
        {
            //Decimal
            Check(textBox1.Text);
            int c = textBox1.TextLength;
            int flag = 0;
            string text = textBox1.Text;
            for (int i = 0; i < c; i++)
            {
                //textBox1.Text += text[i];
                if (text[i].ToString() == ".")
                {
                    flag = 1; break;
                }
                else
                {
                    flag = 0;
                }
            }
            if (flag == 0)
            {
                textBox1.Text = textBox1.Text + ".";
            }
            }

        

        private void button20_Click(object sender, EventArgs e)
        {
            //Backspace
            int c = textBox1.TextLength;
            String text = textBox1.Text;
            
            //string text = textBox1.Text;
            textBox1.Clear();
            if (c >= 1)
            {
                for (int i = 0; i < c-1; i++)
                {
                    textBox1.Text += text[i];
                   
                }
            }
            else
                textBox1.Clear();
        }
    }
}
