using SL.Services.Extensions;

namespace UI
{
    partial class FmrListarProducto
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
            this.DtgProductos = new System.Windows.Forms.DataGridView();
            this.BtnSeleccionarProducto = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.Rubro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo_Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DtgProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // DtgProductos
            // 
            this.DtgProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Rubro,
            this.Codigo_Producto,
            this.Nombre,
            this.Precio,
            this.Costo});
            this.DtgProductos.Location = new System.Drawing.Point(13, 13);
            this.DtgProductos.Name = "DtgProductos";
            this.DtgProductos.Size = new System.Drawing.Size(872, 309);
            this.DtgProductos.TabIndex = 0;
            // 
            // BtnSeleccionarProducto
            // 
            this.BtnSeleccionarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSeleccionarProducto.Location = new System.Drawing.Point(13, 346);
            this.BtnSeleccionarProducto.Name = "BtnSeleccionarProducto";
            this.BtnSeleccionarProducto.Size = new System.Drawing.Size(254, 43);
            this.BtnSeleccionarProducto.TabIndex = 1;
            this.BtnSeleccionarProducto.Text = "Seleccionar Producto";
            this.BtnSeleccionarProducto.UseVisualStyleBackColor = true;
            this.BtnSeleccionarProducto.Click += new System.EventHandler(this.BtnSeleccionarProducto_Click);
            // 
            // Rubro
            // 
            this.Rubro.HeaderText = "Rubro";
            this.Rubro.Name = "Rubro";
            // 
            // Codigo_Producto
            // 
            this.Codigo_Producto.HeaderText = "Codigo_Producto";
            this.Codigo_Producto.Name = "Codigo_Producto";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            // 
            // Costo
            // 
            this.Costo.HeaderText = "Costo";
            this.Costo.Name = "Costo";
            // 
            // FmrListarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 415);
            this.Controls.Add(this.BtnSeleccionarProducto);
            this.Controls.Add(this.DtgProductos);
            this.Name = "FmrListarProducto";
            this.Text = "FmrListarProducto";
            this.Load += new System.EventHandler(this.FmrListarProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtgProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DtgProductos;
        private System.Windows.Forms.Button BtnSeleccionarProducto;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rubro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo_Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Costo;
    }
}