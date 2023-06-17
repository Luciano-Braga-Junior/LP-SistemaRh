﻿using iRh.Windows.Cadastros;
using iRh.Windows.Simuladores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iRh.Windows
{
    public partial class PrincipalMdi : Form
    {
        public PrincipalMdi()
        {
            InitializeComponent();
        }

        private void benefiocioDeSeguroDesempregoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new frmBeneficioSeguroDesemprego();
            form.MdiParent = this;
            form.Show();
        }
        private void menuDescontoInss_Click(object sender, EventArgs e)
        {
            var form = new frmDescontoInss();
            form.MdiParent = this;
            form.Show();
        }

        private void menuDescontoIrpf_Click(object sender, EventArgs e)
        {
            var form = new frmDescontoIrpf();
            form.MdiParent = this;
            form.Show();
        }

        private void menuBeneficioAdicionalNoturno_Click(object sender, EventArgs e)
        {
            var form = new frmBeneficioAdicionalNorturno();
            form.MdiParent = this;
            form.Show();
        }

        private void menuBeneficioFgts_Click(object sender, EventArgs e)
        {
            var form = new frmBeneficioFgts();
            form.MdiParent = this;
            form.Show();
        }

        private void menuBeneficioFerias_Click(object sender, EventArgs e)
        {
            var form = new frmBeneficioFerias();
            form.MdiParent = this;
            form.Show();
        }

        private void menuBeneficioHoraExtra_Click(object sender, EventArgs e)
        {
            var form = new frmBeneficioHoraExtras();
            form.MdiParent = this;
            form.Show();
        }

        private void menuBeneficioPericulosidade_Click(object sender, EventArgs e)
        {
            var form = new frmBeneficioPericulosidade();
            form.MdiParent = this;
            form.Show();
        }

        private void menuBeneficioPis_Click(object sender, EventArgs e)
        {
            var form = new frmBeneficioPis();
            form.MdiParent = this;
            form.Show();
        }

        private void menuBeneficioValeTransporte_Click(object sender, EventArgs e)
        {
            var form = new frmBeneficioValeTransporte();
            form.MdiParent = this;
            form.Show();
        }

        private void menuCadastroFuncionario_Click(object sender, EventArgs e)
        {
            var form = new frmFuncionario();
            form.MdiParent = this;
            form.Show();
        }

        private void contraChequeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new frmContraCheque();
            form.MdiParent = this;
            form.Show();
        }
    }
}
