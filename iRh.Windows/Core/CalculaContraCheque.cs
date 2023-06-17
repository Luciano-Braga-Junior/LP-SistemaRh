using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iRh.Windows.Core
{
    public class ContraCheque
    {
        public static double CalculaSalarioBruto(double horasTrabalhadas,double valorDaHora)
        {
            double valorTotal;

            valorTotal = (horasTrabalhadas * valorDaHora);

            return valorTotal;
        }
    }
}
