using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Calculadora
    {
        private double valor1;
        private double valor2;

        public double dResultado;

        public Calculadora(double valorForm1, double valorForm2)
        {
            valor1 = valorForm1;
            valor2 = valorForm2;
        }

        public void Soma()
        {
            dResultado = valor1 + valor2;
        }

        public void Subtracao()
        {
            dResultado = valor1 - valor2;
        }

        public void Multiplicacao()
        {
            dResultado = valor1 * valor2;
        }

        public void Divisao()
        {
            dResultado = valor1 / valor2;
        }

        public double Resultado()
        {
            return dResultado;
        }
    }
}
