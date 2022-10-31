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
    public partial class Form3 : Form
    {



        public static Color thiscolor;
        public Form3()
        {
            InitializeComponent();
            checkFill();
            checkColor();
        }
        private void checkFill()
        {
            if (Form1.fill == true)
                checkBox1.Checked = true;
            else checkBox1.Checked = false;
        }
        private void checkColor()
        {
            if (Form1.color == Color.Black)
                radioButton1.Checked = true;
            else if (Form1.color == Color.Green)
                radioButton2.Checked = true;
            else if (Form1.color == Color.Red)
                radioButton2.Checked = true;
            else if (Form1.color == Color.Blue)
                radioButton3.Checked = true;
            else if (Form1.color == Color.Yellow)
                radioButton4.Checked = true;
            else if (Form1.color == Color.White)
                radioButton5.Checked = true;
        }

        Graphics g;
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                thiscolor = Color.Black;
            }
        }

        public void button1_Click(object sender, EventArgs e)
        {
            Form1.color = thiscolor;
            Hide();
        }



        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                thiscolor = Color.Green;
            }
        }

        private void radioButton3_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                thiscolor = Color.Red;
            }
        }

        private void radioButton4_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                thiscolor = Color.Blue;
            }
        }

        private void radioButton5_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton5.Checked == true)
            {
                thiscolor = Color.Yellow;
            }
        }

        private void radioButton6_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton6.Checked == true)
            {
                thiscolor = Color.White;
            }
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
                Form1.fill = true;
            else Form1.fill = false;
        }
    }
}
