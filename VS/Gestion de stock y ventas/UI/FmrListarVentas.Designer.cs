using SL.Services.Extensions;

namespace UI
{
    partial class FmrListarVentas
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
            this.DtgVentas = new System.Windows.Forms.DataGridView();
            this.BtnSeleccionarVenta = new System.Windows.Forms.Button();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DtmInicio = new System.Windows.Forms.DateTimePicker();
            this.DtmFin = new System.Windows.Forms.DateTimePicker();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.IdVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dni_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo_de_pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreTipo_de_pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_de_venta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DtgVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // DtgVentas
            // 
            this.DtgVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdVenta,
            this.Dni_cliente,
            this.Tipo_de_pago,
            this.NombreTipo_de_pago,
            this.Fecha_de_venta,
            this.Total});
            this.DtgVentas.Location = new System.Drawing.Point(12, 89);
            this.DtgVentas.Name = "DtgVentas";
            this.DtgVentas.Size = new System.Drawing.Size(776, 308);
            this.DtgVentas.TabIndex = 0;
            // 
            // BtnSeleccionarVenta
            // 
            this.BtnSeleccionarVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSeleccionarVenta.Location = new System.Drawing.Point(12, 403);
            this.BtnSeleccionarVenta.Name = "BtnSeleccionarVenta";
            this.BtnSeleccionarVenta.Size = new System.Drawing.Size(224, 34);
            this.BtnSeleccionarVenta.TabIndex = 1;
            this.BtnSeleccionarVenta.Text = "Seleccionar Venta";
            this.BtnSeleccionarVenta.UseVisualStyleBackColor = true;
            this.BtnSeleccionarVenta.Click += new System.EventHandler(this.BtnSeleccionarVenta_Click);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar.Location = new System.Drawing.Point(553, 6);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(235, 32);
            this.BtnBuscar.TabIndex = 2;
            this.BtnBuscar.Text = "Buscar Ventas";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Fecha de Inicio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fecha de Fin";
            // 
            // DtmInicio
            // 
            this.DtmInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtmInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtmInicio.Location = new System.Drawing.Point(158, 6);
            this.DtmInicio.Name = "DtmInicio";
            this.DtmInicio.Size = new System.Drawing.Size(148, 26);
            this.DtmInicio.TabIndex = 5;
            // 
            // DtmFin
            // 
            this.DtmFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtmFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtmFin.Location = new System.Drawing.Point(158, 38);
            this.DtmFin.Name = "DtmFin";
            this.DtmFin.Size = new System.Drawing.Size(148, 26);
            this.DtmFin.TabIndex = 6;
            // 
            // IdVenta
            // 
            this.IdVenta.HeaderText = "IdVenta";
            this.IdVenta.Name = "IdVenta";
            // 
            // Dni_cliente
            // 
            this.Dni_cliente.HeaderText = "Dni Cliente";
            this.Dni_cliente.Name = "Dni_cliente";
            // 
            // Tipo_de_pago
            // 
            this.Tipo_de_pago.HeaderText = "Tipo_de_pago";
            this.Tipo_de_pago.Name = "Tipo_de_pago";
            // 
            // NombreTipo_de_pago
            // 
            this.NombreTipo_de_pago.HeaderText = "NombreTipo_de_pago";
            this.NombreTipo_de_pago.Name = "NombreTipo_de_pago";
            // 
            // Fecha_de_venta
            // 
            this.Fecha_de_venta.HeaderText = "Fecha_de_venta";
            this.Fecha_de_venta.Name = "Fecha_de_venta";
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            // 
            // FmrListarVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 449);
            this.Controls.Add(this.DtmFin);
            this.Controls.Add(this.DtmInicio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.BtnSeleccionarVenta);
            this.Controls.Add(this.DtgVentas);
            this.Name = "FmrListarVentas";
            this.Text = "FmrListarVentas";
            this.Load += new System.EventHandler(this.FmrListarVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtgVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DtgVentas;
        private System.Windows.Forms.Button BtnSeleccionarVenta;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DtmInicio;
        private System.Windows.Forms.DateTimePicker DtmFin;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dni_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo_de_pago;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreTipo_de_pago;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_de_venta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
    }
}