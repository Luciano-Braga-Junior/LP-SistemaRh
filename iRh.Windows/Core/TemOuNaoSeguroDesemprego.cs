using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iRh.Windows.Core
{
    public static class SeguroDesemprego
    {
        public static bool TemOuNao(double mesesTrabalhados)
        {
            bool temDireito;

            if(mesesTrabalhados >= 12 && mesesTrabalhados <= 18)
            {
                temDireito = true;
            }
            else if (mesesTrabalhados > 18)
            {
                temDireito = true;
            }
            else
            {
                temDireito = false;
            }
            if(temDireito)
            {
                MessageBox.Show("Parabéns, Você tem direito ao Seguro Desemprego !!");
            }
            else
            {
                MessageBox.Show("Infelizmente você não tem direito ao Seguro Desemprego!!");
            }
            return temDireito;
        } 
    }
}
