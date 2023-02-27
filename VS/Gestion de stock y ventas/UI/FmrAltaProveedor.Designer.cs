namespace UI
{
    partial class FmrAltaProveedor
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
            this.BtnCrearProveedor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtCuit = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DtgImport = new System.Windows.Forms.DataGridView();
            this.btnMostrarDatos = new System.Windows.Forms.Button();
            this.BtnAltaProveedores = new System.Windows.Forms.Button();
            this.TxtPathArchivo = new System.Windows.Forms.TextBox();
            this.BtnImportarArchivo = new System.Windows.Forms.Button();
            this.btnExportarArchivo = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgImport)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCrearProveedor
            // 
            this.BtnCrearProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCrearProveedor.Location = new System.Drawing.Point(73, 253);
            this.BtnCrearProveedor.Name = "BtnCrearProveedor";
            this.BtnCrearProveedor.Size = new System.Drawing.Size(193, 28);
            this.BtnCrearProveedor.TabIndex = 0;
            this.BtnCrearProveedor.Text = "Crear Proveedor";
            this.BtnCrearProveedor.UseVisualStyleBackColor = true;
            this.BtnCrearProveedor.Click += new System.EventHandler(this.BtnCrearProveedor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cuit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre";
            // 
            // TxtCuit
            // 
            this.TxtCuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCuit.Location = new System.Drawing.Point(104, 154);
            this.TxtCuit.Name = "TxtCuit";
            this.TxtCuit.Size = new System.Drawing.Size(188, 26);
            this.TxtCuit.TabIndex = 4;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre.Location = new System.Drawing.Point(104, 188);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(188, 26);
            this.TxtNombre.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtCuit);
            this.groupBox1.Controls.Add(this.TxtNombre);
            this.groupBox1.Controls.Add(this.BtnCrearProveedor);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(346, 359);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alta Proveedor";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DtgImport);
            this.groupBox2.Controls.Add(this.btnMostrarDatos);
            this.groupBox2.Controls.Add(this.BtnAltaProveedores);
            this.groupBox2.Controls.Add(this.TxtPathArchivo);
            this.groupBox2.Controls.Add(this.BtnImportarArchivo);
            this.groupBox2.Controls.Add(this.btnExportarArchivo);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(364, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(579, 359);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Alta de Proveedores Masivo";
            // 
            // DtgImport
            // 
            this.DtgImport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgImport.Location = new System.Drawing.Point(6, 81);
            this.DtgImport.Name = "DtgImport";
            this.DtgImport.Size = new System.Drawing.Size(409, 263);
            this.DtgImport.TabIndex = 17;
            // 
            // btnMostrarDatos
            // 
            this.btnMostrarDatos.Location = new System.Drawing.Point(421, 43);
            this.btnMostrarDatos.Name = "btnMostrarDatos";
            this.btnMostrarDatos.Size = new System.Drawing.Size(152, 35);
            this.btnMostrarDatos.TabIndex = 19;
            this.btnMostrarDatos.Text = "Mostrar Datos";
            this.btnMostrarDatos.UseVisualStyleBackColor = true;
            this.btnMostrarDatos.Click += new System.EventHandler(this.btnMostrarDatos_Click);
            // 
            // BtnAltaProveedores
            // 
            this.BtnAltaProveedores.Location = new System.Drawing.Point(421, 294);
            this.BtnAltaProveedores.Name = "BtnAltaProveedores";
            this.BtnAltaProveedores.Size = new System.Drawing.Size(152, 50);
            this.BtnAltaProveedores.TabIndex = 20;
            this.BtnAltaProveedores.Text = "Crear Proveedores";
            this.BtnAltaProveedores.UseVisualStyleBackColor = true;
            // 
            // TxtPathArchivo
            // 
            this.TxtPathArchivo.Location = new System.Drawing.Point(6, 47);
            this.TxtPathArchivo.Name = "TxtPathArchivo";
            this.TxtPathArchivo.Size = new System.Drawing.Size(409, 26);
            this.TxtPathArchivo.TabIndex = 18;
            // 
            // BtnImportarArchivo
            // 
            this.BtnImportarArchivo.Location = new System.Drawing.Point(421, 122);
            this.BtnImportarArchivo.Name = "BtnImportarArchivo";
            this.BtnImportarArchivo.Size = new System.Drawing.Size(152, 35);
            this.BtnImportarArchivo.TabIndex = 16;
            this.BtnImportarArchivo.Text = "Importar Archivo";
            this.BtnImportarArchivo.UseVisualStyleBackColor = true;
            this.BtnImportarArchivo.Click += new System.EventHandler(this.BtnImportarArchivo_Click);
            // 
            // btnExportarArchivo
            // 
            this.btnExportarArchivo.Location = new System.Drawing.Point(421, 81);
            this.btnExportarArchivo.Name = "btnExportarArchivo";
            this.btnExportarArchivo.Size = new System.Drawing.Size(152, 35);
            this.btnExportarArchivo.TabIndex = 15;
            this.btnExportarArchivo.Text = "Exportar Archivo";
            this.btnExportarArchivo.UseVisualStyleBackColor = true;
            this.btnExportarArchivo.Click += new System.EventHandler(this.btnExportarArchivo_Click);
            // 
            // FmrAltaProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 381);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FmrAltaProveedor";
            this.Text = "FmrAltaProveedor";
            this.Load += new System.EventHandler(this.FmrAltaProveedor_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgImport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnCrearProveedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtCuit;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView DtgImport;
        private System.Windows.Forms.Button btnMostrarDatos;
        private System.Windows.Forms.Button BtnAltaProveedores;
        private System.Windows.Forms.TextBox TxtPathArchivo;
        private System.Windows.Forms.Button BtnImportarArchivo;
        private System.Windows.Forms.Button btnExportarArchivo;
    }
}