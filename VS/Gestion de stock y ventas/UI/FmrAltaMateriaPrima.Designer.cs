namespace UI
{
    partial class FmrAltaMateriaPrima
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
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtCodigoMateriaPrima = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtCosto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnAltaMateriaPrima = new System.Windows.Forms.Button();
            this.cmbunidadDeMedida = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DtgImport = new System.Windows.Forms.DataGridView();
            this.btnMostrarDatos = new System.Windows.Forms.Button();
            this.BtnAltaEmpleados = new System.Windows.Forms.Button();
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
            this.label1.Location = new System.Drawing.Point(29, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre.Location = new System.Drawing.Point(106, 122);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(319, 26);
            this.TxtNombre.TabIndex = 1;
            // 
            // TxtCodigoMateriaPrima
            // 
            this.TxtCodigoMateriaPrima.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodigoMateriaPrima.Location = new System.Drawing.Point(215, 66);
            this.TxtCodigoMateriaPrima.Name = "TxtCodigoMateriaPrima";
            this.TxtCodigoMateriaPrima.Size = new System.Drawing.Size(210, 26);
            this.TxtCodigoMateriaPrima.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Codigo Materia Prima";
            // 
            // TxtCosto
            // 
            this.TxtCosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCosto.Location = new System.Drawing.Point(91, 241);
            this.TxtCosto.Name = "TxtCosto";
            this.TxtCosto.Size = new System.Drawing.Size(334, 26);
            this.TxtCosto.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Costo";
            // 
            // BtnAltaMateriaPrima
            // 
            this.BtnAltaMateriaPrima.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAltaMateriaPrima.Location = new System.Drawing.Point(142, 301);
            this.BtnAltaMateriaPrima.Name = "BtnAltaMateriaPrima";
            this.BtnAltaMateriaPrima.Size = new System.Drawing.Size(209, 37);
            this.BtnAltaMateriaPrima.TabIndex = 6;
            this.BtnAltaMateriaPrima.Text = "Crear Materia Prima";
            this.BtnAltaMateriaPrima.UseVisualStyleBackColor = true;
            this.BtnAltaMateriaPrima.Click += new System.EventHandler(this.BtnAltaMateriaPrima_Click);
            // 
            // cmbunidadDeMedida
            // 
            this.cmbunidadDeMedida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbunidadDeMedida.FormattingEnabled = true;
            this.cmbunidadDeMedida.Location = new System.Drawing.Point(189, 174);
            this.cmbunidadDeMedida.Name = "cmbunidadDeMedida";
            this.cmbunidadDeMedida.Size = new System.Drawing.Size(236, 28);
            this.cmbunidadDeMedida.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Unidad de medida";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtCodigoMateriaPrima);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbunidadDeMedida);
            this.groupBox1.Controls.Add(this.TxtNombre);
            this.groupBox1.Controls.Add(this.BtnAltaMateriaPrima);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtCosto);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(468, 370);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alta Marteria Prima";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DtgImport);
            this.groupBox2.Controls.Add(this.btnMostrarDatos);
            this.groupBox2.Controls.Add(this.BtnAltaEmpleados);
            this.groupBox2.Controls.Add(this.TxtPathArchivo);
            this.groupBox2.Controls.Add(this.BtnImportarArchivo);
            this.groupBox2.Controls.Add(this.btnExportarArchivo);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(486, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(579, 370);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Alta de Empleados Masivo";
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
            // BtnAltaEmpleados
            // 
            this.BtnAltaEmpleados.Location = new System.Drawing.Point(421, 294);
            this.BtnAltaEmpleados.Name = "BtnAltaEmpleados";
            this.BtnAltaEmpleados.Size = new System.Drawing.Size(152, 50);
            this.BtnAltaEmpleados.TabIndex = 20;
            this.BtnAltaEmpleados.Text = "Crear Materias Primas";
            this.BtnAltaEmpleados.UseVisualStyleBackColor = true;
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
            // FmrAltaMateriaPrima
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 398);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FmrAltaMateriaPrima";
            this.Text = "FmrAltaMateriaPrima";
            this.Load += new System.EventHandler(this.FmrAltaMateriaPrima_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgImport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtCodigoMateriaPrima;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtCosto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnAltaMateriaPrima;
        private System.Windows.Forms.ComboBox cmbunidadDeMedida;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView DtgImport;
        private System.Windows.Forms.Button btnMostrarDatos;
        private System.Windows.Forms.Button BtnAltaEmpleados;
        private System.Windows.Forms.TextBox TxtPathArchivo;
        private System.Windows.Forms.Button BtnImportarArchivo;
        private System.Windows.Forms.Button btnExportarArchivo;
    }
}