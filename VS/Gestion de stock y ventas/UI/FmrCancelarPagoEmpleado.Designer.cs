using SL.Services.Extensions;

namespace UI
{
    partial class FmrCancelarPagoEmpleado
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
            this.DtgPagoEmpleado = new System.Windows.Forms.DataGridView();
            this.BtnBuscarPago = new System.Windows.Forms.Button();
            this.BtnCancelarPago = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.IdPagoEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DniEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_Empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto_pagado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_de_pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DtgPagoEmpleado)).BeginInit();
            this.SuspendLayout();
            // 
            // DtgPagoEmpleado
            // 
            this.DtgPagoEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgPagoEmpleado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdPagoEmpleado,
            this.DniEmpleado,
            this.Nombre_Empleado,
            this.Monto_pagado,
            this.Fecha_de_pago});
            this.DtgPagoEmpleado.Location = new System.Drawing.Point(12, 12);
            this.DtgPagoEmpleado.Name = "DtgPagoEmpleado";
            this.DtgPagoEmpleado.Size = new System.Drawing.Size(592, 133);
            this.DtgPagoEmpleado.TabIndex = 0;
            // 
            // BtnBuscarPago
            // 
            this.BtnBuscarPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscarPago.Location = new System.Drawing.Point(12, 199);
            this.BtnBuscarPago.Name = "BtnBuscarPago";
            this.BtnBuscarPago.Size = new System.Drawing.Size(219, 28);
            this.BtnBuscarPago.TabIndex = 1;
            this.BtnBuscarPago.Text = "Buscar Pago Empleado";
            this.BtnBuscarPago.UseVisualStyleBackColor = true;
            this.BtnBuscarPago.Click += new System.EventHandler(this.BtnBuscarPago_Click);
            // 
            // BtnCancelarPago
            // 
            this.BtnCancelarPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelarPago.Location = new System.Drawing.Point(384, 199);
            this.BtnCancelarPago.Name = "BtnCancelarPago";
            this.BtnCancelarPago.Size = new System.Drawing.Size(220, 30);
            this.BtnCancelarPago.TabIndex = 2;
            this.BtnCancelarPago.Text = "Cancelar Pago Empleado";
            this.BtnCancelarPago.UseVisualStyleBackColor = true;
            this.BtnCancelarPago.Click += new System.EventHandler(this.BtnCancelarPago_Click);
            // 
            // IdPagoEmpleado
            // 
            this.IdPagoEmpleado.HeaderText = "IdPagoEmpleado";
            this.IdPagoEmpleado.Name = "IdPagoEmpleado";
            // 
            // DniEmpleado
            // 
            this.DniEmpleado.HeaderText = "Dni Empleado";
            this.DniEmpleado.Name = "DniEmpleado";
            // 
            // Nombre_Empleado
            // 
            this.Nombre_Empleado.HeaderText = "Nombre_Empleado";
            this.Nombre_Empleado.Name = "Nombre_Empleado";
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
            // FmrCancelarPagoEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 289);
            this.Controls.Add(this.BtnCancelarPago);
            this.Controls.Add(this.BtnBuscarPago);
            this.Controls.Add(this.DtgPagoEmpleado);
            this.Name = "FmrCancelarPagoEmpleado";
            this.Text = "FmrCancelarPagoEmpleado";
            this.Load += new System.EventHandler(this.FmrCancelarPagoEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtgPagoEmpleado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DtgPagoEmpleado;
        private System.Windows.Forms.Button BtnBuscarPago;
        private System.Windows.Forms.Button BtnCancelarPago;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPagoEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn DniEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto_pagado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_de_pago;
    }
}