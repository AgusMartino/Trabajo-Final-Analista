using SL.Services.Extensions;

namespace UI
{
    partial class FmrListarEmpleado
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
            this.DtgEmpleados = new System.Windows.Forms.DataGridView();
            this.BtnSeleccionarEmpleado = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.Dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_de_nacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DtgEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // DtgEmpleados
            // 
            this.DtgEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Dni,
            this.Nombre,
            this.Apellido,
            this.Fecha_de_nacimiento,
            this.Direccion});
            this.DtgEmpleados.Location = new System.Drawing.Point(12, 12);
            this.DtgEmpleados.Name = "DtgEmpleados";
            this.DtgEmpleados.Size = new System.Drawing.Size(776, 310);
            this.DtgEmpleados.TabIndex = 1;
            // 
            // BtnSeleccionarEmpleado
            // 
            this.BtnSeleccionarEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSeleccionarEmpleado.Location = new System.Drawing.Point(14, 360);
            this.BtnSeleccionarEmpleado.Name = "BtnSeleccionarEmpleado";
            this.BtnSeleccionarEmpleado.Size = new System.Drawing.Size(249, 31);
            this.BtnSeleccionarEmpleado.TabIndex = 2;
            this.BtnSeleccionarEmpleado.Text = "Seleccionar Empleado";
            this.BtnSeleccionarEmpleado.UseVisualStyleBackColor = true;
            this.BtnSeleccionarEmpleado.Click += new System.EventHandler(this.BtnSeleccionarEmpleado_Click);
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
            // FmrListarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 404);
            this.Controls.Add(this.BtnSeleccionarEmpleado);
            this.Controls.Add(this.DtgEmpleados);
            this.Name = "FmrListarEmpleado";
            this.Text = "FmrListarEmpleado";
            this.Load += new System.EventHandler(this.FmrListarEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtgEmpleados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DtgEmpleados;
        private System.Windows.Forms.Button BtnSeleccionarEmpleado;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_de_nacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
    }
}