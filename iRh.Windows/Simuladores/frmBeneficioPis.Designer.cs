namespace iRh.Windows.Simuladores
{
    partial class frmBeneficioPis
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblInscricao = new System.Windows.Forms.Label();
            this.txtInscricao = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblMesesTrabalhados = new System.Windows.Forms.Label();
            this.txtMesesTrabalhados = new System.Windows.Forms.TextBox();
            this.panelResultado = new System.Windows.Forms.Panel();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblSalarioBruto = new System.Windows.Forms.Label();
            this.txtSalarioBruto = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelResultado.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(662, 352);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblInscricao
            // 
            this.lblInscricao.AutoSize = true;
            this.lblInscricao.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblInscricao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInscricao.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblInscricao.Location = new System.Drawing.Point(12, 94);
            this.lblInscricao.Name = "lblInscricao";
            this.lblInscricao.Size = new System.Drawing.Size(322, 21);
            this.lblInscricao.TabIndex = 1;
            this.lblInscricao.Text = "A quanto tempo você está inscrito no PIS";
            // 
            // txtInscricao
            // 
            this.txtInscricao.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtInscricao.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInscricao.Location = new System.Drawing.Point(12, 118);
            this.txtInscricao.Name = "txtInscricao";
            this.txtInscricao.Size = new System.Drawing.Size(147, 35);
            this.txtInscricao.TabIndex = 3;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCalcular.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCalcular.Location = new System.Drawing.Point(17, 302);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(123, 36);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click_1);
            // 
            // lblMesesTrabalhados
            // 
            this.lblMesesTrabalhados.AutoSize = true;
            this.lblMesesTrabalhados.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lblMesesTrabalhados.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMesesTrabalhados.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMesesTrabalhados.Location = new System.Drawing.Point(8, 178);
            this.lblMesesTrabalhados.Name = "lblMesesTrabalhados";
            this.lblMesesTrabalhados.Size = new System.Drawing.Size(429, 21);
            this.lblMesesTrabalhados.TabIndex = 5;
            this.lblMesesTrabalhados.Text = "Digite a quantidade de meses trabalhados no ano-base";
            // 
            // txtMesesTrabalhados
            // 
            this.txtMesesTrabalhados.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtMesesTrabalhados.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMesesTrabalhados.Location = new System.Drawing.Point(12, 202);
            this.txtMesesTrabalhados.Name = "txtMesesTrabalhados";
            this.txtMesesTrabalhados.Size = new System.Drawing.Size(147, 35);
            this.txtMesesTrabalhados.TabIndex = 6;
            // 
            // panelResultado
            // 
            this.panelResultado.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelResultado.Controls.Add(this.lblResultado);
            this.panelResultado.Location = new System.Drawing.Point(464, 276);
            this.panelResultado.Name = "panelResultado";
            this.panelResultado.Size = new System.Drawing.Size(184, 62);
            this.panelResultado.TabIndex = 7;
            this.panelResultado.Visible = false;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblResultado.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblResultado.Location = new System.Drawing.Point(27, 16);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(135, 30);
            this.lblResultado.TabIndex = 1;
            this.lblResultado.Text = "lblResultado";
            this.lblResultado.Visible = false;
            // 
            // lblSalarioBruto
            // 
            this.lblSalarioBruto.AutoSize = true;
            this.lblSalarioBruto.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSalarioBruto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalarioBruto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSalarioBruto.Location = new System.Drawing.Point(13, 9);
            this.lblSalarioBruto.Name = "lblSalarioBruto";
            this.lblSalarioBruto.Size = new System.Drawing.Size(109, 21);
            this.lblSalarioBruto.TabIndex = 8;
            this.lblSalarioBruto.Text = "Salario Bruto";
            // 
            // txtSalarioBruto
            // 
            this.txtSalarioBruto.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtSalarioBruto.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalarioBruto.Location = new System.Drawing.Point(12, 33);
            this.txtSalarioBruto.Name = "txtSalarioBruto";
            this.txtSalarioBruto.Size = new System.Drawing.Size(147, 35);
            this.txtSalarioBruto.TabIndex = 9;
            // 
            // frmBeneficioPis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 350);
            this.Controls.Add(this.txtSalarioBruto);
            this.Controls.Add(this.lblSalarioBruto);
            this.Controls.Add(this.panelResultado);
            this.Controls.Add(this.txtMesesTrabalhados);
            this.Controls.Add(this.lblMesesTrabalhados);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtInscricao);
            this.Controls.Add(this.lblInscricao);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBeneficioPis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Beneficio De PIS";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelResultado.ResumeLayout(false);
            this.panelResultado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblInscricao;
        private System.Windows.Forms.TextBox txtInscricao;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblMesesTrabalhados;
        private System.Windows.Forms.TextBox txtMesesTrabalhados;
        private System.Windows.Forms.Panel panelResultado;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblSalarioBruto;
        private System.Windows.Forms.TextBox txtSalarioBruto;
    }
}