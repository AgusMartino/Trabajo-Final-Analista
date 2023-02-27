using SL.Services.Extensions;

namespace UI
{
    partial class FmrRealizarVenta
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
            this.BtnRealizarVenta = new System.Windows.Forms.Button();
            this.BtnSeleccionarCliente = new System.Windows.Forms.Button();
            this.BtnSeleccionarProducto = new System.Windows.Forms.Button();
            this.TxtCliente = new System.Windows.Forms.TextBox();
            this.TxtProducto = new System.Windows.Forms.TextBox();
            this.TxtCantidad = new System.Windows.Forms.TextBox();
            this.TxtTotal = new System.Windows.Forms.TextBox();
            this.CmbMetodoPago = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DtgOrdenVenta = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnAgregarProducto = new System.Windows.Forms.Button();
            this.BtnRemoverproducto = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.Codigo_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DtgOrdenVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnRealizarVenta
            // 
            this.BtnRealizarVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRealizarVenta.Location = new System.Drawing.Point(218, 289);
            this.BtnRealizarVenta.Name = "BtnRealizarVenta";
            this.BtnRealizarVenta.Size = new System.Drawing.Size(163, 52);
            this.BtnRealizarVenta.TabIndex = 1;
            this.BtnRealizarVenta.Text = "Realizar Venta";
            this.BtnRealizarVenta.UseVisualStyleBackColor = true;
            this.BtnRealizarVenta.Click += new System.EventHandler(this.BtnRealizarVenta_Click);
            // 
            // BtnSeleccionarCliente
            // 
            this.BtnSeleccionarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSeleccionarCliente.Location = new System.Drawing.Point(12, 12);
            this.BtnSeleccionarCliente.Name = "BtnSeleccionarCliente";
            this.BtnSeleccionarCliente.Size = new System.Drawing.Size(192, 26);
            this.BtnSeleccionarCliente.TabIndex = 2;
            this.BtnSeleccionarCliente.Text = "Seleccionar Cliente";
            this.BtnSeleccionarCliente.UseVisualStyleBackColor = true;
            this.BtnSeleccionarCliente.Click += new System.EventHandler(this.BtnSeleccionarCliente_Click);
            // 
            // BtnSeleccionarProducto
            // 
            this.BtnSeleccionarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSeleccionarProducto.Location = new System.Drawing.Point(12, 44);
            this.BtnSeleccionarProducto.Name = "BtnSeleccionarProducto";
            this.BtnSeleccionarProducto.Size = new System.Drawing.Size(192, 26);
            this.BtnSeleccionarProducto.TabIndex = 3;
            this.BtnSeleccionarProducto.Text = "Seleccionar Producto";
            this.BtnSeleccionarProducto.UseVisualStyleBackColor = true;
            this.BtnSeleccionarProducto.Click += new System.EventHandler(this.BtnSeleccionarProducto_Click);
            // 
            // TxtCliente
            // 
            this.TxtCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCliente.Location = new System.Drawing.Point(210, 12);
            this.TxtCliente.Name = "TxtCliente";
            this.TxtCliente.Size = new System.Drawing.Size(307, 26);
            this.TxtCliente.TabIndex = 4;
            // 
            // TxtProducto
            // 
            this.TxtProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtProducto.Location = new System.Drawing.Point(210, 44);
            this.TxtProducto.Name = "TxtProducto";
            this.TxtProducto.Size = new System.Drawing.Size(307, 26);
            this.TxtProducto.TabIndex = 5;
            // 
            // TxtCantidad
            // 
            this.TxtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCantidad.Location = new System.Drawing.Point(210, 76);
            this.TxtCantidad.Name = "TxtCantidad";
            this.TxtCantidad.Size = new System.Drawing.Size(171, 26);
            this.TxtCantidad.TabIndex = 6;
            // 
            // TxtTotal
            // 
            this.TxtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTotal.Location = new System.Drawing.Point(255, 246);
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.Size = new System.Drawing.Size(126, 26);
            this.TxtTotal.TabIndex = 8;
            // 
            // CmbMetodoPago
            // 
            this.CmbMetodoPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbMetodoPago.FormattingEnabled = true;
            this.CmbMetodoPago.Location = new System.Drawing.Point(195, 212);
            this.CmbMetodoPago.Name = "CmbMetodoPago";
            this.CmbMetodoPago.Size = new System.Drawing.Size(307, 28);
            this.CmbMetodoPago.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Metodo de Pago";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(146, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Precio Final";
            // 
            // DtgOrdenVenta
            // 
            this.DtgOrdenVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgOrdenVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo_producto,
            this.Nombre_Producto,
            this.Cantidad_producto,
            this.Subtotal});
            this.DtgOrdenVenta.Location = new System.Drawing.Point(561, 12);
            this.DtgOrdenVenta.Name = "DtgOrdenVenta";
            this.DtgOrdenVenta.Size = new System.Drawing.Size(443, 297);
            this.DtgOrdenVenta.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(123, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Cantidad";
            // 
            // BtnAgregarProducto
            // 
            this.BtnAgregarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregarProducto.Location = new System.Drawing.Point(127, 108);
            this.BtnAgregarProducto.Name = "BtnAgregarProducto";
            this.BtnAgregarProducto.Size = new System.Drawing.Size(319, 29);
            this.BtnAgregarProducto.TabIndex = 15;
            this.BtnAgregarProducto.Text = "Agregar Producto a lista de Compra";
            this.BtnAgregarProducto.UseVisualStyleBackColor = true;
            this.BtnAgregarProducto.Click += new System.EventHandler(this.BtnAgregarProducto_Click);
            // 
            // BtnRemoverproducto
            // 
            this.BtnRemoverproducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRemoverproducto.Location = new System.Drawing.Point(127, 160);
            this.BtnRemoverproducto.Name = "BtnRemoverproducto";
            this.BtnRemoverproducto.Size = new System.Drawing.Size(319, 29);
            this.BtnRemoverproducto.TabIndex = 16;
            this.BtnRemoverproducto.Text = "Remover Producto a lista de Compra";
            this.BtnRemoverproducto.UseVisualStyleBackColor = true;
            this.BtnRemoverproducto.Click += new System.EventHandler(this.BtnRemoverproducto_Click);
            // 
            // Codigo_producto
            // 
            this.Codigo_producto.HeaderText = "Codigo Producto";
            this.Codigo_producto.Name = "Codigo_producto";
            // 
            // Nombre_Producto
            // 
            this.Nombre_Producto.HeaderText = "Nombre_Producto";
            this.Nombre_Producto.Name = "Nombre_Producto";
            // 
            // Cantidad_producto
            // 
            this.Cantidad_producto.HeaderText = "Cantidad_producto";
            this.Cantidad_producto.Name = "Cantidad_producto";
            // 
            // Subtotal
            // 
            this.Subtotal.HeaderText = "Subtotal";
            this.Subtotal.Name = "Subtotal";
            // 
            // FmrRealizarVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 353);
            this.Controls.Add(this.BtnRemoverproducto);
            this.Controls.Add(this.BtnAgregarProducto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DtgOrdenVenta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CmbMetodoPago);
            this.Controls.Add(this.TxtTotal);
            this.Controls.Add(this.TxtCantidad);
            this.Controls.Add(this.TxtProducto);
            this.Controls.Add(this.TxtCliente);
            this.Controls.Add(this.BtnSeleccionarProducto);
            this.Controls.Add(this.BtnSeleccionarCliente);
            this.Controls.Add(this.BtnRealizarVenta);
            this.Name = "FmrRealizarVenta";
            this.Text = "FmrRealizarVenta";
            this.Load += new System.EventHandler(this.FmrRealizarVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtgOrdenVenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnRealizarVenta;
        private System.Windows.Forms.Button BtnSeleccionarCliente;
        private System.Windows.Forms.Button BtnSeleccionarProducto;
        private System.Windows.Forms.TextBox TxtCliente;
        private System.Windows.Forms.TextBox TxtProducto;
        private System.Windows.Forms.TextBox TxtCantidad;
        private System.Windows.Forms.TextBox TxtTotal;
        private System.Windows.Forms.ComboBox CmbMetodoPago;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DtgOrdenVenta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnAgregarProducto;
        private System.Windows.Forms.Button BtnRemoverproducto;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
    }
}