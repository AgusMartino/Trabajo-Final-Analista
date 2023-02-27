using SL.Services.Extensions;

namespace UI
{
    partial class FmrListarCliente
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
            this.DtgClientes = new System.Windows.Forms.DataGridView();
            this.BtnSeleccionarCliente = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.Dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_de_nacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DtgClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // DtgClientes
            // 
            this.DtgClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Dni,
            this.Nombre,
            this.Apellido,
            this.Fecha_de_nacimiento,
            this.Direccion});
            this.DtgClientes.Location = new System.Drawing.Point(12, 12);
            this.DtgClientes.Name = "DtgClientes";
            this.DtgClientes.Size = new System.Drawing.Size(776, 324);
            this.DtgClientes.TabIndex = 0;
            this.DtgClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgClientes_CellContentClick);
            // 
            // BtnSeleccionarCliente
            // 
            this.BtnSeleccionarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSeleccionarCliente.Location = new System.Drawing.Point(11, 362);
            this.BtnSeleccionarCliente.Name = "BtnSeleccionarCliente";
            this.BtnSeleccionarCliente.Size = new System.Drawing.Size(228, 30);
            this.BtnSeleccionarCliente.TabIndex = 1;
            this.BtnSeleccionarCliente.Text = "Seleccionar Cliente";
            this.BtnSeleccionarCliente.UseVisualStyleBackColor = true;
            this.BtnSeleccionarCliente.Click += new System.EventHandler(this.BtnSeleccionarCliente_Click);
            // 
            // Dni
            // 
            this.Dni.HeaderText = "Dni";
            this.Dni.Name = "Dni";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            // 
            // Fecha_de_nacimiento
            // 
            this.Fecha_de_nacimiento.HeaderText = "Fecha_de_nacimiento";
            this.Fecha_de_nacimiento.Name = "Fecha_de_nacimiento";
            // 
            // Direccion
            // 
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.Name = "Direccion";
            // 
            // FmrListarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 417);
            this.Controls.Add(this.BtnSeleccionarCliente);
            this.Controls.Add(this.DtgClientes);
            this.Name = "FmrListarCliente";
            this.Text = "FmrListarCliente";
            this.Load += new System.EventHandler(this.FmrListarCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtgClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DtgClientes;
        private System.Windows.Forms.Button BtnSeleccionarCliente;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_de_nacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
    }
}