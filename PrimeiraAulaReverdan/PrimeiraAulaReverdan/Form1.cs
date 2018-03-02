using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeiraAulaReverdan
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }
        void Calcular(string OP)
        {
            Double n1 = 0.0, n2 = 0.0, resultado = 0.0;
            try
            {
                n1 = Convert.ToDouble(texPrimeiroNumero.Text);
                n2 = Convert.ToDouble(texSegundoNumero.Text);

                if (OP.Equals("+"))
                    resultado = n1 + n2;

                if (OP.Equals("-"))
                    resultado = n1 - n2;

                if (OP.Equals("*"))
                    resultado = n1 * n2;

                if (OP.Equals("/"))
                    resultado = n1 / n2;
                lblResultado.Text = resultado.ToString();
            }

            catch (FormatException e)
            {
                MessageBox.Show(" Escreva um número correto");
            }

        }
            
        private void btnSomar_Click(object sender, EventArgs e)
        {
            Calcular("+");
       
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            Calcular("-");
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            Calcular("*");
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            Calcular("/");
        }
    }
}
