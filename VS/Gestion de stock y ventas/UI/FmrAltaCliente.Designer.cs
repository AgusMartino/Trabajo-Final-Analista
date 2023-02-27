using SL.Services.Extensions;

namespace UI
{
    partial class FmrAltaCliente
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
            this.BtnCrearCliente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtApellido = new System.Windows.Forms.TextBox();
            this.TxtDni = new System.Windows.Forms.TextBox();
            this.TxtDireccion = new System.Windows.Forms.TextBox();
            this.DtmFecha_de_nacimiento = new System.Windows.Forms.DateTimePicker();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExportarArchivo = new System.Windows.Forms.Button();
            this.BtnImportarArchivo = new System.Windows.Forms.Button();
            this.DtgImport = new System.Windows.Forms.DataGridView();
            this.TxtPathArchivo = new System.Windows.Forms.TextBox();
            this.btnMostrarDatos = new System.Windows.Forms.Button();
            this.BtnAltaClientes = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.saveFileDialog2 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgImport)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnCrearCliente
            // 
            this.BtnCrearCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCrearCliente.Location = new System.Drawing.Point(108, 249);
            this.BtnCrearCliente.Name = "BtnCrearCliente";
            this.BtnCrearCliente.Size = new System.Drawing.Size(207, 30);
            this.BtnCrearCliente.TabIndex = 0;
            this.BtnCrearCliente.Text = "Crear Cliente";
            this.BtnCrearCliente.UseVisualStyleBackColor = true;
            this.BtnCrearCliente.Click += new System.EventHandler(this.BtnCrearCliente_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(101, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(136, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Dni";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Fecha de nacimineto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(88, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Direccion";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre.Location = new System.Drawing.Point(194, 43);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(168, 26);
            this.TxtNombre.TabIndex = 8;
            // 
            // TxtApellido
            // 
            this.TxtApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtApellido.Location = new System.Drawing.Point(194, 90);
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Size = new System.Drawing.Size(168, 26);
            this.TxtApellido.TabIndex = 9;
            // 
            // TxtDni
            // 
            this.TxtDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDni.Location = new System.Drawing.Point(194, 134);
            this.TxtDni.Name = "TxtDni";
            this.TxtDni.Size = new System.Drawing.Size(168, 26);
            this.TxtDni.TabIndex = 10;
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDireccion.Location = new System.Drawing.Point(194, 202);
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.Size = new System.Drawing.Size(168, 26);
            this.TxtDireccion.TabIndex = 12;
            // 
            // DtmFecha_de_nacimiento
            // 
            this.DtmFecha_de_nacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtmFecha_de_nacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtmFecha_de_nacimiento.Location = new System.Drawing.Point(194, 170);
            this.DtmFecha_de_nacimiento.Name = "DtmFecha_de_nacimiento";
            this.DtmFecha_de_nacimiento.Size = new System.Drawing.Size(168, 26);
            this.DtmFecha_de_nacimiento.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtNombre);
            this.groupBox1.Controls.Add(this.DtmFecha_de_nacimiento);
            this.groupBox1.Controls.Add(this.BtnCrearCliente);
            this.groupBox1.Controls.Add(this.TxtDireccion);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TxtDni);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtApellido);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(396, 350);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dar de alta cliente";
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
            // DtgImport
            // 
            this.DtgImport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgImport.Location = new System.Drawing.Point(6, 81);
            this.DtgImport.Name = "DtgImport";
            this.DtgImport.Size = new System.Drawing.Size(409, 263);
            this.DtgImport.TabIndex = 17;
            // 
            // TxtPathArchivo
            // 
            this.TxtPathArchivo.Location = new System.Drawing.Point(6, 47);
            this.TxtPathArchivo.Name = "TxtPathArchivo";
            this.TxtPathArchivo.Size = new System.Drawing.Size(409, 26);
            this.TxtPathArchivo.TabIndex = 18;
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
            // BtnAltaClientes
            // 
            this.BtnAltaClientes.Location = new System.Drawing.Point(421, 312);
            this.BtnAltaClientes.Name = "BtnAltaClientes";
            this.BtnAltaClientes.Size = new System.Drawing.Size(152, 32);
            this.BtnAltaClientes.TabIndex = 20;
            this.BtnAltaClientes.Text = "Crear Clientes";
            this.BtnAltaClientes.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DtgImport);
            this.groupBox2.Controls.Add(this.btnMostrarDatos);
            this.groupBox2.Controls.Add(this.BtnAltaClientes);
            this.groupBox2.Controls.Add(this.TxtPathArchivo);
            this.groupBox2.Controls.Add(this.BtnImportarArchivo);
            this.groupBox2.Controls.Add(this.btnExportarArchivo);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(414, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(579, 350);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Alta de Clientes Masivo";
            // 
            // FmrAltaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 374);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FmrAltaCliente";
            this.Text = "FmrAltaCliente";
            this.Load += new System.EventHandler(this.FmrAltaCliente_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgImport)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnCrearCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtApellido;
        private System.Windows.Forms.TextBox TxtDni;
        private System.Windows.Forms.TextBox TxtDireccion;
        private System.Windows.Forms.DateTimePicker DtmFecha_de_nacimiento;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnExportarArchivo;
        private System.Windows.Forms.Button BtnImportarArchivo;
        private System.Windows.Forms.DataGridView DtgImport;
        private System.Windows.Forms.TextBox TxtPathArchivo;
        private System.Windows.Forms.Button btnMostrarDatos;
        private System.Windows.Forms.Button BtnAltaClientes;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog2;
    }
}