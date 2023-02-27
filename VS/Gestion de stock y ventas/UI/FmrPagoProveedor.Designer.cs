using SL.Services.Extensions;

namespace UI
{
    partial class FmrPagoProveedor
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
            this.BtnSeleccionarProveedor = new System.Windows.Forms.Button();
            this.TxtProveedor = new System.Windows.Forms.TextBox();
            this.BtnSeleccionarMateriaPrima = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtCantidad = new System.Windows.Forms.TextBox();
            this.TxtCostoMateriaPrima = new System.Windows.Forms.TextBox();
            this.DtgMateriaPrima = new System.Windows.Forms.DataGridView();
            this.CodigoMateriaPrima = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreMateriaPrima = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadMateriaPrima = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnidadDeMedida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostoMateriaPrima = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtPagado = new System.Windows.Forms.TextBox();
            this.TxtSubtotal = new System.Windows.Forms.TextBox();
            this.BtnAgregarMateriaPrima = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtTotalApagar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtDeudaAnterior = new System.Windows.Forms.TextBox();
            this.BtnRealizarPago = new System.Windows.Forms.Button();
            this.TxtMateriaPrima = new System.Windows.Forms.TextBox();
            this.BtnRemoverDeOrdenDeCompra = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.DtgMateriaPrima)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnSeleccionarProveedor
            // 
            this.BtnSeleccionarProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSeleccionarProveedor.Location = new System.Drawing.Point(12, 20);
            this.BtnSeleccionarProveedor.Name = "BtnSeleccionarProveedor";
            this.BtnSeleccionarProveedor.Size = new System.Drawing.Size(227, 35);
            this.BtnSeleccionarProveedor.TabIndex = 0;
            this.BtnSeleccionarProveedor.Text = "Seleccionar Proveedor";
            this.BtnSeleccionarProveedor.UseVisualStyleBackColor = true;
            this.BtnSeleccionarProveedor.Click += new System.EventHandler(this.BtnSeleccionarProveedor_Click);
            // 
            // TxtProveedor
            // 
            this.TxtProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtProveedor.Location = new System.Drawing.Point(254, 24);
            this.TxtProveedor.Name = "TxtProveedor";
            this.TxtProveedor.Size = new System.Drawing.Size(225, 26);
            this.TxtProveedor.TabIndex = 1;
            // 
            // BtnSeleccionarMateriaPrima
            // 
            this.BtnSeleccionarMateriaPrima.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSeleccionarMateriaPrima.Location = new System.Drawing.Point(12, 61);
            this.BtnSeleccionarMateriaPrima.Name = "BtnSeleccionarMateriaPrima";
            this.BtnSeleccionarMateriaPrima.Size = new System.Drawing.Size(227, 30);
            this.BtnSeleccionarMateriaPrima.TabIndex = 2;
            this.BtnSeleccionarMateriaPrima.Text = "Seleccionar Materia Prima";
            this.BtnSeleccionarMateriaPrima.UseVisualStyleBackColor = true;
            this.BtnSeleccionarMateriaPrima.Click += new System.EventHandler(this.BtnSeleccionarMateriaPrima_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cantidad Materia Prima";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Costo Materia Prima";
            // 
            // TxtCantidad
            // 
            this.TxtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCantidad.Location = new System.Drawing.Point(254, 98);
            this.TxtCantidad.Name = "TxtCantidad";
            this.TxtCantidad.Size = new System.Drawing.Size(100, 26);
            this.TxtCantidad.TabIndex = 6;
            // 
            // TxtCostoMateriaPrima
            // 
            this.TxtCostoMateriaPrima.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCostoMateriaPrima.Location = new System.Drawing.Point(254, 133);
            this.TxtCostoMateriaPrima.Name = "TxtCostoMateriaPrima";
            this.TxtCostoMateriaPrima.Size = new System.Drawing.Size(100, 26);
            this.TxtCostoMateriaPrima.TabIndex = 7;
            // 
            // DtgMateriaPrima
            // 
            this.DtgMateriaPrima.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgMateriaPrima.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoMateriaPrima,
            this.NombreMateriaPrima,
            this.CantidadMateriaPrima,
            this.UnidadDeMedida,
            this.CostoMateriaPrima});
            this.DtgMateriaPrima.Location = new System.Drawing.Point(550, 12);
            this.DtgMateriaPrima.Name = "DtgMateriaPrima";
            this.DtgMateriaPrima.Size = new System.Drawing.Size(564, 465);
            this.DtgMateriaPrima.TabIndex = 8;
            // 
            // CodigoMateriaPrima
            // 
            this.CodigoMateriaPrima.Name = "CodigoMateriaPrima";
            // 
            // NombreMateriaPrima
            // 
            this.NombreMateriaPrima.Name = "NombreMateriaPrima";
            // 
            // CantidadMateriaPrima
            // 
            this.CantidadMateriaPrima.Name = "CantidadMateriaPrima";
            // 
            // UnidadDeMedida
            // 
            this.UnidadDeMedida.Name = "UnidadDeMedida";
            // 
            // CostoMateriaPrima
            // 
            this.CostoMateriaPrima.Name = "CostoMateriaPrima";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(92, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "SubTotal a pagar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(114, 403);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Monto Pagado";
            // 
            // TxtPagado
            // 
            this.TxtPagado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPagado.Location = new System.Drawing.Point(254, 400);
            this.TxtPagado.Name = "TxtPagado";
            this.TxtPagado.Size = new System.Drawing.Size(100, 26);
            this.TxtPagado.TabIndex = 11;
            // 
            // TxtSubtotal
            // 
            this.TxtSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSubtotal.Location = new System.Drawing.Point(254, 272);
            this.TxtSubtotal.Name = "TxtSubtotal";
            this.TxtSubtotal.Size = new System.Drawing.Size(100, 26);
            this.TxtSubtotal.TabIndex = 12;
            // 
            // BtnAgregarMateriaPrima
            // 
            this.BtnAgregarMateriaPrima.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregarMateriaPrima.Location = new System.Drawing.Point(96, 178);
            this.BtnAgregarMateriaPrima.Name = "BtnAgregarMateriaPrima";
            this.BtnAgregarMateriaPrima.Size = new System.Drawing.Size(356, 35);
            this.BtnAgregarMateriaPrima.TabIndex = 15;
            this.BtnAgregarMateriaPrima.Text = "Agregar Materia Prima a orden de compra";
            this.BtnAgregarMateriaPrima.UseVisualStyleBackColor = true;
            this.BtnAgregarMateriaPrima.Click += new System.EventHandler(this.BtnAgregarMateriaPrima_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(93, 317);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Monto Adeudado";
            // 
            // TxtTotalApagar
            // 
            this.TxtTotalApagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTotalApagar.Location = new System.Drawing.Point(254, 358);
            this.TxtTotalApagar.Name = "TxtTotalApagar";
            this.TxtTotalApagar.Size = new System.Drawing.Size(100, 26);
            this.TxtTotalApagar.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(69, 361);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Monto Total a pagar";
            // 
            // TxtDeudaAnterior
            // 
            this.TxtDeudaAnterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDeudaAnterior.Location = new System.Drawing.Point(254, 314);
            this.TxtDeudaAnterior.Name = "TxtDeudaAnterior";
            this.TxtDeudaAnterior.Size = new System.Drawing.Size(100, 26);
            this.TxtDeudaAnterior.TabIndex = 19;
            // 
            // BtnRealizarPago
            // 
            this.BtnRealizarPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRealizarPago.Location = new System.Drawing.Point(142, 442);
            this.BtnRealizarPago.Name = "BtnRealizarPago";
            this.BtnRealizarPago.Size = new System.Drawing.Size(249, 35);
            this.BtnRealizarPago.TabIndex = 20;
            this.BtnRealizarPago.Text = "Realizar Pago";
            this.BtnRealizarPago.UseVisualStyleBackColor = true;
            this.BtnRealizarPago.Click += new System.EventHandler(this.BtnRealizarPago_Click);
            // 
            // TxtMateriaPrima
            // 
            this.TxtMateriaPrima.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMateriaPrima.Location = new System.Drawing.Point(254, 63);
            this.TxtMateriaPrima.Name = "TxtMateriaPrima";
            this.TxtMateriaPrima.Size = new System.Drawing.Size(225, 26);
            this.TxtMateriaPrima.TabIndex = 3;
            // 
            // BtnRemoverDeOrdenDeCompra
            // 
            this.BtnRemoverDeOrdenDeCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRemoverDeOrdenDeCompra.Location = new System.Drawing.Point(73, 219);
            this.BtnRemoverDeOrdenDeCompra.Name = "BtnRemoverDeOrdenDeCompra";
            this.BtnRemoverDeOrdenDeCompra.Size = new System.Drawing.Size(395, 35);
            this.BtnRemoverDeOrdenDeCompra.TabIndex = 21;
            this.BtnRemoverDeOrdenDeCompra.Text = "Remover Materia Prima de Orden de compra";
            this.BtnRemoverDeOrdenDeCompra.UseVisualStyleBackColor = true;
            this.BtnRemoverDeOrdenDeCompra.Click += new System.EventHandler(this.BtnRemoverDeOrdenDeCompra_Click);
            // 
            // FmrPagoProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 487);
            this.Controls.Add(this.BtnRemoverDeOrdenDeCompra);
            this.Controls.Add(this.BtnRealizarPago);
            this.Controls.Add(this.TxtDeudaAnterior);
            this.Controls.Add(this.TxtTotalApagar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BtnAgregarMateriaPrima);
            this.Controls.Add(this.TxtSubtotal);
            this.Controls.Add(this.TxtPagado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DtgMateriaPrima);
            this.Controls.Add(this.TxtCostoMateriaPrima);
            this.Controls.Add(this.TxtCantidad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtMateriaPrima);
            this.Controls.Add(this.BtnSeleccionarMateriaPrima);
            this.Controls.Add(this.TxtProveedor);
            this.Controls.Add(this.BtnSeleccionarProveedor);
            this.Name = "FmrPagoProveedor";
            this.Text = "FmrPagoProveedor";
            this.Load += new System.EventHandler(this.FmrPagoProveedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtgMateriaPrima)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSeleccionarProveedor;
        private System.Windows.Forms.TextBox TxtProveedor;
        private System.Windows.Forms.Button BtnSeleccionarMateriaPrima;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtCantidad;
        private System.Windows.Forms.TextBox TxtCostoMateriaPrima;
        private System.Windows.Forms.DataGridView DtgMateriaPrima;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtPagado;
        private System.Windows.Forms.TextBox TxtSubtotal;
        private System.Windows.Forms.Button BtnAgregarMateriaPrima;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtTotalApagar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtDeudaAnterior;
        private System.Windows.Forms.Button BtnRealizarPago;
        private System.Windows.Forms.TextBox TxtMateriaPrima;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoMateriaPrima;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreMateriaPrima;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadMateriaPrima;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnidadDeMedida;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostoMateriaPrima;
        private System.Windows.Forms.Button BtnRemoverDeOrdenDeCompra;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}