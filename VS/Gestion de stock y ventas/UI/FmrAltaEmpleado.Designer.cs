namespace UI
{
    partial class FmrAltaEmpleado
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
            this.DtmFecha_de_nacimiento = new System.Windows.Forms.DateTimePicker();
            this.BtnCrearEmpleado = new System.Windows.Forms.Button();
            this.TxtDni = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtDireccion = new System.Windows.Forms.TextBox();
            this.TxtApellido = new System.Windows.Forms.TextBox();
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
            // DtmFecha_de_nacimiento
            // 
            this.DtmFecha_de_nacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtmFecha_de_nacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtmFecha_de_nacimiento.Location = new System.Drawing.Point(227, 260);
            this.DtmFecha_de_nacimiento.Name = "DtmFecha_de_nacimiento";
            this.DtmFecha_de_nacimiento.Size = new System.Drawing.Size(138, 26);
            this.DtmFecha_de_nacimiento.TabIndex = 30;
            // 
            // BtnCrearEmpleado
            // 
            this.BtnCrearEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCrearEmpleado.Location = new System.Drawing.Point(118, 311);
            this.BtnCrearEmpleado.Name = "BtnCrearEmpleado";
            this.BtnCrearEmpleado.Size = new System.Drawing.Size(165, 33);
            this.BtnCrearEmpleado.TabIndex = 20;
            this.BtnCrearEmpleado.Text = "Crear Empleado";
            this.BtnCrearEmpleado.UseVisualStyleBackColor = true;
            this.BtnCrearEmpleado.Click += new System.EventHandler(this.BtnCrearEmpleado_Click);
            // 
            // TxtDni
            // 
            this.TxtDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDni.Location = new System.Drawing.Point(75, 47);
            this.TxtDni.Name = "TxtDni";
            this.TxtDni.Size = new System.Drawing.Size(290, 26);
            this.TxtDni.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(37, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 20);
            this.label6.TabIndex = 21;
            this.label6.Text = "Dni";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(37, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 20);
            this.label7.TabIndex = 22;
            this.label7.Text = "Nombre";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(39, 154);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 20);
            this.label8.TabIndex = 23;
            this.label8.Text = "Apellido";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(37, 203);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 20);
            this.label9.TabIndex = 24;
            this.label9.Text = "Direccion";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(37, 261);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(176, 20);
            this.label10.TabIndex = 25;
            this.label10.Text = "Fecha de nacimiento";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre.Location = new System.Drawing.Point(114, 103);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(251, 26);
            this.TxtNombre.TabIndex = 27;
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDireccion.Location = new System.Drawing.Point(127, 200);
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.Size = new System.Drawing.Size(238, 26);
            this.TxtDireccion.TabIndex = 29;
            // 
            // TxtApellido
            // 
            this.TxtApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtApellido.Location = new System.Drawing.Point(118, 151);
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Size = new System.Drawing.Size(247, 26);
            this.TxtApellido.TabIndex = 28;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtDni);
            this.groupBox1.Controls.Add(this.DtmFecha_de_nacimiento);
            this.groupBox1.Controls.Add(this.TxtApellido);
            this.groupBox1.Controls.Add(this.BtnCrearEmpleado);
            this.groupBox1.Controls.Add(this.TxtDireccion);
            this.groupBox1.Controls.Add(this.TxtNombre);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(420, 359);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alta Empleado";
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
            this.groupBox2.Location = new System.Drawing.Point(438, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(579, 359);
            this.groupBox2.TabIndex = 32;
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
            this.BtnAltaEmpleados.Text = "Crear Empleados";
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
            // FmrAltaEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 390);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FmrAltaEmpleado";
            this.Text = "FmrAltaEmpleado";
            this.Load += new System.EventHandler(this.FmrAltaEmpleado_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgImport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DtmFecha_de_nacimiento;
        private System.Windows.Forms.Button BtnCrearEmpleado;
        private System.Windows.Forms.TextBox TxtDni;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtDireccion;
        private System.Windows.Forms.TextBox TxtApellido;
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