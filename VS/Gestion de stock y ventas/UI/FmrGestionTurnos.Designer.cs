namespace UI
{
    partial class FmrGestionTurnos
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
            this.BtnIniciarTurno = new System.Windows.Forms.Button();
            this.BtnCerrarTurno = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtMontoInicial = new System.Windows.Forms.TextBox();
            this.CkbTurno = new System.Windows.Forms.CheckBox();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.SuspendLayout();
            // 
            // BtnIniciarTurno
            // 
            this.BtnIniciarTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIniciarTurno.Location = new System.Drawing.Point(53, 137);
            this.BtnIniciarTurno.Name = "BtnIniciarTurno";
            this.BtnIniciarTurno.Size = new System.Drawing.Size(178, 32);
            this.BtnIniciarTurno.TabIndex = 1;
            this.BtnIniciarTurno.Text = "Iniciar Turno";
            this.BtnIniciarTurno.UseVisualStyleBackColor = true;
            this.BtnIniciarTurno.Click += new System.EventHandler(this.BtnIniciarTurno_Click);
            // 
            // BtnCerrarTurno
            // 
            this.BtnCerrarTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCerrarTurno.Location = new System.Drawing.Point(291, 137);
            this.BtnCerrarTurno.Name = "BtnCerrarTurno";
            this.BtnCerrarTurno.Size = new System.Drawing.Size(160, 32);
            this.BtnCerrarTurno.TabIndex = 2;
            this.BtnCerrarTurno.Text = "Cerrar Turno";
            this.BtnCerrarTurno.UseVisualStyleBackColor = true;
            this.BtnCerrarTurno.Click += new System.EventHandler(this.BtnCerrarTurno_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Monto Inicial en Caja";
            // 
            // TxtMontoInicial
            // 
            this.TxtMontoInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMontoInicial.Location = new System.Drawing.Point(224, 72);
            this.TxtMontoInicial.Name = "TxtMontoInicial";
            this.TxtMontoInicial.Size = new System.Drawing.Size(171, 26);
            this.TxtMontoInicial.TabIndex = 4;
            // 
            // CkbTurno
            // 
            this.CkbTurno.AutoSize = true;
            this.CkbTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CkbTurno.Location = new System.Drawing.Point(12, 12);
            this.CkbTurno.Name = "CkbTurno";
            this.CkbTurno.Size = new System.Drawing.Size(140, 24);
            this.CkbTurno.TabIndex = 5;
            this.CkbTurno.Text = "Turno iniciado";
            this.CkbTurno.UseVisualStyleBackColor = true;
            // 
            // FmrGestionTurnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 192);
            this.Controls.Add(this.CkbTurno);
            this.Controls.Add(this.TxtMontoInicial);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnCerrarTurno);
            this.Controls.Add(this.BtnIniciarTurno);
            this.Name = "FmrGestionTurnos";
            this.Text = "FmrGestionTurnos";
            this.Load += new System.EventHandler(this.FmrGestionTurnos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnIniciarTurno;
        private System.Windows.Forms.Button BtnCerrarTurno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtMontoInicial;
        private System.Windows.Forms.CheckBox CkbTurno;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}