﻿using System;
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
        


        public Form3()
        {
            InitializeComponent();          
        }
       
        

        Graphics g;
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
           
           
        }

       public void button1_Click(object sender, EventArgs e)
        {
            g = CreateGraphics();
            if (checkBox1.Checked)
            {
                g.DrawEllipse(Pens.Black, 100, 100, 300, 300);
                g.FillEllipse(Brushes.Yellow, 100, 100, 300, 300);
            }
        }
    }
}