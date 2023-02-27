using SL.Services.Extensions;

namespace UI
{
    partial class FmrCancelarVenta
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnSeleccionarVenta = new System.Windows.Forms.Button();
            this.TxtCodigoVenta = new System.Windows.Forms.TextBox();
            this.TxtCliente = new System.Windows.Forms.TextBox();
            this.TxtFechadeVenta = new System.Windows.Forms.TextBox();
            this.TxtPrecio = new System.Windows.Forms.TextBox();
            this.BtnCancelarVenta = new System.Windows.Forms.Button();
            this.DtgVenta = new System.Windows.Forms.DataGridView();
            this.IdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.DtgVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo de Venta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(103, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha de venta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(109, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Precio";
            // 
            // BtnSeleccionarVenta
            // 
            this.BtnSeleccionarVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSeleccionarVenta.Location = new System.Drawing.Point(12, 12);
            this.BtnSeleccionarVenta.Name = "BtnSeleccionarVenta";
            this.BtnSeleccionarVenta.Size = new System.Drawing.Size(381, 33);
            this.BtnSeleccionarVenta.TabIndex = 4;
            this.BtnSeleccionarVenta.Text = "Seleccionar Venta";
            this.BtnSeleccionarVenta.UseVisualStyleBackColor = true;
            this.BtnSeleccionarVenta.Click += new System.EventHandler(this.BtnSeleccionarVenta_Click);
            // 
            // TxtCodigoVenta
            // 
            this.TxtCodigoVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodigoVenta.Location = new System.Drawing.Point(174, 68);
            this.TxtCodigoVenta.Name = "TxtCodigoVenta";
            this.TxtCodigoVenta.Size = new System.Drawing.Size(219, 26);
            this.TxtCodigoVenta.TabIndex = 5;
            // 
            // TxtCliente
            // 
            this.TxtCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCliente.Location = new System.Drawing.Point(174, 111);
            this.TxtCliente.Name = "TxtCliente";
            this.TxtCliente.Size = new System.Drawing.Size(219, 26);
            this.TxtCliente.TabIndex = 6;
            // 
            // TxtFechadeVenta
            // 
            this.TxtFechadeVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFechadeVenta.Location = new System.Drawing.Point(174, 152);
            this.TxtFechadeVenta.Name = "TxtFechadeVenta";
            this.TxtFechadeVenta.Size = new System.Drawing.Size(219, 26);
            this.TxtFechadeVenta.TabIndex = 7;
            // 
            // TxtPrecio
            // 
            this.TxtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPrecio.Location = new System.Drawing.Point(174, 188);
            this.TxtPrecio.Name = "TxtPrecio";
            this.TxtPrecio.Size = new System.Drawing.Size(219, 26);
            this.TxtPrecio.TabIndex = 8;
            // 
            // BtnCancelarVenta
            // 
            this.BtnCancelarVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelarVenta.Location = new System.Drawing.Point(12, 288);
            this.BtnCancelarVenta.Name = "BtnCancelarVenta";
            this.BtnCancelarVenta.Size = new System.Drawing.Size(381, 33);
            this.BtnCancelarVenta.TabIndex = 9;
            this.BtnCancelarVenta.Text = "Cancelar Venta";
            this.BtnCancelarVenta.UseVisualStyleBackColor = true;
            this.BtnCancelarVenta.Click += new System.EventHandler(this.BtnCancelarVenta_Click);
            // 
            // DtgVenta
            // 
            this.DtgVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProducto,
            this.Nombre_Producto,
            this.Cantidad,
            this.Subtotal});
            this.DtgVenta.Location = new System.Drawing.Point(399, 12);
            this.DtgVenta.Name = "DtgVenta";
            this.DtgVenta.Size = new System.Drawing.Size(443, 320);
            this.DtgVenta.TabIndex = 10;
            // 
            // IdProducto
            // 
            this.IdProducto.Name = "IdProducto";
            // 
            // Nombre_Producto
            // 
            this.Nombre_Producto.Name = "Nombre_Producto";
            // 
            // Cantidad
            // 
            this.Cantidad.Name = "Cantidad";
            // 
            // Subtotal
            // 
            this.Subtotal.Name = "Subtotal";
            // 
            // FmrCancelarVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 344);
            this.Controls.Add(this.DtgVenta);
            this.Controls.Add(this.BtnCancelarVenta);
            this.Controls.Add(this.TxtPrecio);
            this.Controls.Add(this.TxtFechadeVenta);
            this.Controls.Add(this.TxtCliente);
            this.Controls.Add(this.TxtCodigoVenta);
            this.Controls.Add(this.BtnSeleccionarVenta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FmrCancelarVenta";
            this.Text = "FmrCancelarVenta";
            this.Load += new System.EventHandler(this.FmrCancelarVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtgVenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnSeleccionarVenta;
        private System.Windows.Forms.TextBox TxtCodigoVenta;
        private System.Windows.Forms.TextBox TxtCliente;
        private System.Windows.Forms.TextBox TxtFechadeVenta;
        private System.Windows.Forms.TextBox TxtPrecio;
        private System.Windows.Forms.Button BtnCancelarVenta;
        private System.Windows.Forms.DataGridView DtgVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}