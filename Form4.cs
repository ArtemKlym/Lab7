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
    public partial class Form4 : Form
    {
        Graphics g;
        public Form4()
        {
            InitializeComponent();
            g.DrawEllipse(Pens.Black, 100, 100, 300, 300);
            g.FillEllipse(Brushes.Black, 100, 100, 300, 300);
        }
    }
}
