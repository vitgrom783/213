using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, x, y;
            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox2.Text);
            x = Convert.ToInt32(textBox3.Text);
            y = ((2.4) * Math.Abs((x * x + b) / a) + (a - b) * ((Math.Sin(a - b)) * (Math.Sin(a - b))) + 0.01 * (x - b));
            textBox4.Text = (" Корень равен " + y + ".");
        }
    }
}
