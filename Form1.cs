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
    public partial class Form1 : Form
    {

        public static Color color = Color.Purple;
        public static Form1 form1 = null;
        public static string button;
        public static bool fill = false;
        public Form1()
        {
            updateEllipse();
            InitializeComponent();
            updateEllipse();
            form1 = this;

        }

        Graphics gfx;

        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
        protected void updateEllipse()
        {
            int x = 50, y = 50, width = 300, height = 200;
            Graphics formGraphics = this.CreateGraphics();
            if (fill == true)
                formGraphics.FillEllipse(new SolidBrush(color), new Rectangle(x, y, width, height));
            else formGraphics.DrawEllipse(new Pen(color), new Rectangle(x, y, width, height));
            formGraphics.Dispose();
        }

        private void colorFillSelectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog(this);
            updateEllipse();
        }


    }
}
