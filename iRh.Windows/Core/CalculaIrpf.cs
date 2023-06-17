using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iRh.Windows.Core
{
    public static class Irpf
    {
        const double faixaIrpf1 = 1903.98;
        const double faixaIrpf2 = 2826.65;
        const double faixaIrpf3 = 3751.05;
        const double faixaIrpf4 = 4664.68;

        // +++++++ FUNÇÃO, RETORNO, NOME () ++++++ //
        public static double CalculaIrpf(double salario)
        {
            double valorIrpf;

            if (salario <= faixaIrpf1)
            {
                valorIrpf = 0;
            }
            else if (salario <= faixaIrpf2)
            {
                valorIrpf = CalculoFaixaSalario1(salario) ;
            }
            else if (salario <= faixaIrpf3)
            {
                var descontoFaixa3 = CalculaFaixa3(salario);
                valorIrpf = CalculoFaixaSalario2(salario) + descontoFaixa3;
            }
            else if (salario <= faixaIrpf4)
            {
                var descontoFaixa4 = CalculaFaixa3(salario);
                var descontoFaixaFinal = CalculaFaixaFinal(salario) + descontoFaixa4;
                valorIrpf = CalculoFaixaSalario3(salario) + descontoFaixaFinal;
            }
            else
            {
                valorIrpf = CalculaFaixa3(salario);
                valorIrpf = CalculaFaixaFinal(salario) + valorIrpf;
                valorIrpf = CalculoFaixaTotal(salario) + valorIrpf;
                valorIrpf = CalculoFaixaSalario4(salario) + valorIrpf;
            }
            return valorIrpf;
        }
        private static double CalculoFaixaSalario1(double salario)
        {
            return (salario - faixaIrpf1) * 0.075;
        }
        private static double CalculaFaixa3(double salario)
        {
            return (faixaIrpf2 - faixaIrpf1) * 0.075;
        }
        private static double CalculoFaixaSalario2(double salario)
        {
            return ((salario - faixaIrpf2) * 0.15);
        }
        private static double CalculaFaixaFinal(double salario)
        {
            return ((faixaIrpf3 - faixaIrpf2) * 0.15);
        }
        private static double CalculoFaixaSalario3(double salario)
        {
            return ((salario - faixaIrpf3) * 0.225);
        }
        private static double CalculoFaixaTotal(double salario)
        {
            return ((faixaIrpf4 - faixaIrpf3) * 0.225);
        }
        private static double CalculoFaixaSalario4(double salario)
        {
            return ((salario - faixaIrpf4) * 0.275);
        }
    }
}
