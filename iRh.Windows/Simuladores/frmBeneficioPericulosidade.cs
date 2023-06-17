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
    public partial class frmBeneficioPericulosidade : Form
    {
        public frmBeneficioPericulosidade()
        {
            InitializeComponent();
        }
        private void btnCalcular_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSalarioBruto.Text))
            {
                MessageBox.Show("Informe um valor válido!!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtSalarioBruto.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtSalarioBruto.Text))
            {
                MessageBox.Show("Informe um valor válido!!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtSalarioBruto.Focus();
                return;
            }
            try
            {
                var salario = double.Parse(txtSalarioBruto.Text);
                var descontoAdicionalPericulosidade = AdicionalPericulosidade.Calcula(salario);

                lblResultado.Text = descontoAdicionalPericulosidade.ToString("C");
                MessageBox.Show("O Desconto de ADICIONAL DE PERICULOSIDADE será de --> " + lblResultado.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Informe um valido, ex: 3500", "ATENÇÃO",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
