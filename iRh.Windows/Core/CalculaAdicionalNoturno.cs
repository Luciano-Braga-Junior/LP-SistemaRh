using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iRh.Windows.Core
{
    public static class AdicionalNoturno
    {
        public static double Calcula(double horaNoturna, double horaTrabalhada)
        {
            double valorNoturno = 0;

            valorNoturno = (horaTrabalhada * horaNoturna) * 0.2;
            return valorNoturno;
        }
    }
}
