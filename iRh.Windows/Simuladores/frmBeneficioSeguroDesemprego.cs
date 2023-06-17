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
    public partial class frmBeneficioSeguroDesemprego : Form
    {
        public frmBeneficioSeguroDesemprego()
        {
            InitializeComponent();
        }

        private void btnTemOuNao_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtMesesTrabalhados.Text))
            {
                MessageBox.Show("Informe um valor válido!!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtMesesTrabalhados.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtMesesTrabalhados.Text))
            {
                MessageBox.Show("Informe um valor válido!!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtMesesTrabalhados.Focus();
                return;
            }
            try
            {
                var mesesTrabalhados = double.Parse(txtMesesTrabalhados.Text);
                var temOuNao = SeguroDesemprego.TemOuNao(mesesTrabalhados);

                lblResultado.Text = temOuNao.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Informe um valido, ex: 50", "ATENÇÃO",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
