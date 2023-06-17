namespace iRh.Windows.Core
{
    public static class Inss
    {
        const double faixaSalarial1 = 1320.00;
        const double faixaSalarial2 = 2571.29;
        const double faixaSalarial3 = 3856.94;
        const double faixaSalarial4 = 7507.49;

        // ++++++ FUNÇÃO, RETORNO, NOME() ++++++ //
        public static double Calcula(double salario)
        {
            double valorInss = 0;

            if(salario <= faixaSalarial1)
            {
                valorInss = CalculaFaixa1(salario);

            }
            else if(salario <= faixaSalarial2)
            {
                var descontoFaixa1 = CalculaFaixa(salario);
                var descontoFaixa2 = CalculaFaixa2(salario) + descontoFaixa1;
                valorInss = descontoFaixa2;
            }
            else if(salario <= faixaSalarial3)
            {
                var descontoFaixa1 = CalculaFaixa(salario);
                var descontoFaixa2 = 0.09 * (faixaSalarial2 - faixaSalarial1);
                valorInss = 0.12 * (salario - faixaSalarial2) + descontoFaixa1 + descontoFaixa2;
            }
            else if(salario <= faixaSalarial4)
            {
                var descontoFaixa1 = CalculaFaixa(salario);
                var desocntoFaixa2 = CalculaFaixa4(salario);
                var descontoFaixa3 = CalculaFaixa3(salario);
                valorInss = 0.14 * (salario - faixaSalarial3) + descontoFaixa1 + desocntoFaixa2 + descontoFaixa3;
            }
            else
            {
                var descontoFaixa1 = CalculaFaixa(salario);
                var desocntoFaixa2 = CalculaFaixa4(salario);
                var descontoFaixa3 = CalculaFaixa3(salario);
                valorInss = 0.14 * (faixaSalarial4 - faixaSalarial3) + descontoFaixa1 + desocntoFaixa2 + descontoFaixa3;
            }
            return valorInss;
        }
        private static double CalculaFaixa(double salario)
        {
            return (0.075 * faixaSalarial1);
        }
        private static double CalculaFaixa1(double salario)
        {
            return (0.075 * salario);
        }
        private static double CalculaFaixa2(double salario)
        {
            return 0.09 * (salario - faixaSalarial1);
        }
        private static double CalculaFaixa3(double salario)
        {
            return 0.12 * (faixaSalarial3 - faixaSalarial2);
        }
        private static double CalculaFaixa4(double salario)
        {
            return 0.09 * (faixaSalarial2 - faixaSalarial1);
        }
    }
}
