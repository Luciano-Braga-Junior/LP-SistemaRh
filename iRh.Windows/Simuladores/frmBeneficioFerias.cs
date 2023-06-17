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
    public partial class frmBeneficioFerias : Form
    {
        public frmBeneficioFerias()
        {
            InitializeComponent();
        }
        private void btnCalcular_Click(object sender, EventArgs e)
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
                var descontoAdicionalFerias = Ferias.CalculaFerias(salario);

                lblResultado.Text = descontoAdicionalFerias.ToString("C");
                MessageBox.Show("Esse vai ser seu salário com o desconto das férias --> " + lblResultado.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Informe um valido, ex: 3500", "ATENÇÃO",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
