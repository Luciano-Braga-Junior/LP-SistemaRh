﻿namespace iRh.Windows
{
    partial class PrincipalMdi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrincipalMdi));
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.funcionáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadastroFuncionario = new System.Windows.Forms.ToolStripMenuItem();
            this.simuladoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contraChequeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDescontoInss = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDescontoIrpf = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuBeneficioAdicionalNoturno = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBeneficioFgts = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBeneficioFerias = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBeneficioHoraExtra = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBeneficioPericulosidade = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBeneficioPis = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBeneficioSeguroDesemprego = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBeneficioValeTransporte = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.funcionáriosToolStripMenuItem,
            this.simuladoresToolStripMenuItem});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Size = new System.Drawing.Size(786, 24);
            this.menuPrincipal.TabIndex = 0;
            this.menuPrincipal.Text = "menuStrip1";
            // 
            // funcionáriosToolStripMenuItem
            // 
            this.funcionáriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCadastroFuncionario});
            this.funcionáriosToolStripMenuItem.Name = "funcionáriosToolStripMenuItem";
            this.funcionáriosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.funcionáriosToolStripMenuItem.Text = "Cadastros";
            // 
            // menuCadastroFuncionario
            // 
            this.menuCadastroFuncionario.Name = "menuCadastroFuncionario";
            this.menuCadastroFuncionario.Size = new System.Drawing.Size(142, 22);
            this.menuCadastroFuncionario.Text = "Funcionários";
            this.menuCadastroFuncionario.Click += new System.EventHandler(this.menuCadastroFuncionario_Click);
            // 
            // simuladoresToolStripMenuItem
            // 
            this.simuladoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contraChequeToolStripMenuItem,
            this.menuDescontoInss,
            this.menuDescontoIrpf,
            this.toolStripSeparator1,
            this.menuBeneficioAdicionalNoturno,
            this.menuBeneficioFgts,
            this.menuBeneficioFerias,
            this.menuBeneficioHoraExtra,
            this.menuBeneficioPericulosidade,
            this.menuBeneficioPis,
            this.menuBeneficioSeguroDesemprego,
            this.menuBeneficioValeTransporte});
            this.simuladoresToolStripMenuItem.Name = "simuladoresToolStripMenuItem";
            this.simuladoresToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.simuladoresToolStripMenuItem.Text = "Simuladores";
            // 
            // contraChequeToolStripMenuItem
            // 
            this.contraChequeToolStripMenuItem.Name = "contraChequeToolStripMenuItem";
            this.contraChequeToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.contraChequeToolStripMenuItem.Text = "Contra Cheque";
            this.contraChequeToolStripMenuItem.Click += new System.EventHandler(this.contraChequeToolStripMenuItem_Click);
            // 
            // menuDescontoInss
            // 
            this.menuDescontoInss.CheckOnClick = true;
            this.menuDescontoInss.Name = "menuDescontoInss";
            this.menuDescontoInss.Size = new System.Drawing.Size(249, 22);
            this.menuDescontoInss.Text = "Desconto de INSS";
            this.menuDescontoInss.Click += new System.EventHandler(this.menuDescontoInss_Click);
            // 
            // menuDescontoIrpf
            // 
            this.menuDescontoIrpf.Name = "menuDescontoIrpf";
            this.menuDescontoIrpf.Size = new System.Drawing.Size(249, 22);
            this.menuDescontoIrpf.Text = "Desconto de IRPF";
            this.menuDescontoIrpf.Click += new System.EventHandler(this.menuDescontoIrpf_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(246, 6);
            // 
            // menuBeneficioAdicionalNoturno
            // 
            this.menuBeneficioAdicionalNoturno.Name = "menuBeneficioAdicionalNoturno";
            this.menuBeneficioAdicionalNoturno.Size = new System.Drawing.Size(249, 22);
            this.menuBeneficioAdicionalNoturno.Text = "Beneficio de Adicional Noturno";
            this.menuBeneficioAdicionalNoturno.Click += new System.EventHandler(this.menuBeneficioAdicionalNoturno_Click);
            // 
            // menuBeneficioFgts
            // 
            this.menuBeneficioFgts.Name = "menuBeneficioFgts";
            this.menuBeneficioFgts.Size = new System.Drawing.Size(249, 22);
            this.menuBeneficioFgts.Text = "Beneficio de Deposito FGTS";
            this.menuBeneficioFgts.Click += new System.EventHandler(this.menuBeneficioFgts_Click);
            // 
            // menuBeneficioFerias
            // 
            this.menuBeneficioFerias.Name = "menuBeneficioFerias";
            this.menuBeneficioFerias.Size = new System.Drawing.Size(249, 22);
            this.menuBeneficioFerias.Text = "Beneficio de Férias";
            this.menuBeneficioFerias.Click += new System.EventHandler(this.menuBeneficioFerias_Click);
            // 
            // menuBeneficioHoraExtra
            // 
            this.menuBeneficioHoraExtra.Name = "menuBeneficioHoraExtra";
            this.menuBeneficioHoraExtra.Size = new System.Drawing.Size(249, 22);
            this.menuBeneficioHoraExtra.Text = "Beneficio de Hora Extra";
            this.menuBeneficioHoraExtra.Click += new System.EventHandler(this.menuBeneficioHoraExtra_Click);
            // 
            // menuBeneficioPericulosidade
            // 
            this.menuBeneficioPericulosidade.Name = "menuBeneficioPericulosidade";
            this.menuBeneficioPericulosidade.Size = new System.Drawing.Size(249, 22);
            this.menuBeneficioPericulosidade.Text = "Beneficio de Periculosidade";
            this.menuBeneficioPericulosidade.Click += new System.EventHandler(this.menuBeneficioPericulosidade_Click);
            // 
            // menuBeneficioPis
            // 
            this.menuBeneficioPis.Name = "menuBeneficioPis";
            this.menuBeneficioPis.Size = new System.Drawing.Size(249, 22);
            this.menuBeneficioPis.Text = "Beneficio de PIS";
            this.menuBeneficioPis.Click += new System.EventHandler(this.menuBeneficioPis_Click);
            // 
            // menuBeneficioSeguroDesemprego
            // 
            this.menuBeneficioSeguroDesemprego.Name = "menuBeneficioSeguroDesemprego";
            this.menuBeneficioSeguroDesemprego.Size = new System.Drawing.Size(249, 22);
            this.menuBeneficioSeguroDesemprego.Text = "Beneficio de Seguro Desemprego";
            this.menuBeneficioSeguroDesemprego.Click += new System.EventHandler(this.benefiocioDeSeguroDesempregoToolStripMenuItem_Click);
            // 
            // menuBeneficioValeTransporte
            // 
            this.menuBeneficioValeTransporte.Name = "menuBeneficioValeTransporte";
            this.menuBeneficioValeTransporte.Size = new System.Drawing.Size(249, 22);
            this.menuBeneficioValeTransporte.Text = "Beneficio de Vale Transporte";
            this.menuBeneficioValeTransporte.Click += new System.EventHandler(this.menuBeneficioValeTransporte_Click);
            // 
            // PrincipalMdi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(786, 450);
            this.Controls.Add(this.menuPrincipal);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuPrincipal;
            this.Name = "PrincipalMdi";
            this.Text = "PRINCIPAL";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem funcionáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuCadastroFuncionario;
        private System.Windows.Forms.ToolStripMenuItem simuladoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuDescontoInss;
        private System.Windows.Forms.ToolStripMenuItem menuDescontoIrpf;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuBeneficioFgts;
        private System.Windows.Forms.ToolStripMenuItem menuBeneficioFerias;
        private System.Windows.Forms.ToolStripMenuItem menuBeneficioPis;
        private System.Windows.Forms.ToolStripMenuItem menuBeneficioSeguroDesemprego;
        private System.Windows.Forms.ToolStripMenuItem menuBeneficioValeTransporte;
        private System.Windows.Forms.ToolStripMenuItem menuBeneficioAdicionalNoturno;
        private System.Windows.Forms.ToolStripMenuItem menuBeneficioHoraExtra;
        private System.Windows.Forms.ToolStripMenuItem menuBeneficioPericulosidade;
        private System.Windows.Forms.ToolStripMenuItem contraChequeToolStripMenuItem;
    }
}