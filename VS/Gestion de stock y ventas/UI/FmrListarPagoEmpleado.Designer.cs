using SL.Services.Extensions;

namespace UI
{
    partial class FmrListarPagoEmpleado
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
            this.BtnSeleccionarPagoEmpleado = new System.Windows.Forms.Button();
            this.DtmFin = new System.Windows.Forms.DateTimePicker();
            this.DtmInicio = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.IdPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DniEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto_pagado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_de_pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DtgPagoEmpleado)).BeginInit();
            this.SuspendLayout();
            // 
            // DtgPagoEmpleado
            // 
            this.DtgPagoEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgPagoEmpleado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdPago,
            this.DniEmpleado,
            this.Nombre_empleado,
            this.Monto_pagado,
            this.Fecha_de_pago});
            this.DtgPagoEmpleado.Location = new System.Drawing.Point(12, 84);
            this.DtgPagoEmpleado.Name = "DtgPagoEmpleado";
            this.DtgPagoEmpleado.Size = new System.Drawing.Size(583, 305);
            this.DtgPagoEmpleado.TabIndex = 0;
            // 
            // BtnSeleccionarPagoEmpleado
            // 
            this.BtnSeleccionarPagoEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSeleccionarPagoEmpleado.Location = new System.Drawing.Point(12, 409);
            this.BtnSeleccionarPagoEmpleado.Name = "BtnSeleccionarPagoEmpleado";
            this.BtnSeleccionarPagoEmpleado.Size = new System.Drawing.Size(279, 29);
            this.BtnSeleccionarPagoEmpleado.TabIndex = 1;
            this.BtnSeleccionarPagoEmpleado.Text = "Seleccionar Pago Empleado";
            this.BtnSeleccionarPagoEmpleado.UseVisualStyleBackColor = true;
            this.BtnSeleccionarPagoEmpleado.Click += new System.EventHandler(this.BtnSeleccionarPagoEmpleado_Click);
            // 
            // DtmFin
            // 
            this.DtmFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtmFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtmFin.Location = new System.Drawing.Point(157, 44);
            this.DtmFin.Name = "DtmFin";
            this.DtmFin.Size = new System.Drawing.Size(134, 26);
            this.DtmFin.TabIndex = 11;
            // 
            // DtmInicio
            // 
            this.DtmInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtmInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtmInicio.Location = new System.Drawing.Point(157, 12);
            this.DtmInicio.Name = "DtmInicio";
            this.DtmInicio.Size = new System.Drawing.Size(134, 26);
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
            this.BtnBuscar.Location = new System.Drawing.Point(339, 11);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(256, 32);
            this.BtnBuscar.TabIndex = 7;
            this.BtnBuscar.Text = "Buscar Pagos de Empleados";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // IdPago
            // 
            this.IdPago.HeaderText = "IdPago";
            this.IdPago.Name = "IdPago";
            // 
            // DniEmpleado
            // 
            this.DniEmpleado.HeaderText = "Dni Empleado";
            this.DniEmpleado.Name = "DniEmpleado";
            // 
            // Nombre_empleado
            // 
            this.Nombre_empleado.HeaderText = "Nombre_empleado";
            this.Nombre_empleado.Name = "Nombre_empleado";
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
            // FmrListarPagoEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 450);
            this.Controls.Add(this.DtmFin);
            this.Controls.Add(this.DtmInicio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.BtnSeleccionarPagoEmpleado);
            this.Controls.Add(this.DtgPagoEmpleado);
            this.Name = "FmrListarPagoEmpleado";
            this.Text = "FmrListarPagoEmpleado";
            this.Load += new System.EventHandler(this.FmrListarPagoEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtgPagoEmpleado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DtgPagoEmpleado;
        private System.Windows.Forms.Button BtnSeleccionarPagoEmpleado;
        private System.Windows.Forms.DateTimePicker DtmFin;
        private System.Windows.Forms.DateTimePicker DtmInicio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn DniEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto_pagado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_de_pago;
    }
}