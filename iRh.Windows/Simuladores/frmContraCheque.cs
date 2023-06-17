using iRh.Windows.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iRh.Windows.Simuladores
{
    public partial class frmContraCheque : Form
    {
        public frmContraCheque()
        {
            InitializeComponent();
        }
        private void btnGerarContraCheque_Click(object sender, EventArgs e)
        {
            var horasTrabalhadas = double.Parse(txtHorasTrabalhadas.Text);
            var valorDaHora = double.Parse(txtValorDaHora.Text);
            var horasExtras = double.Parse(txtHorasExtras.Text);
            var horasNoturnas = double.Parse(txtHorasNoturnas.Text);


            var salarioBruto = ContraCheque.CalculaSalarioBruto(horasTrabalhadas, valorDaHora);
            var descontoFgts = Fgts.CalculaFgts(salarioBruto);
            var descontoInss = Inss.Calcula(salarioBruto);
            var descontoIrpf = Irpf.CalculaIrpf(salarioBruto);
            var adicionalHoraExtra = HoraExtra.Calcula(valorDaHora,horasExtras);
            var adicionalNoturno = AdicionalNoturno.Calcula(valorDaHora,horasNoturnas);
            var adicionalPericulosidade = AdicionalPericulosidade.Calcula(salarioBruto);
            
            if (cmbSimPericulosidade.Checked)
            {
                panelResultado.Visible = true;
                lblResultadoPericulosidade.Text = adicionalPericulosidade.ToString("C");
            }
            else
            {
                panelResultado.Visible = true;
                var semAdicional = 0;
                lblResultadoPericulosidade.Text = semAdicional.ToString("C");
            }

            var descontoValeTransporte = ValeTransporte.CalculaValeTransporte(salarioBruto);

            if (cmbSimValeTransporte.Checked)
            {
                panelResultado.Visible = true;
                lblResultadoValeTransporte.Text = descontoValeTransporte.ToString("C");
            }
            else
            {
                panelResultado.Visible = true;
                var semValeTransporte = 0;
                lblResultadoValeTransporte.Text = semValeTransporte.ToString("C");
            }

            var totalAdicional = adicionalHoraExtra + adicionalPericulosidade + adicionalNoturno;
            var totalDescontos = descontoValeTransporte + descontoInss + descontoIrpf;
            var salarioLiquido = salarioBruto + totalAdicional - totalDescontos;

            panelResultado.Visible = true;

            lblResultadoSalarioLiquido.Text = salarioLiquido.ToString("C");
            lblResultadoTotalDescontos.Text = totalDescontos.ToString("C");
            lblResultadoTotalAdicional.Text = totalAdicional.ToString("C");
            lblResultadoFgts.Text = descontoFgts.ToString("C");
            lblResultadoIrpf.Text = descontoIrpf.ToString("C");
            lblResultadoInss.Text = descontoInss.ToString("C");
            lblResultadoNoturno.Text = adicionalNoturno.ToString("C");
            lblResultadoHorasExtras.Text = adicionalHoraExtra.ToString("C");
            lblResultadoSalarioBruto.Text = salarioBruto.ToString("C");
        }
    }
}
