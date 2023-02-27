using SL.Services.Extensions;

namespace UI
{
    partial class FmrCancelarPagoServicio
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
            this.DtgPagoServicio = new System.Windows.Forms.DataGridView();
            this.BtnBuscarPagoServicio = new System.Windows.Forms.Button();
            this.BtnCancelarPago = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.IdPagoservicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo_servicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_servicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto_pagado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_de_pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DtgPagoServicio)).BeginInit();
            this.SuspendLayout();
            // 
            // DtgPagoServicio
            // 
            this.DtgPagoServicio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgPagoServicio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdPagoservicio,
            this.Codigo_servicio,
            this.Nombre_servicio,
            this.Monto_pagado,
            this.Fecha_de_pago});
            this.DtgPagoServicio.Location = new System.Drawing.Point(12, 12);
            this.DtgPagoServicio.Name = "DtgPagoServicio";
            this.DtgPagoServicio.Size = new System.Drawing.Size(660, 148);
            this.DtgPagoServicio.TabIndex = 0;
            // 
            // BtnBuscarPagoServicio
            // 
            this.BtnBuscarPagoServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscarPagoServicio.Location = new System.Drawing.Point(12, 198);
            this.BtnBuscarPagoServicio.Name = "BtnBuscarPagoServicio";
            this.BtnBuscarPagoServicio.Size = new System.Drawing.Size(237, 28);
            this.BtnBuscarPagoServicio.TabIndex = 1;
            this.BtnBuscarPagoServicio.Text = "Buscar Pago Servicio";
            this.BtnBuscarPagoServicio.UseVisualStyleBackColor = true;
            this.BtnBuscarPagoServicio.Click += new System.EventHandler(this.BtnBuscarPagoServicio_Click);
            // 
            // BtnCancelarPago
            // 
            this.BtnCancelarPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelarPago.Location = new System.Drawing.Point(435, 198);
            this.BtnCancelarPago.Name = "BtnCancelarPago";
            this.BtnCancelarPago.Size = new System.Drawing.Size(237, 28);
            this.BtnCancelarPago.TabIndex = 2;
            this.BtnCancelarPago.Text = "Cancelar Pago Servicio";
            this.BtnCancelarPago.UseVisualStyleBackColor = true;
            this.BtnCancelarPago.Click += new System.EventHandler(this.BtnCancelarPago_Click);
            // 
            // IdPagoservicio
            // 
            this.IdPagoservicio.HeaderText = "IdPagoservicio";
            this.IdPagoservicio.Name = "IdPagoservicio";
            // 
            // Codigo_servicio
            // 
            this.Codigo_servicio.HeaderText = "Codigo Servicio";
            this.Codigo_servicio.Name = "Codigo_servicio";
            // 
            // Nombre_servicio
            // 
            this.Nombre_servicio.HeaderText = "Nombre_servicio";
            this.Nombre_servicio.Name = "Nombre_servicio";
            // 
            // Monto_pagado
            // 
            this.Monto_pagado.HeaderText = "Monto_pagado";
            this.Monto_pagado.Name = "Monto_pagado";
            // 
            // Fecha_de_pago
            // 
            this.Fecha_de_pago.HeaderText = "Fecha_de_pago";
            this.Fecha_de_pago.Name = "Fecha_de_pago";
            // 
            // FmrCancelarPagoServicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 254);
            this.Controls.Add(this.BtnCancelarPago);
            this.Controls.Add(this.BtnBuscarPagoServicio);
            this.Controls.Add(this.DtgPagoServicio);
            this.Name = "FmrCancelarPagoServicio";
            this.Text = "FmrCancelarPagoServicio";
            this.Load += new System.EventHandler(this.FmrCancelarPagoServicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtgPagoServicio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DtgPagoServicio;
        private System.Windows.Forms.Button BtnBuscarPagoServicio;
        private System.Windows.Forms.Button BtnCancelarPago;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPagoservicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo_servicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_servicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto_pagado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_de_pago;
    }
}