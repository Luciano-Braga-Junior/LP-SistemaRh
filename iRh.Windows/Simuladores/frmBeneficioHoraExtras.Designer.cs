namespace iRh.Windows.Simuladores
{
    partial class frmBeneficioHoraExtras
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
            this.lblHoraTrabalhada = new System.Windows.Forms.Label();
            this.txtHoraTrabalhada = new System.Windows.Forms.TextBox();
            this.lblHorasExtras = new System.Windows.Forms.Label();
            this.txtHorasExtras = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.panelResultado = new System.Windows.Forms.Panel();
            this.lblResultado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelResultado.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(642, 344);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblHoraTrabalhada
            // 
            this.lblHoraTrabalhada.AutoSize = true;
            this.lblHoraTrabalhada.BackColor = System.Drawing.Color.Transparent;
            this.lblHoraTrabalhada.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraTrabalhada.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblHoraTrabalhada.Location = new System.Drawing.Point(12, 9);
            this.lblHoraTrabalhada.Name = "lblHoraTrabalhada";
            this.lblHoraTrabalhada.Size = new System.Drawing.Size(397, 30);
            this.lblHoraTrabalhada.TabIndex = 2;
            this.lblHoraTrabalhada.Text = "Informe o valor da sua hora trabalhada";
            // 
            // txtHoraTrabalhada
            // 
            this.txtHoraTrabalhada.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtHoraTrabalhada.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoraTrabalhada.Location = new System.Drawing.Point(17, 54);
            this.txtHoraTrabalhada.Name = "txtHoraTrabalhada";
            this.txtHoraTrabalhada.Size = new System.Drawing.Size(145, 35);
            this.txtHoraTrabalhada.TabIndex = 3;
            // 
            // lblHorasExtras
            // 
            this.lblHorasExtras.AutoSize = true;
            this.lblHorasExtras.BackColor = System.Drawing.Color.Transparent;
            this.lblHorasExtras.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorasExtras.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblHorasExtras.Location = new System.Drawing.Point(12, 109);
            this.lblHorasExtras.Name = "lblHorasExtras";
            this.lblHorasExtras.Size = new System.Drawing.Size(384, 30);
            this.lblHorasExtras.TabIndex = 5;
            this.lblHorasExtras.Text = "Informe as horas extras que você teve";
            // 
            // txtHorasExtras
            // 
            this.txtHorasExtras.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtHorasExtras.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHorasExtras.Location = new System.Drawing.Point(17, 162);
            this.txtHorasExtras.Name = "txtHorasExtras";
            this.txtHorasExtras.Size = new System.Drawing.Size(145, 35);
            this.txtHorasExtras.TabIndex = 6;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCalcular.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCalcular.Location = new System.Drawing.Point(12, 285);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(123, 36);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // panelResultado
            // 
            this.panelResultado.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelResultado.Controls.Add(this.lblResultado);
            this.panelResultado.Location = new System.Drawing.Point(472, 271);
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
            // frmBeneficioHoraExtras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 333);
            this.Controls.Add(this.panelResultado);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtHorasExtras);
            this.Controls.Add(this.lblHorasExtras);
            this.Controls.Add(this.txtHoraTrabalhada);
            this.Controls.Add(this.lblHoraTrabalhada);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBeneficioHoraExtras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Beneficio De Horas Extras";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelResultado.ResumeLayout(false);
            this.panelResultado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblHoraTrabalhada;
        private System.Windows.Forms.TextBox txtHoraTrabalhada;
        private System.Windows.Forms.Label lblHorasExtras;
        private System.Windows.Forms.TextBox txtHorasExtras;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Panel panelResultado;
        private System.Windows.Forms.Label lblResultado;
    }
}