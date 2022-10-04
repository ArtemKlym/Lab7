using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test7
{
    public partial class Form2 : Form
    {
        public string doSomething;
        public string num1;
        public bool num2;
        public Form2()
        {
            num2 = false;
            InitializeComponent();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            if (num2)
            {
                num2 = false;
                textBox1.Text = "0";
            }
            Button number = (Button)sender;
            if (textBox1.Text == "0")
                textBox1.Text = number.Text;
            else
                textBox1.Text = textBox1.Text + number.Text;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            Button number = (Button)sender;
            doSomething = number.Text;
            num1 = textBox1.Text;
            num2 = true;
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            double n1, n2,result=0;
            n1 = double.Parse(num1);
            n2 = double.Parse(textBox1.Text);
            if(doSomething == "+")
            {
                result = n1 + n2;
            }
            if (doSomething == "-")
            {
                result = n1 - n2;
            }
            if (doSomething == "x")
            {
                result = n1 * n2;
            }
            if (doSomething == "/")
            {
                result = n1 / n2;
            }
            doSomething = "=";
            num2 = true;
            textBox1.Text = result.ToString();
            
            
        }

        private void btnSquareRoot_Click(object sender, EventArgs e)
        {
            double dnum, res = 0;
            dnum = Convert.ToDouble(textBox1.Text);
            res = Math.Sqrt(dnum);
            textBox1.Text = res.ToString();
        }

        private void btnPow_Click(object sender, EventArgs e)
        {
            double dnum, res = 0;
            dnum = Convert.ToDouble(textBox1.Text);
            res = Math.Pow(dnum,2);
            textBox1.Text = res.ToString();
        }

        private void btnNegativePlus_Click(object sender, EventArgs e)
        {
            double dnum, res = 0;
            dnum = Convert.ToDouble(textBox1.Text);
            res = -dnum;
            textBox1.Text = res.ToString();
        }

        private void btnComa_Click(object sender, EventArgs e)
        {
            if(!textBox1.Text.Contains(",")) //Contains - Содержать элемент
            textBox1.Text = textBox1.Text + ",";
        }
    }
}
