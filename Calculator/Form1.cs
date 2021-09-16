using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdCalcular_Click(object sender, EventArgs e)
        {
            Calculadora calc = new Calculadora(Convert.ToDouble(txtValor1.Text), Convert.ToDouble(txtValor2.Text));

            if (optSoma.Checked == true)
            {
                calc.Soma();
                lblResultado.Text = calc.Resultado().ToString();
            } else if (optSubtrai.Checked == true) {
                calc.Subtracao();
                lblResultado.Text = calc.Resultado().ToString();
            } else if (optMultiplica.Checked == true) {
                calc.Multiplicacao();
                lblResultado.Text = calc.Resultado().ToString();
            } else if (optDivide.Checked == true) {
                calc.Divisao();
                lblResultado.Text = calc.Resultado().ToString();
            } else {
                MessageBox.Show("Você precisa marcar uma caixa.");
            }
        }

        private void cmdSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
