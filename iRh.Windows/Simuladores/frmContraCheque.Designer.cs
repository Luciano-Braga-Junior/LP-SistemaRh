namespace iRh.Windows.Simuladores
{
    partial class frmContraCheque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmContraCheque));
            this.lblContraCheque = new System.Windows.Forms.Label();
            this.btnGerarContraCheque = new System.Windows.Forms.Button();
            this.lblHorasTrabalhadas = new System.Windows.Forms.Label();
            this.txtHorasTrabalhadas = new System.Windows.Forms.TextBox();
            this.lblValorDaHora = new System.Windows.Forms.Label();
            this.txtValorDaHora = new System.Windows.Forms.TextBox();
            this.lblHorasExtras = new System.Windows.Forms.Label();
            this.txtHorasExtras = new System.Windows.Forms.TextBox();
            this.lblHorasNoturnas = new System.Windows.Forms.Label();
            this.txtHorasNoturnas = new System.Windows.Forms.TextBox();
            this.panelResultado = new System.Windows.Forms.Panel();
            this.lblResultadoIrpf = new System.Windows.Forms.Label();
            this.lblIrpf = new System.Windows.Forms.Label();
            this.lblResultadoInss = new System.Windows.Forms.Label();
            this.lblInss = new System.Windows.Forms.Label();
            this.lblResultadoValeTransporte = new System.Windows.Forms.Label();
            this.lblValeTransporte = new System.Windows.Forms.Label();
            this.lblResultadoFgts = new System.Windows.Forms.Label();
            this.lblFgts = new System.Windows.Forms.Label();
            this.lblResultadoPericulosidade = new System.Windows.Forms.Label();
            this.lblPericulosidade = new System.Windows.Forms.Label();
            this.lblResultadoNoturno = new System.Windows.Forms.Label();
            this.lblNoturno = new System.Windows.Forms.Label();
            this.lblResultadoHorasExtras = new System.Windows.Forms.Label();
            this.lblHorasExtra = new System.Windows.Forms.Label();
            this.lblResultadoSalarioBruto = new System.Windows.Forms.Label();
            this.lblSalarioBruto = new System.Windows.Forms.Label();
            this.cmbSimPericulosidade = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbPericulosidadeNao = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbSimValeTransporte = new System.Windows.Forms.CheckBox();
            this.cmbNaoValeTransporte = new System.Windows.Forms.CheckBox();
            this.lblSalarioLiquido = new System.Windows.Forms.Label();
            this.lblResultadoSalarioLiquido = new System.Windows.Forms.Label();
            this.lblTotalAdicional = new System.Windows.Forms.Label();
            this.lblTotalDescontos = new System.Windows.Forms.Label();
            this.lblResultadoTotalAdicional = new System.Windows.Forms.Label();
            this.lblResultadoTotalDescontos = new System.Windows.Forms.Label();
            this.panelResultado.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblContraCheque
            // 
            this.lblContraCheque.AutoSize = true;
            this.lblContraCheque.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraCheque.ForeColor = System.Drawing.Color.Black;
            this.lblContraCheque.Location = new System.Drawing.Point(165, 9);
            this.lblContraCheque.Name = "lblContraCheque";
            this.lblContraCheque.Size = new System.Drawing.Size(275, 25);
            this.lblContraCheque.TabIndex = 0;
            this.lblContraCheque.Text = "GERAR CONTRA CHEQUE";
            // 
            // btnGerarContraCheque
            // 
            this.btnGerarContraCheque.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnGerarContraCheque.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerarContraCheque.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGerarContraCheque.Location = new System.Drawing.Point(240, 408);
            this.btnGerarContraCheque.Name = "btnGerarContraCheque";
            this.btnGerarContraCheque.Size = new System.Drawing.Size(159, 45);
            this.btnGerarContraCheque.TabIndex = 1;
            this.btnGerarContraCheque.Text = "GERAR";
            this.btnGerarContraCheque.UseVisualStyleBackColor = false;
            this.btnGerarContraCheque.Click += new System.EventHandler(this.btnGerarContraCheque_Click);
            // 
            // lblHorasTrabalhadas
            // 
            this.lblHorasTrabalhadas.AutoSize = true;
            this.lblHorasTrabalhadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorasTrabalhadas.ForeColor = System.Drawing.Color.Black;
            this.lblHorasTrabalhadas.Location = new System.Drawing.Point(12, 51);
            this.lblHorasTrabalhadas.Name = "lblHorasTrabalhadas";
            this.lblHorasTrabalhadas.Size = new System.Drawing.Size(206, 15);
            this.lblHorasTrabalhadas.TabIndex = 2;
            this.lblHorasTrabalhadas.Text = "QUANTAS HORAS TRABALHADAS ?";
            // 
            // txtHorasTrabalhadas
            // 
            this.txtHorasTrabalhadas.Location = new System.Drawing.Point(15, 68);
            this.txtHorasTrabalhadas.Name = "txtHorasTrabalhadas";
            this.txtHorasTrabalhadas.Size = new System.Drawing.Size(229, 20);
            this.txtHorasTrabalhadas.TabIndex = 3;
            // 
            // lblValorDaHora
            // 
            this.lblValorDaHora.AutoSize = true;
            this.lblValorDaHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorDaHora.ForeColor = System.Drawing.Color.Black;
            this.lblValorDaHora.Location = new System.Drawing.Point(12, 102);
            this.lblValorDaHora.Name = "lblValorDaHora";
            this.lblValorDaHora.Size = new System.Drawing.Size(227, 15);
            this.lblValorDaHora.TabIndex = 4;
            this.lblValorDaHora.Text = "QUAL VALOR DA HORA TRABALHADA ?";
            // 
            // txtValorDaHora
            // 
            this.txtValorDaHora.Location = new System.Drawing.Point(12, 119);
            this.txtValorDaHora.Name = "txtValorDaHora";
            this.txtValorDaHora.Size = new System.Drawing.Size(260, 20);
            this.txtValorDaHora.TabIndex = 5;
            // 
            // lblHorasExtras
            // 
            this.lblHorasExtras.AutoSize = true;
            this.lblHorasExtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorasExtras.ForeColor = System.Drawing.Color.Black;
            this.lblHorasExtras.Location = new System.Drawing.Point(12, 153);
            this.lblHorasExtras.Name = "lblHorasExtras";
            this.lblHorasExtras.Size = new System.Drawing.Size(168, 15);
            this.lblHorasExtras.TabIndex = 6;
            this.lblHorasExtras.Text = "QUANTAS HORAS EXTRAS ?";
            // 
            // txtHorasExtras
            // 
            this.txtHorasExtras.Location = new System.Drawing.Point(15, 170);
            this.txtHorasExtras.Name = "txtHorasExtras";
            this.txtHorasExtras.Size = new System.Drawing.Size(175, 20);
            this.txtHorasExtras.TabIndex = 7;
            // 
            // lblHorasNoturnas
            // 
            this.lblHorasNoturnas.AutoSize = true;
            this.lblHorasNoturnas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorasNoturnas.ForeColor = System.Drawing.Color.Black;
            this.lblHorasNoturnas.Location = new System.Drawing.Point(12, 203);
            this.lblHorasNoturnas.Name = "lblHorasNoturnas";
            this.lblHorasNoturnas.Size = new System.Drawing.Size(188, 15);
            this.lblHorasNoturnas.TabIndex = 8;
            this.lblHorasNoturnas.Text = "QUANTAS HORAS NOTURNAS ?";
            // 
            // txtHorasNoturnas
            // 
            this.txtHorasNoturnas.Location = new System.Drawing.Point(15, 220);
            this.txtHorasNoturnas.Name = "txtHorasNoturnas";
            this.txtHorasNoturnas.Size = new System.Drawing.Size(201, 20);
            this.txtHorasNoturnas.TabIndex = 9;
            // 
            // panelResultado
            // 
            this.panelResultado.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelResultado.Controls.Add(this.lblResultadoTotalDescontos);
            this.panelResultado.Controls.Add(this.lblResultadoTotalAdicional);
            this.panelResultado.Controls.Add(this.lblTotalDescontos);
            this.panelResultado.Controls.Add(this.lblTotalAdicional);
            this.panelResultado.Controls.Add(this.lblResultadoSalarioLiquido);
            this.panelResultado.Controls.Add(this.lblSalarioLiquido);
            this.panelResultado.Controls.Add(this.lblResultadoIrpf);
            this.panelResultado.Controls.Add(this.lblIrpf);
            this.panelResultado.Controls.Add(this.lblResultadoInss);
            this.panelResultado.Controls.Add(this.lblInss);
            this.panelResultado.Controls.Add(this.lblResultadoValeTransporte);
            this.panelResultado.Controls.Add(this.lblValeTransporte);
            this.panelResultado.Controls.Add(this.lblResultadoFgts);
            this.panelResultado.Controls.Add(this.lblFgts);
            this.panelResultado.Controls.Add(this.lblResultadoPericulosidade);
            this.panelResultado.Controls.Add(this.lblPericulosidade);
            this.panelResultado.Controls.Add(this.lblResultadoNoturno);
            this.panelResultado.Controls.Add(this.lblNoturno);
            this.panelResultado.Controls.Add(this.lblResultadoHorasExtras);
            this.panelResultado.Controls.Add(this.lblHorasExtra);
            this.panelResultado.Controls.Add(this.lblResultadoSalarioBruto);
            this.panelResultado.Controls.Add(this.lblSalarioBruto);
            this.panelResultado.ForeColor = System.Drawing.Color.Black;
            this.panelResultado.Location = new System.Drawing.Point(358, 51);
            this.panelResultado.Name = "panelResultado";
            this.panelResultado.Size = new System.Drawing.Size(232, 330);
            this.panelResultado.TabIndex = 10;
            this.panelResultado.Visible = false;
            // 
            // lblResultadoIrpf
            // 
            this.lblResultadoIrpf.AutoSize = true;
            this.lblResultadoIrpf.ForeColor = System.Drawing.Color.Black;
            this.lblResultadoIrpf.Location = new System.Drawing.Point(48, 195);
            this.lblResultadoIrpf.Name = "lblResultadoIrpf";
            this.lblResultadoIrpf.Size = new System.Drawing.Size(73, 13);
            this.lblResultadoIrpf.TabIndex = 26;
            this.lblResultadoIrpf.Text = "RESULTADO";
            // 
            // lblIrpf
            // 
            this.lblIrpf.AutoSize = true;
            this.lblIrpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIrpf.ForeColor = System.Drawing.Color.Black;
            this.lblIrpf.Location = new System.Drawing.Point(3, 193);
            this.lblIrpf.Name = "lblIrpf";
            this.lblIrpf.Size = new System.Drawing.Size(40, 15);
            this.lblIrpf.TabIndex = 25;
            this.lblIrpf.Text = "IRPF :";
            // 
            // lblResultadoInss
            // 
            this.lblResultadoInss.AutoSize = true;
            this.lblResultadoInss.ForeColor = System.Drawing.Color.Black;
            this.lblResultadoInss.Location = new System.Drawing.Point(51, 169);
            this.lblResultadoInss.Name = "lblResultadoInss";
            this.lblResultadoInss.Size = new System.Drawing.Size(73, 13);
            this.lblResultadoInss.TabIndex = 24;
            this.lblResultadoInss.Text = "RESULTADO";
            // 
            // lblInss
            // 
            this.lblInss.AutoSize = true;
            this.lblInss.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInss.ForeColor = System.Drawing.Color.Black;
            this.lblInss.Location = new System.Drawing.Point(3, 169);
            this.lblInss.Name = "lblInss";
            this.lblInss.Size = new System.Drawing.Size(41, 15);
            this.lblInss.TabIndex = 23;
            this.lblInss.Text = "INSS :";
            // 
            // lblResultadoValeTransporte
            // 
            this.lblResultadoValeTransporte.AutoSize = true;
            this.lblResultadoValeTransporte.ForeColor = System.Drawing.Color.Black;
            this.lblResultadoValeTransporte.Location = new System.Drawing.Point(149, 143);
            this.lblResultadoValeTransporte.Name = "lblResultadoValeTransporte";
            this.lblResultadoValeTransporte.Size = new System.Drawing.Size(73, 13);
            this.lblResultadoValeTransporte.TabIndex = 22;
            this.lblResultadoValeTransporte.Text = "RESULTADO";
            // 
            // lblValeTransporte
            // 
            this.lblValeTransporte.AutoSize = true;
            this.lblValeTransporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValeTransporte.ForeColor = System.Drawing.Color.Black;
            this.lblValeTransporte.Location = new System.Drawing.Point(3, 142);
            this.lblValeTransporte.Name = "lblValeTransporte";
            this.lblValeTransporte.Size = new System.Drawing.Size(126, 15);
            this.lblValeTransporte.TabIndex = 21;
            this.lblValeTransporte.Text = "VALE TRANSPORTE :";
            // 
            // lblResultadoFgts
            // 
            this.lblResultadoFgts.AutoSize = true;
            this.lblResultadoFgts.ForeColor = System.Drawing.Color.Black;
            this.lblResultadoFgts.Location = new System.Drawing.Point(57, 120);
            this.lblResultadoFgts.Name = "lblResultadoFgts";
            this.lblResultadoFgts.Size = new System.Drawing.Size(73, 13);
            this.lblResultadoFgts.TabIndex = 20;
            this.lblResultadoFgts.Text = "RESULTADO";
            // 
            // lblFgts
            // 
            this.lblFgts.AutoSize = true;
            this.lblFgts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFgts.ForeColor = System.Drawing.Color.Black;
            this.lblFgts.Location = new System.Drawing.Point(3, 119);
            this.lblFgts.Name = "lblFgts";
            this.lblFgts.Size = new System.Drawing.Size(44, 15);
            this.lblFgts.TabIndex = 19;
            this.lblFgts.Text = "FGTS :";
            // 
            // lblResultadoPericulosidade
            // 
            this.lblResultadoPericulosidade.AutoSize = true;
            this.lblResultadoPericulosidade.ForeColor = System.Drawing.Color.Black;
            this.lblResultadoPericulosidade.Location = new System.Drawing.Point(140, 92);
            this.lblResultadoPericulosidade.Name = "lblResultadoPericulosidade";
            this.lblResultadoPericulosidade.Size = new System.Drawing.Size(73, 13);
            this.lblResultadoPericulosidade.TabIndex = 18;
            this.lblResultadoPericulosidade.Text = "RESULTADO";
            // 
            // lblPericulosidade
            // 
            this.lblPericulosidade.AutoSize = true;
            this.lblPericulosidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPericulosidade.ForeColor = System.Drawing.Color.Black;
            this.lblPericulosidade.Location = new System.Drawing.Point(3, 91);
            this.lblPericulosidade.Name = "lblPericulosidade";
            this.lblPericulosidade.Size = new System.Drawing.Size(118, 15);
            this.lblPericulosidade.TabIndex = 17;
            this.lblPericulosidade.Text = "PERICULOSIDADE :";
            // 
            // lblResultadoNoturno
            // 
            this.lblResultadoNoturno.AutoSize = true;
            this.lblResultadoNoturno.ForeColor = System.Drawing.Color.Black;
            this.lblResultadoNoturno.Location = new System.Drawing.Point(83, 68);
            this.lblResultadoNoturno.Name = "lblResultadoNoturno";
            this.lblResultadoNoturno.Size = new System.Drawing.Size(73, 13);
            this.lblResultadoNoturno.TabIndex = 16;
            this.lblResultadoNoturno.Text = "RESULTADO";
            // 
            // lblNoturno
            // 
            this.lblNoturno.AutoSize = true;
            this.lblNoturno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoturno.ForeColor = System.Drawing.Color.Black;
            this.lblNoturno.Location = new System.Drawing.Point(3, 68);
            this.lblNoturno.Name = "lblNoturno";
            this.lblNoturno.Size = new System.Drawing.Size(74, 15);
            this.lblNoturno.TabIndex = 15;
            this.lblNoturno.Text = "NOTURNO :";
            // 
            // lblResultadoHorasExtras
            // 
            this.lblResultadoHorasExtras.AutoSize = true;
            this.lblResultadoHorasExtras.ForeColor = System.Drawing.Color.Black;
            this.lblResultadoHorasExtras.Location = new System.Drawing.Point(130, 42);
            this.lblResultadoHorasExtras.Name = "lblResultadoHorasExtras";
            this.lblResultadoHorasExtras.Size = new System.Drawing.Size(73, 13);
            this.lblResultadoHorasExtras.TabIndex = 14;
            this.lblResultadoHorasExtras.Text = "RESULTADO";
            // 
            // lblHorasExtra
            // 
            this.lblHorasExtra.AutoSize = true;
            this.lblHorasExtra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorasExtra.ForeColor = System.Drawing.Color.Black;
            this.lblHorasExtra.Location = new System.Drawing.Point(3, 41);
            this.lblHorasExtra.Name = "lblHorasExtra";
            this.lblHorasExtra.Size = new System.Drawing.Size(105, 15);
            this.lblHorasExtra.TabIndex = 13;
            this.lblHorasExtra.Text = "HORAS EXTRAS :";
            // 
            // lblResultadoSalarioBruto
            // 
            this.lblResultadoSalarioBruto.AutoSize = true;
            this.lblResultadoSalarioBruto.ForeColor = System.Drawing.Color.Black;
            this.lblResultadoSalarioBruto.Location = new System.Drawing.Point(130, 17);
            this.lblResultadoSalarioBruto.Name = "lblResultadoSalarioBruto";
            this.lblResultadoSalarioBruto.Size = new System.Drawing.Size(73, 13);
            this.lblResultadoSalarioBruto.TabIndex = 12;
            this.lblResultadoSalarioBruto.Text = "RESULTADO";
            // 
            // lblSalarioBruto
            // 
            this.lblSalarioBruto.AutoSize = true;
            this.lblSalarioBruto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalarioBruto.ForeColor = System.Drawing.Color.Black;
            this.lblSalarioBruto.Location = new System.Drawing.Point(3, 17);
            this.lblSalarioBruto.Name = "lblSalarioBruto";
            this.lblSalarioBruto.Size = new System.Drawing.Size(108, 15);
            this.lblSalarioBruto.TabIndex = 11;
            this.lblSalarioBruto.Text = "SALÁRIO BRUTO :";
            // 
            // cmbSimPericulosidade
            // 
            this.cmbSimPericulosidade.AutoSize = true;
            this.cmbSimPericulosidade.ForeColor = System.Drawing.Color.Black;
            this.cmbSimPericulosidade.Location = new System.Drawing.Point(15, 275);
            this.cmbSimPericulosidade.Name = "cmbSimPericulosidade";
            this.cmbSimPericulosidade.Size = new System.Drawing.Size(43, 17);
            this.cmbSimPericulosidade.TabIndex = 12;
            this.cmbSimPericulosidade.Text = "Sim";
            this.cmbSimPericulosidade.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "RECEBE ADICIONAL DE PERICULOSIDADE ?";
            // 
            // cmbPericulosidadeNao
            // 
            this.cmbPericulosidadeNao.AutoSize = true;
            this.cmbPericulosidadeNao.ForeColor = System.Drawing.Color.Black;
            this.cmbPericulosidadeNao.Location = new System.Drawing.Point(64, 275);
            this.cmbPericulosidadeNao.Name = "cmbPericulosidadeNao";
            this.cmbPericulosidadeNao.Size = new System.Drawing.Size(46, 17);
            this.cmbPericulosidadeNao.TabIndex = 13;
            this.cmbPericulosidadeNao.Text = "Não";
            this.cmbPericulosidadeNao.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 309);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "RECEBE VALE TRANSPORTE ?";
            // 
            // cmbSimValeTransporte
            // 
            this.cmbSimValeTransporte.AutoSize = true;
            this.cmbSimValeTransporte.ForeColor = System.Drawing.Color.Black;
            this.cmbSimValeTransporte.Location = new System.Drawing.Point(15, 326);
            this.cmbSimValeTransporte.Name = "cmbSimValeTransporte";
            this.cmbSimValeTransporte.Size = new System.Drawing.Size(43, 17);
            this.cmbSimValeTransporte.TabIndex = 15;
            this.cmbSimValeTransporte.Text = "Sim";
            this.cmbSimValeTransporte.UseVisualStyleBackColor = true;
            // 
            // cmbNaoValeTransporte
            // 
            this.cmbNaoValeTransporte.AutoSize = true;
            this.cmbNaoValeTransporte.ForeColor = System.Drawing.Color.Black;
            this.cmbNaoValeTransporte.Location = new System.Drawing.Point(64, 326);
            this.cmbNaoValeTransporte.Name = "cmbNaoValeTransporte";
            this.cmbNaoValeTransporte.Size = new System.Drawing.Size(46, 17);
            this.cmbNaoValeTransporte.TabIndex = 16;
            this.cmbNaoValeTransporte.Text = "Não";
            this.cmbNaoValeTransporte.UseVisualStyleBackColor = true;
            // 
            // lblSalarioLiquido
            // 
            this.lblSalarioLiquido.AutoSize = true;
            this.lblSalarioLiquido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalarioLiquido.ForeColor = System.Drawing.Color.Black;
            this.lblSalarioLiquido.Location = new System.Drawing.Point(7, 304);
            this.lblSalarioLiquido.Name = "lblSalarioLiquido";
            this.lblSalarioLiquido.Size = new System.Drawing.Size(115, 15);
            this.lblSalarioLiquido.TabIndex = 27;
            this.lblSalarioLiquido.Text = "SALÁRIO LIQUÍDO :";
            // 
            // lblResultadoSalarioLiquido
            // 
            this.lblResultadoSalarioLiquido.AutoSize = true;
            this.lblResultadoSalarioLiquido.ForeColor = System.Drawing.Color.Black;
            this.lblResultadoSalarioLiquido.Location = new System.Drawing.Point(130, 306);
            this.lblResultadoSalarioLiquido.Name = "lblResultadoSalarioLiquido";
            this.lblResultadoSalarioLiquido.Size = new System.Drawing.Size(73, 13);
            this.lblResultadoSalarioLiquido.TabIndex = 28;
            this.lblResultadoSalarioLiquido.Text = "RESULTADO";
            // 
            // lblTotalAdicional
            // 
            this.lblTotalAdicional.AutoSize = true;
            this.lblTotalAdicional.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAdicional.ForeColor = System.Drawing.Color.Black;
            this.lblTotalAdicional.Location = new System.Drawing.Point(6, 236);
            this.lblTotalAdicional.Name = "lblTotalAdicional";
            this.lblTotalAdicional.Size = new System.Drawing.Size(115, 15);
            this.lblTotalAdicional.TabIndex = 29;
            this.lblTotalAdicional.Text = "TOTAL ADICIONAL :";
            // 
            // lblTotalDescontos
            // 
            this.lblTotalDescontos.AutoSize = true;
            this.lblTotalDescontos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDescontos.ForeColor = System.Drawing.Color.Black;
            this.lblTotalDescontos.Location = new System.Drawing.Point(6, 258);
            this.lblTotalDescontos.Name = "lblTotalDescontos";
            this.lblTotalDescontos.Size = new System.Drawing.Size(128, 15);
            this.lblTotalDescontos.TabIndex = 30;
            this.lblTotalDescontos.Text = "TOTAL DESCONTOS :";
            // 
            // lblResultadoTotalAdicional
            // 
            this.lblResultadoTotalAdicional.AutoSize = true;
            this.lblResultadoTotalAdicional.ForeColor = System.Drawing.Color.Black;
            this.lblResultadoTotalAdicional.Location = new System.Drawing.Point(127, 238);
            this.lblResultadoTotalAdicional.Name = "lblResultadoTotalAdicional";
            this.lblResultadoTotalAdicional.Size = new System.Drawing.Size(73, 13);
            this.lblResultadoTotalAdicional.TabIndex = 31;
            this.lblResultadoTotalAdicional.Text = "RESULTADO";
            // 
            // lblResultadoTotalDescontos
            // 
            this.lblResultadoTotalDescontos.AutoSize = true;
            this.lblResultadoTotalDescontos.ForeColor = System.Drawing.Color.Black;
            this.lblResultadoTotalDescontos.Location = new System.Drawing.Point(130, 260);
            this.lblResultadoTotalDescontos.Name = "lblResultadoTotalDescontos";
            this.lblResultadoTotalDescontos.Size = new System.Drawing.Size(73, 13);
            this.lblResultadoTotalDescontos.TabIndex = 32;
            this.lblResultadoTotalDescontos.Text = "RESULTADO";
            // 
            // frmContraCheque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(627, 465);
            this.Controls.Add(this.cmbNaoValeTransporte);
            this.Controls.Add(this.cmbSimValeTransporte);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbPericulosidadeNao);
            this.Controls.Add(this.cmbSimPericulosidade);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelResultado);
            this.Controls.Add(this.txtHorasNoturnas);
            this.Controls.Add(this.lblHorasNoturnas);
            this.Controls.Add(this.txtHorasExtras);
            this.Controls.Add(this.lblHorasExtras);
            this.Controls.Add(this.txtValorDaHora);
            this.Controls.Add(this.lblValorDaHora);
            this.Controls.Add(this.txtHorasTrabalhadas);
            this.Controls.Add(this.lblHorasTrabalhadas);
            this.Controls.Add(this.btnGerarContraCheque);
            this.Controls.Add(this.lblContraCheque);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmContraCheque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contra Cheque";
            this.panelResultado.ResumeLayout(false);
            this.panelResultado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblContraCheque;
        private System.Windows.Forms.Button btnGerarContraCheque;
        private System.Windows.Forms.Label lblHorasTrabalhadas;
        private System.Windows.Forms.TextBox txtHorasTrabalhadas;
        private System.Windows.Forms.Label lblValorDaHora;
        private System.Windows.Forms.TextBox txtValorDaHora;
        private System.Windows.Forms.Label lblHorasExtras;
        private System.Windows.Forms.TextBox txtHorasExtras;
        private System.Windows.Forms.Label lblHorasNoturnas;
        private System.Windows.Forms.TextBox txtHorasNoturnas;
        private System.Windows.Forms.Panel panelResultado;
        private System.Windows.Forms.Label lblHorasExtra;
        private System.Windows.Forms.Label lblResultadoSalarioBruto;
        private System.Windows.Forms.Label lblSalarioBruto;
        private System.Windows.Forms.Label lblNoturno;
        private System.Windows.Forms.Label lblResultadoHorasExtras;
        private System.Windows.Forms.Label lblValeTransporte;
        private System.Windows.Forms.Label lblResultadoFgts;
        private System.Windows.Forms.Label lblFgts;
        private System.Windows.Forms.Label lblResultadoPericulosidade;
        private System.Windows.Forms.Label lblPericulosidade;
        private System.Windows.Forms.Label lblResultadoNoturno;
        private System.Windows.Forms.Label lblResultadoIrpf;
        private System.Windows.Forms.Label lblIrpf;
        private System.Windows.Forms.Label lblResultadoInss;
        private System.Windows.Forms.Label lblInss;
        private System.Windows.Forms.Label lblResultadoValeTransporte;
        private System.Windows.Forms.CheckBox cmbSimPericulosidade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cmbPericulosidadeNao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cmbSimValeTransporte;
        private System.Windows.Forms.CheckBox cmbNaoValeTransporte;
        private System.Windows.Forms.Label lblSalarioLiquido;
        private System.Windows.Forms.Label lblResultadoTotalDescontos;
        private System.Windows.Forms.Label lblResultadoTotalAdicional;
        private System.Windows.Forms.Label lblTotalDescontos;
        private System.Windows.Forms.Label lblTotalAdicional;
        private System.Windows.Forms.Label lblResultadoSalarioLiquido;
    }
}