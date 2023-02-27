namespace UI
{
    partial class FmrAltaProductoMasiva
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
            this.DtgImportProducto = new System.Windows.Forms.DataGridView();
            this.btnMostrarDatosProducto = new System.Windows.Forms.Button();
            this.BtnAltaProductos = new System.Windows.Forms.Button();
            this.TxtPathArchivoProducto = new System.Windows.Forms.TextBox();
            this.BtnImportarArchivoProducto = new System.Windows.Forms.Button();
            this.btnExportarArchivoProducto = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DtgImportComponentes = new System.Windows.Forms.DataGridView();
            this.BtnMostrarDatosComponentes = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BtnImportarArchivoComponentes = new System.Windows.Forms.Button();
            this.BtnExportarArchivoComponentes = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgImportProducto)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgImportComponentes)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DtgImportProducto);
            this.groupBox2.Controls.Add(this.btnMostrarDatosProducto);
            this.groupBox2.Controls.Add(this.BtnAltaProductos);
            this.groupBox2.Controls.Add(this.TxtPathArchivoProducto);
            this.groupBox2.Controls.Add(this.BtnImportarArchivoProducto);
            this.groupBox2.Controls.Add(this.btnExportarArchivoProducto);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(579, 370);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Alta de Productos";
            // 
            // DtgImportProducto
            // 
            this.DtgImportProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgImportProducto.Location = new System.Drawing.Point(6, 81);
            this.DtgImportProducto.Name = "DtgImportProducto";
            this.DtgImportProducto.Size = new System.Drawing.Size(409, 263);
            this.DtgImportProducto.TabIndex = 17;
            // 
            // btnMostrarDatosProducto
            // 
            this.btnMostrarDatosProducto.Location = new System.Drawing.Point(421, 43);
            this.btnMostrarDatosProducto.Name = "btnMostrarDatosProducto";
            this.btnMostrarDatosProducto.Size = new System.Drawing.Size(152, 35);
            this.btnMostrarDatosProducto.TabIndex = 19;
            this.btnMostrarDatosProducto.Text = "Mostrar Datos";
            this.btnMostrarDatosProducto.UseVisualStyleBackColor = true;
            this.btnMostrarDatosProducto.Click += new System.EventHandler(this.btnMostrarDatosProducto_Click);
            // 
            // BtnAltaProductos
            // 
            this.BtnAltaProductos.Location = new System.Drawing.Point(421, 294);
            this.BtnAltaProductos.Name = "BtnAltaProductos";
            this.BtnAltaProductos.Size = new System.Drawing.Size(152, 50);
            this.BtnAltaProductos.TabIndex = 20;
            this.BtnAltaProductos.Text = "Crear Productos";
            this.BtnAltaProductos.UseVisualStyleBackColor = true;
            // 
            // TxtPathArchivoProducto
            // 
            this.TxtPathArchivoProducto.Location = new System.Drawing.Point(6, 47);
            this.TxtPathArchivoProducto.Name = "TxtPathArchivoProducto";
            this.TxtPathArchivoProducto.Size = new System.Drawing.Size(409, 26);
            this.TxtPathArchivoProducto.TabIndex = 18;
            // 
            // BtnImportarArchivoProducto
            // 
            this.BtnImportarArchivoProducto.Location = new System.Drawing.Point(421, 122);
            this.BtnImportarArchivoProducto.Name = "BtnImportarArchivoProducto";
            this.BtnImportarArchivoProducto.Size = new System.Drawing.Size(152, 35);
            this.BtnImportarArchivoProducto.TabIndex = 16;
            this.BtnImportarArchivoProducto.Text = "Importar Archivo";
            this.BtnImportarArchivoProducto.UseVisualStyleBackColor = true;
            this.BtnImportarArchivoProducto.Click += new System.EventHandler(this.BtnImportarArchivoProducto_Click);
            // 
            // btnExportarArchivoProducto
            // 
            this.btnExportarArchivoProducto.Location = new System.Drawing.Point(421, 81);
            this.btnExportarArchivoProducto.Name = "btnExportarArchivoProducto";
            this.btnExportarArchivoProducto.Size = new System.Drawing.Size(152, 35);
            this.btnExportarArchivoProducto.TabIndex = 15;
            this.btnExportarArchivoProducto.Text = "Exportar Archivo";
            this.btnExportarArchivoProducto.UseVisualStyleBackColor = true;
            this.btnExportarArchivoProducto.Click += new System.EventHandler(this.btnExportarArchivoProducto_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DtgImportComponentes);
            this.groupBox1.Controls.Add(this.BtnMostrarDatosComponentes);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.BtnImportarArchivoComponentes);
            this.groupBox1.Controls.Add(this.BtnExportarArchivoComponentes);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(597, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(579, 370);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alta de Componentes";
            // 
            // DtgImportComponentes
            // 
            this.DtgImportComponentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgImportComponentes.Location = new System.Drawing.Point(6, 81);
            this.DtgImportComponentes.Name = "DtgImportComponentes";
            this.DtgImportComponentes.Size = new System.Drawing.Size(409, 263);
            this.DtgImportComponentes.TabIndex = 17;
            // 
            // BtnMostrarDatosComponentes
            // 
            this.BtnMostrarDatosComponentes.Location = new System.Drawing.Point(421, 43);
            this.BtnMostrarDatosComponentes.Name = "BtnMostrarDatosComponentes";
            this.BtnMostrarDatosComponentes.Size = new System.Drawing.Size(152, 35);
            this.BtnMostrarDatosComponentes.TabIndex = 19;
            this.BtnMostrarDatosComponentes.Text = "Mostrar Datos";
            this.BtnMostrarDatosComponentes.UseVisualStyleBackColor = true;
            this.BtnMostrarDatosComponentes.Click += new System.EventHandler(this.BtnMostrarDatosComponentes_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(421, 294);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 50);
            this.button2.TabIndex = 20;
            this.button2.Text = "Crear Materias Primas";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 47);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(409, 26);
            this.textBox1.TabIndex = 18;
            // 
            // BtnImportarArchivoComponentes
            // 
            this.BtnImportarArchivoComponentes.Location = new System.Drawing.Point(421, 122);
            this.BtnImportarArchivoComponentes.Name = "BtnImportarArchivoComponentes";
            this.BtnImportarArchivoComponentes.Size = new System.Drawing.Size(152, 35);
            this.BtnImportarArchivoComponentes.TabIndex = 16;
            this.BtnImportarArchivoComponentes.Text = "Importar Archivo";
            this.BtnImportarArchivoComponentes.UseVisualStyleBackColor = true;
            this.BtnImportarArchivoComponentes.Click += new System.EventHandler(this.BtnImportarArchivoComponentes_Click);
            // 
            // BtnExportarArchivoComponentes
            // 
            this.BtnExportarArchivoComponentes.Location = new System.Drawing.Point(421, 81);
            this.BtnExportarArchivoComponentes.Name = "BtnExportarArchivoComponentes";
            this.BtnExportarArchivoComponentes.Size = new System.Drawing.Size(152, 35);
            this.BtnExportarArchivoComponentes.TabIndex = 15;
            this.BtnExportarArchivoComponentes.Text = "Exportar Archivo";
            this.BtnExportarArchivoComponentes.UseVisualStyleBackColor = true;
            this.BtnExportarArchivoComponentes.Click += new System.EventHandler(this.BtnExportarArchivoComponentes_Click);
            // 
            // FmrAltaProductoMasiva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 401);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "FmrAltaProductoMasiva";
            this.Text = "FmrAltaProductoMasiva";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgImportProducto)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgImportComponentes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView DtgImportProducto;
        private System.Windows.Forms.Button btnMostrarDatosProducto;
        private System.Windows.Forms.Button BtnAltaProductos;
        private System.Windows.Forms.TextBox TxtPathArchivoProducto;
        private System.Windows.Forms.Button BtnImportarArchivoProducto;
        private System.Windows.Forms.Button btnExportarArchivoProducto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DtgImportComponentes;
        private System.Windows.Forms.Button BtnMostrarDatosComponentes;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button BtnImportarArchivoComponentes;
        private System.Windows.Forms.Button BtnExportarArchivoComponentes;
    }
}