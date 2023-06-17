using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iRh.Windows.Core
{
    public static class Ferias
    {
        public static double CalculaFerias(double salario)
        {
            double valorTotal;
            double valorFerias;
            double valorSalario;

            valorFerias = (salario / 3);
            valorSalario = salario + valorFerias;
            var descontoInss = CalculaInss(valorSalario);
            var descontoIrpf1 =  CalculaIrpf(valorSalario);
            var descontoIrpf2 = descontoInss - descontoIrpf1;

            valorTotal = valorSalario - (descontoInss + descontoIrpf2);

            return valorTotal;
        }
        private static double CalculaInss(double valorSalario)
        {
            return Inss.Calcula(valorSalario);
        }
        private static double CalculaIrpf(double valorSalario)
        {
           return Irpf.CalculaIrpf(valorSalario);
        }
    }
}
