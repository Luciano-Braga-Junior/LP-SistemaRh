using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iRh.Windows.Core
{
    public static class Pis
    {
        const double salarioMinimo = 1320.00;
        public static double Calcula(double inscritoOuNao, double mesesTrabalhados, double valorSalario)
        {
            bool iraReceberPis;
            double valorPis = 0;

            if (inscritoOuNao < 5)
            {
                iraReceberPis = false;
                MessageBox.Show("Você não tem direito ao PIS!!");
            }
            while(mesesTrabalhados < 0 && mesesTrabalhados > 12)
            {
                MessageBox.Show("Digite um valor válido!!, Entre : 1 e 12");
            }
            if(mesesTrabalhados < 1)
            {
                iraReceberPis = false;
                MessageBox.Show("Você não tem direito ao PIS!!");
            }
            if(valorSalario < (salarioMinimo * 2))
            {
                valorPis = (salarioMinimo / 12) * mesesTrabalhados;
            }
            else
            {
                iraReceberPis = false;
                MessageBox.Show("Você não tem direito ao PIS!!");
            }
            return valorPis;
        }
    }
}
