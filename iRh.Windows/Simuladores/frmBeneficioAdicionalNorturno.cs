using iRh.Windows.Core;
using System;
using System.Windows.Forms;

namespace iRh.Windows.Simuladores
{
    public partial class frmBeneficioAdicionalNorturno : Form
    {
        public frmBeneficioAdicionalNorturno()
        {
            InitializeComponent();
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtHorasNoturnas.Text))
            {
                MessageBox.Show("Informe um valor válido!!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtHorasNoturnas.Focus();
                return;
            }
            if(string.IsNullOrEmpty(txtHoraTrabalhada.Text))
            {
                MessageBox.Show("Informe um valor válido!!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtHoraTrabalhada.Focus();
                return;
            }
            try
            {
                var horaNoturna = double.Parse(txtHorasNoturnas.Text);
                var horaTrabalhada = double.Parse(txtHoraTrabalhada.Text);
                var descontoAdicionalNoturno = AdicionalNoturno.Calcula(horaNoturna,horaTrabalhada);

                lblResultado.Text = descontoAdicionalNoturno.ToString("C");
                MessageBox.Show("O Desconto de ADICIONAL NOTURNO será de --> " + lblResultado.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Informe um valido, ex: 50", "ATENÇÃO",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
