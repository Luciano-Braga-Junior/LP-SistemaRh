﻿using iRh.Windows.Core;
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
    public partial class frmBeneficioFgts : Form
    {
        public frmBeneficioFgts()
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
                var descontoFgts = Fgts.CalculaFgts(salario);

                lblResultado.Text = descontoFgts.ToString("C");
                MessageBox.Show("O Desconto de FGTS será de --> " + lblResultado.Text);
                panelResultado.Visible = true;

            }
            catch (Exception)
            {
                MessageBox.Show("Informe um valor de sálario valido, ex: 3500", "ATENÇÃO",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
