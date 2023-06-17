namespace iRh.Windows.Simuladores
{
    partial class frmBeneficioSeguroDesemprego
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBeneficioSeguroDesemprego));
            this.lblMesesTrabalhados = new System.Windows.Forms.Label();
            this.txtMesesTrabalhados = new System.Windows.Forms.TextBox();
            this.btnTemOuNao = new System.Windows.Forms.Button();
            this.panelResultado = new System.Windows.Forms.Panel();
            this.lblResultado = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelResultado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMesesTrabalhados
            // 
            this.lblMesesTrabalhados.AutoSize = true;
            this.lblMesesTrabalhados.BackColor = System.Drawing.Color.Transparent;
            this.lblMesesTrabalhados.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMesesTrabalhados.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMesesTrabalhados.Location = new System.Drawing.Point(12, 9);
            this.lblMesesTrabalhados.Name = "lblMesesTrabalhados";
            this.lblMesesTrabalhados.Size = new System.Drawing.Size(617, 30);
            this.lblMesesTrabalhados.TabIndex = 2;
            this.lblMesesTrabalhados.Text = "Informe a quantidade de meses trabalhados nos últimos anos";
            // 
            // txtMesesTrabalhados
            // 
            this.txtMesesTrabalhados.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtMesesTrabalhados.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMesesTrabalhados.Location = new System.Drawing.Point(17, 53);
            this.txtMesesTrabalhados.Name = "txtMesesTrabalhados";
            this.txtMesesTrabalhados.Size = new System.Drawing.Size(224, 35);
            this.txtMesesTrabalhados.TabIndex = 3;
            // 
            // btnTemOuNao
            // 
            this.btnTemOuNao.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTemOuNao.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTemOuNao.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTemOuNao.Location = new System.Drawing.Point(17, 274);
            this.btnTemOuNao.Name = "btnTemOuNao";
            this.btnTemOuNao.Size = new System.Drawing.Size(123, 36);
            this.btnTemOuNao.TabIndex = 4;
            this.btnTemOuNao.Text = "Confirmar";
            this.btnTemOuNao.UseVisualStyleBackColor = false;
            this.btnTemOuNao.Click += new System.EventHandler(this.btnTemOuNao_Click);
            // 
            // panelResultado
            // 
            this.panelResultado.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelResultado.Controls.Add(this.lblResultado);
            this.panelResultado.Location = new System.Drawing.Point(463, 260);
            this.panelResultado.Name = "panelResultado";
            this.panelResultado.Size = new System.Drawing.Size(157, 50);
            this.panelResultado.TabIndex = 9;
            this.panelResultado.Visible = false;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblResultado.Location = new System.Drawing.Point(16, 10);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(126, 30);
            this.lblResultado.TabIndex = 1;
            this.lblResultado.Text = "lblResultado";
            this.lblResultado.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(628, 323);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // frmBeneficioSeguroDesemprego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 322);
            this.Controls.Add(this.panelResultado);
            this.Controls.Add(this.btnTemOuNao);
            this.Controls.Add(this.txtMesesTrabalhados);
            this.Controls.Add(this.lblMesesTrabalhados);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBeneficioSeguroDesemprego";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Beneficio De Seguro Desemprego";
            this.panelResultado.ResumeLayout(false);
            this.panelResultado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMesesTrabalhados;
        private System.Windows.Forms.TextBox txtMesesTrabalhados;
        private System.Windows.Forms.Button btnTemOuNao;
        private System.Windows.Forms.Panel panelResultado;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}