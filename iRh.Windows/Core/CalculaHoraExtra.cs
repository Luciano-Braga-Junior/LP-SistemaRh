using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iRh.Windows.Core
{
    public static class HoraExtra
    {
        public static double Calcula(double horaExtra, double horaTrabalhada)
        {
            double valorHoraExtra = 0;

            valorHoraExtra = (horaTrabalhada * horaExtra) * 1.5;
            return valorHoraExtra;
        }
    }
}
