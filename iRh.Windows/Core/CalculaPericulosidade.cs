using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iRh.Windows.Core
{
    public static class AdicionalPericulosidade
    {
        public static double Calcula(double salario)
        {
            double valorPericulosidade = 0;

            valorPericulosidade = (salario * 0.3);
            return valorPericulosidade;
        }
    }
}
