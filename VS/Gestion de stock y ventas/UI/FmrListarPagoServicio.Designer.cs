using SL.Services.Extensions;

namespace UI
{
    partial class FmrListarPagoServicio
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
            this.BtnSeleccionarPagoServicio = new System.Windows.Forms.Button();
            this.DtgPagoServicio = new System.Windows.Forms.DataGridView();
            this.DtmFin = new System.Windows.Forms.DateTimePicker();
            this.DtmInicio = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.IdPagoServicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo_Servicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_Servicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto_pagado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_de_pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DtgPagoServicio)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnSeleccionarPagoServicio
            // 
            this.BtnSeleccionarPagoServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSeleccionarPagoServicio.Location = new System.Drawing.Point(12, 463);
            this.BtnSeleccionarPagoServicio.Name = "BtnSeleccionarPagoServicio";
            this.BtnSeleccionarPagoServicio.Size = new System.Drawing.Size(236, 28);
            this.BtnSeleccionarPagoServicio.TabIndex = 3;
            this.BtnSeleccionarPagoServicio.Text = "Seleccionar Pago Servicio";
            this.BtnSeleccionarPagoServicio.UseVisualStyleBackColor = true;
            this.BtnSeleccionarPagoServicio.Click += new System.EventHandler(this.BtnSeleccionarPagoServicio_Click);
            // 
            // DtgPagoServicio
            // 
            this.DtgPagoServicio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgPagoServicio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdPagoServicio,
            this.Codigo_Servicio,
            this.Nombre_Servicio,
            this.Monto_pagado,
            this.Fecha_de_pago});
            this.DtgPagoServicio.Location = new System.Drawing.Point(12, 76);
            this.DtgPagoServicio.Name = "DtgPagoServicio";
            this.DtgPagoServicio.Size = new System.Drawing.Size(775, 365);
            this.DtgPagoServicio.TabIndex = 2;
            // 
            // DtmFin
            // 
            this.DtmFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtmFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtmFin.Location = new System.Drawing.Point(157, 44);
            this.DtmFin.Name = "DtmFin";
            this.DtmFin.Size = new System.Drawing.Size(149, 26);
            this.DtmFin.TabIndex = 11;
            // 
            // DtmInicio
            // 
            this.DtmInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtmInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtmInicio.Location = new System.Drawing.Point(157, 12);
            this.DtmInicio.Name = "DtmInicio";
            this.DtmInicio.Size = new System.Drawing.Size(149, 26);
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
            this.BtnBuscar.Location = new System.Drawing.Point(552, 12);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(235, 32);
            this.BtnBuscar.TabIndex = 7;
            this.BtnBuscar.Text = "Buscar Pagos de servicio";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // IdPagoServicio
            // 
            this.IdPagoServicio.HeaderText = "IdPagoServicio";
            this.IdPagoServicio.Name = "IdPagoServicio";
            // 
            // Codigo_Servicio
            // 
            this.Codigo_Servicio.HeaderText = "Codigo Servicio";
            this.Codigo_Servicio.Name = "Codigo_Servicio";
            // 
            // Nombre_Servicio
            // 
            this.Nombre_Servicio.HeaderText = "Nombre_Servicio";
            this.Nombre_Servicio.Name = "Nombre_Servicio";
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
            // FmrListarPagoServicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 501);
            this.Controls.Add(this.DtmFin);
            this.Controls.Add(this.DtmInicio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.BtnSeleccionarPagoServicio);
            this.Controls.Add(this.DtgPagoServicio);
            this.Name = "FmrListarPagoServicio";
            this.Text = "FmrListarPagoServicio";
            this.Load += new System.EventHandler(this.FmrListarPagoServicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtgPagoServicio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSeleccionarPagoServicio;
        private System.Windows.Forms.DataGridView DtgPagoServicio;
        private System.Windows.Forms.DateTimePicker DtmFin;
        private System.Windows.Forms.DateTimePicker DtmInicio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPagoServicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo_Servicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Servicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto_pagado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_de_pago;
    }
}