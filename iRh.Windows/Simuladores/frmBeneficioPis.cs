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
    public partial class frmBeneficioPis : Form
    {
        public frmBeneficioPis()
        {
            InitializeComponent();
        }
        private void btnCalcular_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtInscricao.Text))
            {
                MessageBox.Show("Informe um valor válido!! ", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtInscricao.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtMesesTrabalhados.Text))
            {
                MessageBox.Show("Informe um valor válido!! ", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtMesesTrabalhados.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtSalarioBruto.Text))
            {
                MessageBox.Show("Informe um valor válido, Ex: 3500!! ", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtSalarioBruto.Focus();
                return;
            }
            try
            {
                var inscritoOuNao = double.Parse(txtInscricao.Text);
                var mesesTrabalhados = double.Parse(txtMesesTrabalhados.Text);
                var valorSalario = double.Parse(txtSalarioBruto.Text);

                var beneficioPis = Pis.Calcula(inscritoOuNao, mesesTrabalhados, valorSalario);

                lblResultado.Text = beneficioPis.ToString("C");
                MessageBox.Show("O valor que você receberá do PIS será de --> " + lblResultado.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Informe um valido, ex: 50", "ATENÇÃO",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
