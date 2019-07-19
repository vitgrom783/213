using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleQuadEquation
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, c, D=0, x1, x2;

            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox3.Text);
            c = Convert.ToInt32(textBox2.Text);
            D = b*b - (4 * a * c);
         

            if (D == 0)
            {
                label4.Visible = true;
                textBox4.Visible =true;
                label5.Visible = false;
                textBox5.Visible = false;
                double x = (-b / (2 * a));
                textBox4.Text =  x.ToString() ;
            }

            else if (D > 0 )
            {
                label4.Visible = true;
                textBox4.Visible = true;
                label5.Visible = true;
                textBox5.Visible = true;
                x1 = (-b + Math.Sqrt(D)) / (2 * a);
                x2 = (-b - Math.Sqrt(D)) / (2 * a);
                textBox4.Text = x1.ToString();
                textBox5.Text = x2.ToString();
            }


            else if (D < 0)
            {
                label4.Visible = false;
                textBox4.Visible = false;
                label5.Visible = false;
                textBox5.Visible = false;
                MessageBox.Show("Действительных корней нет");
            }
        }

private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label4.Visible = false;
            textBox4.Visible = false;
            label5.Visible = false;
            textBox5.Visible = false;
        }
    }
}
