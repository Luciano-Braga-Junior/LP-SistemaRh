using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iRh.Windows.Core
{
    public class ValeTransporte
    {
        public static double CalculaValeTransporte(double salario)
        {
            double valorValeTransporte;
            const double Porcentagem = 0.06;

            valorValeTransporte = salario * Porcentagem;

            return valorValeTransporte;
        }
    }
}
