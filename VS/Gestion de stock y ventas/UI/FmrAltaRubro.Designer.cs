namespace UI
{
    partial class FmrAltaRubro
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
            this.BtnCrearRubro = new System.Windows.Forms.Button();
            this.TxtCodigoRubro = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DtgImport = new System.Windows.Forms.DataGridView();
            this.btnMostrarDatos = new System.Windows.Forms.Button();
            this.BtnAltaRubros = new System.Windows.Forms.Button();
            this.TxtPathArchivo = new System.Windows.Forms.TextBox();
            this.BtnImportarArchivo = new System.Windows.Forms.Button();
            this.btnExportarArchivo = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgImport)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo Rubro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // BtnCrearRubro
            // 
            this.BtnCrearRubro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCrearRubro.Location = new System.Drawing.Point(57, 203);
            this.BtnCrearRubro.Name = "BtnCrearRubro";
            this.BtnCrearRubro.Size = new System.Drawing.Size(180, 29);
            this.BtnCrearRubro.TabIndex = 2;
            this.BtnCrearRubro.Text = "Crear Rubro";
            this.BtnCrearRubro.UseVisualStyleBackColor = true;
            this.BtnCrearRubro.Click += new System.EventHandler(this.BtnCrearRubro_Click);
            // 
            // TxtCodigoRubro
            // 
            this.TxtCodigoRubro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodigoRubro.Location = new System.Drawing.Point(130, 92);
            this.TxtCodigoRubro.Name = "TxtCodigoRubro";
            this.TxtCodigoRubro.Size = new System.Drawing.Size(188, 26);
            this.TxtCodigoRubro.TabIndex = 4;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre.Location = new System.Drawing.Point(130, 131);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(188, 26);
            this.TxtNombre.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtCodigoRubro);
            this.groupBox1.Controls.Add(this.TxtNombre);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.BtnCrearRubro);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(324, 359);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alta Rubro";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DtgImport);
            this.groupBox2.Controls.Add(this.btnMostrarDatos);
            this.groupBox2.Controls.Add(this.BtnAltaRubros);
            this.groupBox2.Controls.Add(this.TxtPathArchivo);
            this.groupBox2.Controls.Add(this.BtnImportarArchivo);
            this.groupBox2.Controls.Add(this.btnExportarArchivo);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(342, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(579, 359);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Alta de Rubros Masivo";
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
            // BtnAltaRubros
            // 
            this.BtnAltaRubros.Location = new System.Drawing.Point(421, 311);
            this.BtnAltaRubros.Name = "BtnAltaRubros";
            this.BtnAltaRubros.Size = new System.Drawing.Size(152, 33);
            this.BtnAltaRubros.TabIndex = 20;
            this.BtnAltaRubros.Text = "Crear Rubros";
            this.BtnAltaRubros.UseVisualStyleBackColor = true;
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
            // FmrAltaRubro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 385);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FmrAltaRubro";
            this.Text = "FmrAltaRubro";
            this.Load += new System.EventHandler(this.FmrAltaRubro_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgImport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnCrearRubro;
        private System.Windows.Forms.TextBox TxtCodigoRubro;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView DtgImport;
        private System.Windows.Forms.Button btnMostrarDatos;
        private System.Windows.Forms.Button BtnAltaRubros;
        private System.Windows.Forms.TextBox TxtPathArchivo;
        private System.Windows.Forms.Button BtnImportarArchivo;
        private System.Windows.Forms.Button btnExportarArchivo;
    }
}