using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EpicCalculator
{
    public partial class Form1 : Form
    {
       
        string Symbol = "";
        string Math = "";
        string complete = "";
        string sumString = "00";

        public Form1()
        {
            InitializeComponent();
        }

        private void Number_Click(object sender, EventArgs e)
        {
            Button number = sender as Button;

            if (number != null)
            {
                string text = number.Text;
                txtDisplay.Text += text;
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPlus(object sender, EventArgs e)
        {
            
            //symbol = txtDisplay.Text;
            Math = txtDisplay.Text;
            Symbol = "+";
            
            txtDisplay.Text = "";

           
        }

        private void btnMinus(object sender, EventArgs e)
        {
            //symbol = txtDisplay.Text;
            Math = txtDisplay.Text;
            Symbol = "-";

            txtDisplay.Text = "";
        }

        private void btnMultiply(object sender, EventArgs e)
        {
            //symbol = txtDisplay.Text;
            Math = txtDisplay.Text;
            Symbol = "x";

            txtDisplay.Text = "";
        }

        private void btnDivide(object sender, EventArgs e)
        {
            //symbol = txtDisplay.Text;
            Math = txtDisplay.Text;
            Symbol = "%";

            txtDisplay.Text = "";
        }
        private void compute(object sender, EventArgs e)
        {
            if (Symbol == "+")
            {
                
                int numHolder = Int32.Parse(sumString);
                int num1 = Int32.Parse(Math);
                int num2 = Int32.Parse(txtDisplay.Text);

                int sum = num1 + num2;
                sumString = sum.ToString();
                complete = sumString;

            }
          

            else if (Symbol == "-")
            {
                int num1 = Int32.Parse(Math);
                int num2 = Int32.Parse(txtDisplay.Text);

                int sum = num1 - num2;
                string sumString = sum.ToString();
                complete = sumString;
            }

            else if (Symbol == "x")
            {
                int num1 = Int32.Parse(Math);
                int num2 = Int32.Parse(txtDisplay.Text);

                int sum = num1 * num2;
                string sumString = sum.ToString();
                complete = sumString;
            }
            else if (Symbol == "%")
            {
                if (txtDisplay.Text == "0")
                {
                    txtDisplay.Text = "You Done Fucked Up!";
                    complete = txtDisplay.Text;
                }
                else
                {
                    int num1 = Int32.Parse(Math);
                    int num2 = Int32.Parse(txtDisplay.Text);

                    int sum = num1 / num2;
                    string sumString = sum.ToString();
                    complete = sumString;
                }
            }

            txtDisplay.Text = "";
            Symbol = "";
            txtDisplay.Text = complete;
        }

        private void btnClear(object sender, EventArgs e)
        {
            Symbol = "";
            Math = "";
            complete = "";
            txtDisplay.Text = "";
        }

        private void btnRemove(object sender, EventArgs e)
        {

        }

    }
}
