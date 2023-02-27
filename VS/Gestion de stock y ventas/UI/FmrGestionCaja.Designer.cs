namespace UI
{
    partial class FmrGestionCaja
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnIngresarDinero = new System.Windows.Forms.Button();
            this.BtnEgresarDinero = new System.Windows.Forms.Button();
            this.TxtMonto = new System.Windows.Forms.TextBox();
            this.CmbTipodeMoneda = new System.Windows.Forms.ComboBox();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo de Moneda";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(106, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Monto";
            // 
            // BtnIngresarDinero
            // 
            this.BtnIngresarDinero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIngresarDinero.Location = new System.Drawing.Point(12, 134);
            this.BtnIngresarDinero.Name = "BtnIngresarDinero";
            this.BtnIngresarDinero.Size = new System.Drawing.Size(149, 33);
            this.BtnIngresarDinero.TabIndex = 3;
            this.BtnIngresarDinero.Text = "Ingresar Dinero";
            this.BtnIngresarDinero.UseVisualStyleBackColor = true;
            this.BtnIngresarDinero.Click += new System.EventHandler(this.BtnIngresarDinero_Click);
            // 
            // BtnEgresarDinero
            // 
            this.BtnEgresarDinero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEgresarDinero.Location = new System.Drawing.Point(224, 134);
            this.BtnEgresarDinero.Name = "BtnEgresarDinero";
            this.BtnEgresarDinero.Size = new System.Drawing.Size(144, 33);
            this.BtnEgresarDinero.TabIndex = 4;
            this.BtnEgresarDinero.Text = "Egresar Dinero";
            this.BtnEgresarDinero.UseVisualStyleBackColor = true;
            this.BtnEgresarDinero.Click += new System.EventHandler(this.BtnEgresarDinero_Click);
            // 
            // TxtMonto
            // 
            this.TxtMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMonto.Location = new System.Drawing.Point(171, 83);
            this.TxtMonto.Name = "TxtMonto";
            this.TxtMonto.Size = new System.Drawing.Size(197, 26);
            this.TxtMonto.TabIndex = 6;
            // 
            // CmbTipodeMoneda
            // 
            this.CmbTipodeMoneda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbTipodeMoneda.FormattingEnabled = true;
            this.CmbTipodeMoneda.Location = new System.Drawing.Point(171, 49);
            this.CmbTipodeMoneda.Name = "CmbTipodeMoneda";
            this.CmbTipodeMoneda.Size = new System.Drawing.Size(197, 28);
            this.CmbTipodeMoneda.TabIndex = 7;
            // 
            // FmrGestionCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 236);
            this.Controls.Add(this.CmbTipodeMoneda);
            this.Controls.Add(this.TxtMonto);
            this.Controls.Add(this.BtnEgresarDinero);
            this.Controls.Add(this.BtnIngresarDinero);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FmrGestionCaja";
            this.Text = "FmrGestionCaja";
            this.Load += new System.EventHandler(this.FmrGestionCaja_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnIngresarDinero;
        private System.Windows.Forms.Button BtnEgresarDinero;
        private System.Windows.Forms.TextBox TxtMonto;
        private System.Windows.Forms.ComboBox CmbTipodeMoneda;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}