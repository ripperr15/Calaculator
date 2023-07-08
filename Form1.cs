using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator1
{
    public partial class Form1 : Form
    {
        char functon;

        public Form1()
        {
            InitializeComponent();
        }
    

        private void button25_Click(object sender, EventArgs e)
        {
            richTxtBox1.Text += "1";
        }

        private void button24_Click(object sender, EventArgs e)
        {
            richTxtBox1.Text += "2";
        }

        private void button23_Click(object sender, EventArgs e)
        {
            richTxtBox1.Text += "3";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            richTxtBox1.Text += "4";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            richTxtBox1.Text += "5";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            richTxtBox1.Text += "6";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            richTxtBox1.Text += "7";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            richTxtBox1.Text += "8";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            richTxtBox1.Text += "9";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            richTxtBox1.Text += " / ";
            functon = '/';
        }

        private void button17_Click(object sender, EventArgs e)
        {
            richTxtBox1.Text += " * ";
            functon = '*';

        }

        private void button22_Click(object sender, EventArgs e)
        {
            richTxtBox1.Text += " + ";
            functon = '+';
        }

        private void button21_Click(object sender, EventArgs e)
        {

            try
            {
                richTxtBox1.Text += " = ";

                String res = richTxtBox1.Text;
                res = res.Substring(0, res.Length - 2);
                string[] arr;
                arr = res.Split(functon);

                double val1 = Convert.ToDouble(arr[0]);

                double val2 = Convert.ToDouble(arr[1]);

                try
                {
                    switch (functon)
                    {
                        case '+':

                            richTxtBox1.Text += Convert.ToString(val1 + val2);

                            break;

                        case '-':

                            richTxtBox1.Text += Convert.ToString(val1 - val2);

                            break;

                        case '*':

                            richTxtBox1.Text += Convert.ToString(val1 * val2);

                            break;

                        case '/':

                            if (val2 == 0)
                            {
                                throw new Exception("Cannot divisible by zero");
                            }
                            else
                            {
                                richTxtBox1.Text += Convert.ToString(val1 / val2);
                            }

                            break;

                        case '%':

                            richTxtBox1.Text += Convert.ToString(val1 % val2);

                            break;

                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Your inputs are wrong...");
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong try again...");
            }




        }

        private void button11_Click(object sender, EventArgs e)
        {
            richTxtBox1.Text=Convert.ToString(Convert.ToDouble(richTxtBox1.Text)*Convert.ToDouble(richTxtBox1.Text));
        }

        private void button8_Click(object sender, EventArgs e)
        {
            richTxtBox1.Text = richTxtBox1.Text.Substring(0, richTxtBox1.Text.Length - 1);

        }

        private void button9_Click(object sender, EventArgs e)
        {
            richTxtBox1.Text = "";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            richTxtBox1.Text = Convert.ToString(1.0 / Convert.ToDouble(richTxtBox1.Text));
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            try
            {
                richTxtBox1.Text = Convert.ToString(Math.Sqrt(Double.Parse(richTxtBox1.Text)));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Your inputs are wrong...");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Will be developed");
        }

        private void MinusPlusBtn_Click(object sender, EventArgs e)
        {
           
            if (richTxtBox1.Text.Contains("-"))
            {
                richTxtBox1.Text = richTxtBox1.Text.Trim('-');
            }
            else
            {
                richTxtBox1.Text = "-" + richTxtBox1.Text;
            }
        }


        private void button10_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Will be developed");
        }

        private void button27_Click(object sender, EventArgs e)
        {
            richTxtBox1.Text += " . ";
        }

        private void button26_Click(object sender, EventArgs e)
        {
            richTxtBox1.Text += "0";
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
             richTxtBox1.Text += " - ";
             functon = '-';
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is a calcutor where you can substract, multiply and divide. Also you can square root of a number and double it.");
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
          
        }


    }
}
