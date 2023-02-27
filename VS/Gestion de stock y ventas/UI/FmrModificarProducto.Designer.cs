using SL.Services.Extensions;

namespace UI
{
    partial class FmrModificarProducto
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnRemoverComponente = new System.Windows.Forms.Button();
            this.BtnAgregarComponente = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.DtgComponente = new System.Windows.Forms.DataGridView();
            this.Codigo_MateriaPrima = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_componente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad_componente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnidadDeMedida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtNombreMateriaPrima = new System.Windows.Forms.TextBox();
            this.TxtCantidad = new System.Windows.Forms.TextBox();
            this.BtnSeleccionarMateriaPrima = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtRubro = new System.Windows.Forms.TextBox();
            this.BtnSeleccionarRubro = new System.Windows.Forms.Button();
            this.BtnModificarProducto = new System.Windows.Forms.Button();
            this.TxtPrecio = new System.Windows.Forms.TextBox();
            this.TxtCodigoProducto = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnSeleccionarProducto = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgComponente)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnRemoverComponente);
            this.groupBox2.Controls.Add(this.BtnAgregarComponente);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.DtgComponente);
            this.groupBox2.Controls.Add(this.TxtNombreMateriaPrima);
            this.groupBox2.Controls.Add(this.TxtCantidad);
            this.groupBox2.Controls.Add(this.BtnSeleccionarMateriaPrima);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(406, 58);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(618, 484);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Componentes";
            // 
            // BtnRemoverComponente
            // 
            this.BtnRemoverComponente.Location = new System.Drawing.Point(6, 415);
            this.BtnRemoverComponente.Name = "BtnRemoverComponente";
            this.BtnRemoverComponente.Size = new System.Drawing.Size(265, 37);
            this.BtnRemoverComponente.TabIndex = 7;
            this.BtnRemoverComponente.Text = "Remover Componente";
            this.BtnRemoverComponente.UseVisualStyleBackColor = true;
            this.BtnRemoverComponente.Click += new System.EventHandler(this.BtnRemoverComponente_Click);
            // 
            // BtnAgregarComponente
            // 
            this.BtnAgregarComponente.Location = new System.Drawing.Point(6, 149);
            this.BtnAgregarComponente.Name = "BtnAgregarComponente";
            this.BtnAgregarComponente.Size = new System.Drawing.Size(265, 33);
            this.BtnAgregarComponente.TabIndex = 6;
            this.BtnAgregarComponente.Text = "Agregar Componente";
            this.BtnAgregarComponente.UseVisualStyleBackColor = true;
            this.BtnAgregarComponente.Click += new System.EventHandler(this.BtnAgregarComponente_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(119, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 20);
            this.label8.TabIndex = 5;
            this.label8.Text = "Cantidad";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(186, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "Nombre Materia Prima";
            // 
            // DtgComponente
            // 
            this.DtgComponente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgComponente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo_MateriaPrima,
            this.Nombre_componente,
            this.Cantidad_componente,
            this.UnidadDeMedida,
            this.Costo});
            this.DtgComponente.Location = new System.Drawing.Point(6, 195);
            this.DtgComponente.Name = "DtgComponente";
            this.DtgComponente.Size = new System.Drawing.Size(606, 201);
            this.DtgComponente.TabIndex = 3;
            // 
            // Codigo_MateriaPrima
            // 
            this.Codigo_MateriaPrima.Name = "Codigo_MateriaPrima";
            // 
            // Nombre_componente
            // 
            this.Nombre_componente.Name = "Nombre_componente";
            // 
            // Cantidad_componente
            // 
            this.Cantidad_componente.Name = "Cantidad_componente";
            // 
            // UnidadDeMedida
            // 
            this.UnidadDeMedida.Name = "UnidadDeMedida";
            // 
            // Costo
            // 
            this.Costo.Name = "Costo";
            // 
            // TxtNombreMateriaPrima
            // 
            this.TxtNombreMateriaPrima.Location = new System.Drawing.Point(206, 83);
            this.TxtNombreMateriaPrima.Name = "TxtNombreMateriaPrima";
            this.TxtNombreMateriaPrima.Size = new System.Drawing.Size(146, 26);
            this.TxtNombreMateriaPrima.TabIndex = 2;
            // 
            // TxtCantidad
            // 
            this.TxtCantidad.Location = new System.Drawing.Point(206, 115);
            this.TxtCantidad.Name = "TxtCantidad";
            this.TxtCantidad.Size = new System.Drawing.Size(146, 26);
            this.TxtCantidad.TabIndex = 1;
            // 
            // BtnSeleccionarMateriaPrima
            // 
            this.BtnSeleccionarMateriaPrima.Location = new System.Drawing.Point(6, 25);
            this.BtnSeleccionarMateriaPrima.Name = "BtnSeleccionarMateriaPrima";
            this.BtnSeleccionarMateriaPrima.Size = new System.Drawing.Size(233, 33);
            this.BtnSeleccionarMateriaPrima.TabIndex = 0;
            this.BtnSeleccionarMateriaPrima.Text = "Seleccionar Materia Prima";
            this.BtnSeleccionarMateriaPrima.UseVisualStyleBackColor = true;
            this.BtnSeleccionarMateriaPrima.Click += new System.EventHandler(this.BtnSeleccionarMateriaPrima_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtRubro);
            this.groupBox1.Controls.Add(this.BtnSeleccionarRubro);
            this.groupBox1.Controls.Add(this.BtnModificarProducto);
            this.groupBox1.Controls.Add(this.TxtPrecio);
            this.groupBox1.Controls.Add(this.TxtCodigoProducto);
            this.groupBox1.Controls.Add(this.TxtNombre);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 484);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Producto";
            // 
            // TxtRubro
            // 
            this.TxtRubro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRubro.Location = new System.Drawing.Point(187, 194);
            this.TxtRubro.Name = "TxtRubro";
            this.TxtRubro.Size = new System.Drawing.Size(169, 26);
            this.TxtRubro.TabIndex = 13;
            // 
            // BtnSeleccionarRubro
            // 
            this.BtnSeleccionarRubro.Location = new System.Drawing.Point(13, 194);
            this.BtnSeleccionarRubro.Name = "BtnSeleccionarRubro";
            this.BtnSeleccionarRubro.Size = new System.Drawing.Size(165, 26);
            this.BtnSeleccionarRubro.TabIndex = 11;
            this.BtnSeleccionarRubro.Text = "Seleccionar Rubro";
            this.BtnSeleccionarRubro.UseVisualStyleBackColor = true;
            this.BtnSeleccionarRubro.Click += new System.EventHandler(this.BtnSeleccionarRubro_Click);
            // 
            // BtnModificarProducto
            // 
            this.BtnModificarProducto.Location = new System.Drawing.Point(82, 267);
            this.BtnModificarProducto.Name = "BtnModificarProducto";
            this.BtnModificarProducto.Size = new System.Drawing.Size(203, 40);
            this.BtnModificarProducto.TabIndex = 10;
            this.BtnModificarProducto.Text = "Modificar Producto";
            this.BtnModificarProducto.UseVisualStyleBackColor = true;
            this.BtnModificarProducto.Click += new System.EventHandler(this.BtnModificarProducto_Click);
            // 
            // TxtPrecio
            // 
            this.TxtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPrecio.Location = new System.Drawing.Point(187, 151);
            this.TxtPrecio.Name = "TxtPrecio";
            this.TxtPrecio.Size = new System.Drawing.Size(169, 26);
            this.TxtPrecio.TabIndex = 9;
            // 
            // TxtCodigoProducto
            // 
            this.TxtCodigoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodigoProducto.Location = new System.Drawing.Point(187, 98);
            this.TxtCodigoProducto.Name = "TxtCodigoProducto";
            this.TxtCodigoProducto.Size = new System.Drawing.Size(169, 26);
            this.TxtCodigoProducto.TabIndex = 8;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre.Location = new System.Drawing.Point(187, 54);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(169, 26);
            this.TxtNombre.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(115, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Precio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Codigo Producto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(103, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // BtnSeleccionarProducto
            // 
            this.BtnSeleccionarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSeleccionarProducto.Location = new System.Drawing.Point(18, 13);
            this.BtnSeleccionarProducto.Name = "BtnSeleccionarProducto";
            this.BtnSeleccionarProducto.Size = new System.Drawing.Size(312, 28);
            this.BtnSeleccionarProducto.TabIndex = 5;
            this.BtnSeleccionarProducto.Text = "Seleccionar Producto";
            this.BtnSeleccionarProducto.UseVisualStyleBackColor = true;
            this.BtnSeleccionarProducto.Click += new System.EventHandler(this.BtnSeleccionarProducto_Click);
            // 
            // FmrModificarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 559);
            this.Controls.Add(this.BtnSeleccionarProducto);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FmrModificarProducto";
            this.Text = "FmrModificarProducto";
            this.Load += new System.EventHandler(this.FmrModificarProducto_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgComponente)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnRemoverComponente;
        private System.Windows.Forms.Button BtnAgregarComponente;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView DtgComponente;
        private System.Windows.Forms.TextBox TxtNombreMateriaPrima;
        private System.Windows.Forms.TextBox TxtCantidad;
        private System.Windows.Forms.Button BtnSeleccionarMateriaPrima;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtRubro;
        private System.Windows.Forms.Button BtnSeleccionarRubro;
        private System.Windows.Forms.Button BtnModificarProducto;
        private System.Windows.Forms.TextBox TxtPrecio;
        private System.Windows.Forms.TextBox TxtCodigoProducto;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnSeleccionarProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo_MateriaPrima;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_componente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad_componente;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnidadDeMedida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Costo;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}