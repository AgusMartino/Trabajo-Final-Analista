using SL.Services.Extensions;

namespace UI
{
    partial class FmrListarPagoProveedores
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
            this.BtnSeleccionarPagoProveedor = new System.Windows.Forms.Button();
            this.DtgPagoProveedor = new System.Windows.Forms.DataGridView();
            this.DtmFin = new System.Windows.Forms.DateTimePicker();
            this.DtmInicio = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.IdPagoProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cuit_proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto_pagado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto_adeudado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_de_pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DtgPagoProveedor)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnSeleccionarPagoProveedor
            // 
            this.BtnSeleccionarPagoProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSeleccionarPagoProveedor.Location = new System.Drawing.Point(12, 447);
            this.BtnSeleccionarPagoProveedor.Name = "BtnSeleccionarPagoProveedor";
            this.BtnSeleccionarPagoProveedor.Size = new System.Drawing.Size(257, 28);
            this.BtnSeleccionarPagoProveedor.TabIndex = 3;
            this.BtnSeleccionarPagoProveedor.Text = "Seleccionar Pago Proveedor";
            this.BtnSeleccionarPagoProveedor.UseVisualStyleBackColor = true;
            this.BtnSeleccionarPagoProveedor.Click += new System.EventHandler(this.BtnSeleccionarPagoProveedor_Click);
            // 
            // DtgPagoProveedor
            // 
            this.DtgPagoProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgPagoProveedor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdPagoProveedor,
            this.Cuit_proveedor,
            this.Nombre_proveedor,
            this.Monto_pagado,
            this.Monto_adeudado,
            this.Total,
            this.Fecha_de_pago});
            this.DtgPagoProveedor.Location = new System.Drawing.Point(12, 90);
            this.DtgPagoProveedor.Name = "DtgPagoProveedor";
            this.DtgPagoProveedor.Size = new System.Drawing.Size(775, 351);
            this.DtgPagoProveedor.TabIndex = 2;
            // 
            // DtmFin
            // 
            this.DtmFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtmFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtmFin.Location = new System.Drawing.Point(157, 44);
            this.DtmFin.Name = "DtmFin";
            this.DtmFin.Size = new System.Drawing.Size(157, 26);
            this.DtmFin.TabIndex = 11;
            // 
            // DtmInicio
            // 
            this.DtmInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtmInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtmInicio.Location = new System.Drawing.Point(157, 12);
            this.DtmInicio.Name = "DtmInicio";
            this.DtmInicio.Size = new System.Drawing.Size(157, 26);
            this.DtmInicio.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Fecha de Fin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Fecha de Inicio";
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar.Location = new System.Drawing.Point(543, 12);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(244, 32);
            this.BtnBuscar.TabIndex = 7;
            this.BtnBuscar.Text = "Buscar Pagos de proveedor";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // IdPagoProveedor
            // 
            this.IdPagoProveedor.HeaderText = "IdPagoProveedor";
            this.IdPagoProveedor.Name = "IdPagoProveedor";
            // 
            // Cuit_proveedor
            // 
            this.Cuit_proveedor.HeaderText = "Cuit Proveedor";
            this.Cuit_proveedor.Name = "Cuit_proveedor";
            // 
            // Nombre_proveedor
            // 
            this.Nombre_proveedor.HeaderText = "Nombre_proveedor";
            this.Nombre_proveedor.Name = "Nombre_proveedor";
            // 
            // Monto_pagado
            // 
            this.Monto_pagado.HeaderText = "Monto_pagado";
            this.Monto_pagado.Name = "Monto_pagado";
            // 
            // Monto_adeudado
            // 
            this.Monto_adeudado.HeaderText = "Monto_adeudado";
            this.Monto_adeudado.Name = "Monto_adeudado";
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            // 
            // Fecha_de_pago
            // 
            this.Fecha_de_pago.HeaderText = "Fecha_de_pago";
            this.Fecha_de_pago.Name = "Fecha_de_pago";
            // 
            // FmrListarPagoProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 487);
            this.Controls.Add(this.DtmFin);
            this.Controls.Add(this.DtmInicio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.BtnSeleccionarPagoProveedor);
            this.Controls.Add(this.DtgPagoProveedor);
            this.Name = "FmrListarPagoProveedores";
            this.Text = "FmrListarPagoProveedores";
            this.Load += new System.EventHandler(this.FmrListarPagoProveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtgPagoProveedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSeleccionarPagoProveedor;
        private System.Windows.Forms.DataGridView DtgPagoProveedor;
        private System.Windows.Forms.DateTimePicker DtmFin;
        private System.Windows.Forms.DateTimePicker DtmInicio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPagoProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuit_proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto_pagado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto_adeudado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_de_pago;
    }
}