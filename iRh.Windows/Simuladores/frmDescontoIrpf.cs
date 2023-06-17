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
    public partial class frmDescontoIrpf : Form
    {
        public frmDescontoIrpf()
        {
            InitializeComponent();
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSalario.Text))
            {
                MessageBox.Show("Informe seu salário base", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtSalario.Focus();
                return;
            }
            try
            {

                var salario = double.Parse(txtSalario.Text);
                var descontoInss = Inss.Calcula(salario);

                var salarioDesconto = salario - descontoInss;

                var descontoIrpf = Irpf.CalculaIrpf(salarioDesconto);

                lblResultado.Text = descontoIrpf.ToString("C");
                MessageBox.Show("O Desconto de IRPF será de --> " + lblResultado.Text);

            }
            catch (Exception)
            {
                MessageBox.Show("Informe um valor de sálario valido, ex: 3500", "ATENÇÃO",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
