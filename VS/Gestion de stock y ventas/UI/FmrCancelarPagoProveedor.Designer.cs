using SL.Services.Extensions;

namespace UI
{
    partial class FmrCancelarPagoProveedor
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
            this.DtgOrdenDeCompra = new System.Windows.Forms.DataGridView();
            this.IdOrdenDeCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_Materia_Prima = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnBuscarPagoProveedor = new System.Windows.Forms.Button();
            this.BtnCancelarPago = new System.Windows.Forms.Button();
            this.TxtDeudaAnterior = new System.Windows.Forms.TextBox();
            this.TxtTotalApagar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtSubtotal = new System.Windows.Forms.TextBox();
            this.TxtPagado = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtProveedor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DtmfechaDePago = new System.Windows.Forms.DateTimePicker();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.DtgOrdenDeCompra)).BeginInit();
            this.SuspendLayout();
            // 
            // DtgOrdenDeCompra
            // 
            this.DtgOrdenDeCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgOrdenDeCompra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdOrdenDeCompra,
            this.Nombre_Materia_Prima,
            this.Cantidad,
            this.SubTotal});
            this.DtgOrdenDeCompra.Location = new System.Drawing.Point(570, 12);
            this.DtgOrdenDeCompra.Name = "DtgOrdenDeCompra";
            this.DtgOrdenDeCompra.Size = new System.Drawing.Size(445, 361);
            this.DtgOrdenDeCompra.TabIndex = 0;
            // 
            // IdOrdenDeCompra
            // 
            this.IdOrdenDeCompra.Name = "IdOrdenDeCompra";
            // 
            // Nombre_Materia_Prima
            // 
            this.Nombre_Materia_Prima.Name = "Nombre_Materia_Prima";
            // 
            // Cantidad
            // 
            this.Cantidad.Name = "Cantidad";
            // 
            // SubTotal
            // 
            this.SubTotal.Name = "SubTotal";
            // 
            // BtnBuscarPagoProveedor
            // 
            this.BtnBuscarPagoProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscarPagoProveedor.Location = new System.Drawing.Point(12, 12);
            this.BtnBuscarPagoProveedor.Name = "BtnBuscarPagoProveedor";
            this.BtnBuscarPagoProveedor.Size = new System.Drawing.Size(257, 28);
            this.BtnBuscarPagoProveedor.TabIndex = 1;
            this.BtnBuscarPagoProveedor.Text = "Buscar Pago Proveedor";
            this.BtnBuscarPagoProveedor.UseVisualStyleBackColor = true;
            this.BtnBuscarPagoProveedor.Click += new System.EventHandler(this.BtnBuscarPagoProveedor_Click);
            // 
            // BtnCancelarPago
            // 
            this.BtnCancelarPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelarPago.Location = new System.Drawing.Point(148, 338);
            this.BtnCancelarPago.Name = "BtnCancelarPago";
            this.BtnCancelarPago.Size = new System.Drawing.Size(249, 35);
            this.BtnCancelarPago.TabIndex = 39;
            this.BtnCancelarPago.Text = "Cancelar Pago";
            this.BtnCancelarPago.UseVisualStyleBackColor = true;
            this.BtnCancelarPago.Click += new System.EventHandler(this.BtnCancelarPago_Click);
            // 
            // TxtDeudaAnterior
            // 
            this.TxtDeudaAnterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDeudaAnterior.Location = new System.Drawing.Point(229, 134);
            this.TxtDeudaAnterior.Name = "TxtDeudaAnterior";
            this.TxtDeudaAnterior.Size = new System.Drawing.Size(225, 26);
            this.TxtDeudaAnterior.TabIndex = 38;
            // 
            // TxtTotalApagar
            // 
            this.TxtTotalApagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTotalApagar.Location = new System.Drawing.Point(229, 166);
            this.TxtTotalApagar.Name = "TxtTotalApagar";
            this.TxtTotalApagar.Size = new System.Drawing.Size(225, 26);
            this.TxtTotalApagar.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(57, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 20);
            this.label6.TabIndex = 36;
            this.label6.Text = "Monto Total a pagar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(81, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 20);
            this.label5.TabIndex = 35;
            this.label5.Text = "Monto Adeudado";
            // 
            // TxtSubtotal
            // 
            this.TxtSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSubtotal.Location = new System.Drawing.Point(229, 102);
            this.TxtSubtotal.Name = "TxtSubtotal";
            this.TxtSubtotal.Size = new System.Drawing.Size(225, 26);
            this.TxtSubtotal.TabIndex = 33;
            // 
            // TxtPagado
            // 
            this.TxtPagado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPagado.Location = new System.Drawing.Point(229, 198);
            this.TxtPagado.Name = "TxtPagado";
            this.TxtPagado.Size = new System.Drawing.Size(225, 26);
            this.TxtPagado.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(102, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 20);
            this.label4.TabIndex = 31;
            this.label4.Text = "Monto Pagado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(144, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 30;
            this.label3.Text = "SubTotal";
            // 
            // TxtProveedor
            // 
            this.TxtProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtProveedor.Location = new System.Drawing.Point(229, 70);
            this.TxtProveedor.Name = "TxtProveedor";
            this.TxtProveedor.Size = new System.Drawing.Size(225, 26);
            this.TxtProveedor.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(137, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 40;
            this.label1.Text = "Proveedor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 20);
            this.label2.TabIndex = 41;
            this.label2.Text = "Fecha de Pago Realizado";
            // 
            // DtmfechaDePago
            // 
            this.DtmfechaDePago.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtmfechaDePago.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtmfechaDePago.Location = new System.Drawing.Point(229, 229);
            this.DtmfechaDePago.Name = "DtmfechaDePago";
            this.DtmfechaDePago.Size = new System.Drawing.Size(225, 26);
            this.DtmfechaDePago.TabIndex = 42;
            // 
            // FmrCancelarPagoProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 409);
            this.Controls.Add(this.DtmfechaDePago);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnCancelarPago);
            this.Controls.Add(this.TxtDeudaAnterior);
            this.Controls.Add(this.TxtTotalApagar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtSubtotal);
            this.Controls.Add(this.TxtPagado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtProveedor);
            this.Controls.Add(this.BtnBuscarPagoProveedor);
            this.Controls.Add(this.DtgOrdenDeCompra);
            this.Name = "FmrCancelarPagoProveedor";
            this.Text = "FmrCancelarPagoProveedor";
            this.Load += new System.EventHandler(this.FmrCancelarPagoProveedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtgOrdenDeCompra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DtgOrdenDeCompra;
        private System.Windows.Forms.Button BtnBuscarPagoProveedor;
        private System.Windows.Forms.Button BtnCancelarPago;
        private System.Windows.Forms.TextBox TxtDeudaAnterior;
        private System.Windows.Forms.TextBox TxtTotalApagar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtSubtotal;
        private System.Windows.Forms.TextBox TxtPagado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtProveedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdOrdenDeCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Materia_Prima;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.DateTimePicker DtmfechaDePago;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}