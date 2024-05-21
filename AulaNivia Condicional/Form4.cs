using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AulaNivia_Condicional
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtb1.Clear();
            txtb2.Clear();
            txtb1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double i, b1,b2;
            

            b1 = Convert.ToDouble(txtb1.Text);
            i = b1 - 1;
            b2 = b1 * i;
            txtb2.Text = string.Concat(txtb2.Text, "\r\n", b1, "x", i, "=", b2.ToString());
            i--;

            while (i > 0)
            {

               
                b1 = b2;
                b2 = b2 * i;
                txtb2.Text = string.Concat(txtb2.Text, "\r\n", b1, "x", i, "=", b2.ToString());
                i--;



            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            double i, b1, b2;


            b1 = Convert.ToDouble(txtb1.Text);
            i = b1 - 1;
            b2 = b1 * i;
            txtb2.Text = string.Concat(txtb2.Text, "\r\n", b1, "x", i, "=", b2.ToString());
            i--;

            do
            {
                b1 = b2;
                b2 = b2 * i;
                txtb2.Text = string.Concat(txtb2.Text, "\r\n", b1, "x", i, "=", b2.ToString());
                i--;
            } while (i > 0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double i, b1, b2;


            b1 = Convert.ToDouble(txtb1.Text);
            i = b1 - 1;
            b2 = b1 * i;
            txtb2.Text = string.Concat(txtb2.Text, "\r\n", b1, "x", i, "=", b2.ToString());

            for (i = b1-2; i > 0; i--){
                b1 = b2;
                b2 = b2 * i;
                txtb2.Text = string.Concat(txtb2.Text, "\r\n", b1, "x", i, "=", b2.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form2 Form4 = new Form2();
            Form4.Show();
        }
    }
}
