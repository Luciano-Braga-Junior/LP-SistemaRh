namespace iRh.Windows.Simuladores
{
    partial class frmBeneficioAdicionalNorturno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBeneficioAdicionalNorturno));
            this.lblHoraTrabalhada = new System.Windows.Forms.Label();
            this.txtHoraTrabalhada = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblHorasNoturnas = new System.Windows.Forms.Label();
            this.txtHorasNoturnas = new System.Windows.Forms.TextBox();
            this.panelResultado = new System.Windows.Forms.Panel();
            this.lblResultado = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelResultado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.lblHoraTrabalhada.TabIndex = 1;
            this.lblHoraTrabalhada.Text = "Informe o valor da sua hora trabalhada";
            // 
            // txtHoraTrabalhada
            // 
            this.txtHoraTrabalhada.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtHoraTrabalhada.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoraTrabalhada.Location = new System.Drawing.Point(17, 53);
            this.txtHoraTrabalhada.Name = "txtHoraTrabalhada";
            this.txtHoraTrabalhada.Size = new System.Drawing.Size(145, 35);
            this.txtHoraTrabalhada.TabIndex = 2;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCalcular.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCalcular.Location = new System.Drawing.Point(12, 255);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(123, 36);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblHorasNoturnas
            // 
            this.lblHorasNoturnas.AutoSize = true;
            this.lblHorasNoturnas.BackColor = System.Drawing.Color.Transparent;
            this.lblHorasNoturnas.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorasNoturnas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblHorasNoturnas.Location = new System.Drawing.Point(12, 111);
            this.lblHorasNoturnas.Name = "lblHorasNoturnas";
            this.lblHorasNoturnas.Size = new System.Drawing.Size(413, 30);
            this.lblHorasNoturnas.TabIndex = 4;
            this.lblHorasNoturnas.Text = "Informe as horas noturnas que você teve";
            // 
            // txtHorasNoturnas
            // 
            this.txtHorasNoturnas.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtHorasNoturnas.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHorasNoturnas.Location = new System.Drawing.Point(17, 160);
            this.txtHorasNoturnas.Name = "txtHorasNoturnas";
            this.txtHorasNoturnas.Size = new System.Drawing.Size(145, 35);
            this.txtHorasNoturnas.TabIndex = 5;
            // 
            // panelResultado
            // 
            this.panelResultado.BackColor = System.Drawing.Color.DodgerBlue;
            this.panelResultado.Controls.Add(this.lblResultado);
            this.panelResultado.Location = new System.Drawing.Point(429, 255);
            this.panelResultado.Name = "panelResultado";
            this.panelResultado.Size = new System.Drawing.Size(116, 36);
            this.panelResultado.TabIndex = 6;
            this.panelResultado.Visible = false;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblResultado.Location = new System.Drawing.Point(-5, 6);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(126, 30);
            this.lblResultado.TabIndex = 1;
            this.lblResultado.Text = "lblResultado";
            this.lblResultado.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(572, 304);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // frmBeneficioAdicionalNorturno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(570, 303);
            this.Controls.Add(this.panelResultado);
            this.Controls.Add(this.txtHorasNoturnas);
            this.Controls.Add(this.lblHorasNoturnas);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtHoraTrabalhada);
            this.Controls.Add(this.lblHoraTrabalhada);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBeneficioAdicionalNorturno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicional Noturno";
            this.panelResultado.ResumeLayout(false);
            this.panelResultado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHoraTrabalhada;
        private System.Windows.Forms.TextBox txtHoraTrabalhada;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblHorasNoturnas;
        private System.Windows.Forms.TextBox txtHorasNoturnas;
        private System.Windows.Forms.Panel panelResultado;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}