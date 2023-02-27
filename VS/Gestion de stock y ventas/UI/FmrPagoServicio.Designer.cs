namespace UI
{
    partial class FmrPagoServicio
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
            this.BtnSeleccioarServicio = new System.Windows.Forms.Button();
            this.BtnRealizarVenta = new System.Windows.Forms.Button();
            this.TxtServicio = new System.Windows.Forms.TextBox();
            this.TxtMotoAPagar = new System.Windows.Forms.TextBox();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Monto a pagar";
            // 
            // BtnSeleccioarServicio
            // 
            this.BtnSeleccioarServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSeleccioarServicio.Location = new System.Drawing.Point(12, 12);
            this.BtnSeleccioarServicio.Name = "BtnSeleccioarServicio";
            this.BtnSeleccioarServicio.Size = new System.Drawing.Size(211, 28);
            this.BtnSeleccioarServicio.TabIndex = 1;
            this.BtnSeleccioarServicio.Text = "Seleccionar Servicio";
            this.BtnSeleccioarServicio.UseVisualStyleBackColor = true;
            this.BtnSeleccioarServicio.Click += new System.EventHandler(this.BtnSeleccioarServicio_Click);
            // 
            // BtnRealizarVenta
            // 
            this.BtnRealizarVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRealizarVenta.Location = new System.Drawing.Point(149, 103);
            this.BtnRealizarVenta.Name = "BtnRealizarVenta";
            this.BtnRealizarVenta.Size = new System.Drawing.Size(161, 32);
            this.BtnRealizarVenta.TabIndex = 2;
            this.BtnRealizarVenta.Text = "Realizar Pago";
            this.BtnRealizarVenta.UseVisualStyleBackColor = true;
            this.BtnRealizarVenta.Click += new System.EventHandler(this.BtnRealizarVenta_Click);
            // 
            // TxtServicio
            // 
            this.TxtServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtServicio.Location = new System.Drawing.Point(229, 13);
            this.TxtServicio.Name = "TxtServicio";
            this.TxtServicio.Size = new System.Drawing.Size(177, 26);
            this.TxtServicio.TabIndex = 3;
            // 
            // TxtMotoAPagar
            // 
            this.TxtMotoAPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMotoAPagar.Location = new System.Drawing.Point(229, 57);
            this.TxtMotoAPagar.Name = "TxtMotoAPagar";
            this.TxtMotoAPagar.Size = new System.Drawing.Size(177, 26);
            this.TxtMotoAPagar.TabIndex = 4;
            // 
            // FmrPagoServicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 182);
            this.Controls.Add(this.TxtMotoAPagar);
            this.Controls.Add(this.TxtServicio);
            this.Controls.Add(this.BtnRealizarVenta);
            this.Controls.Add(this.BtnSeleccioarServicio);
            this.Controls.Add(this.label1);
            this.Name = "FmrPagoServicio";
            this.Text = "FmrPagoServicio";
            this.Load += new System.EventHandler(this.FmrPagoServicio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnSeleccioarServicio;
        private System.Windows.Forms.Button BtnRealizarVenta;
        private System.Windows.Forms.TextBox TxtServicio;
        private System.Windows.Forms.TextBox TxtMotoAPagar;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}