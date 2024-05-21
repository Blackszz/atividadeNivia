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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void txtResultado_TextChanged(object sender, EventArgs e)
        {
            double idade;
            string sexo;


            
            idade = Convert.ToDouble(txtidade.Text);
            sexo = Convert.ToString(txtSexo.Text);

            if(sexo != "Masculino")
            {

            }
        }

        private void btmVoltar_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form2 Form3 = new Form2();
            Form3.Show();
        }
    }
}
