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
    public partial class frmBeneficioHoraExtras : Form
    {
        public frmBeneficioHoraExtras()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtHorasExtras.Text))
            {
                MessageBox.Show("Informe um valor válido!!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtHorasExtras.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtHoraTrabalhada.Text))
            {
                MessageBox.Show("Informe um valor válido!!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtHoraTrabalhada.Focus();
                return;
            }
            try
            {
                var horaExtra = double.Parse(txtHorasExtras.Text);
                var horaTrabalhada = double.Parse(txtHoraTrabalhada.Text);
                var descontoBeneficioHoraExtra = HoraExtra.Calcula(horaExtra, horaTrabalhada);

                lblResultado.Text = descontoBeneficioHoraExtra.ToString("C");
                MessageBox.Show("O adicional de horas extras que vai ter no seu salario será de --> " + lblResultado.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Informe um valido, ex: 50", "ATENÇÃO",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
