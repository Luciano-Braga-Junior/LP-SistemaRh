using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace iRh.Windows.Core
{
    public static class Fgts
    {

        public static double CalculaFgts(double salario)
        {
            double valorFgts;
            const double Porcentagem = 0.08;

            valorFgts = salario * Porcentagem;

            return valorFgts;
        }
    }
}
