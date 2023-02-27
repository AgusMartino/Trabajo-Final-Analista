namespace UI
{
    partial class FmrGestionInventario
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
            this.BtnSeleccionarMateriaPrima = new System.Windows.Forms.Button();
            this.BtnIngresarInventario = new System.Windows.Forms.Button();
            this.BtnEgresarInventario = new System.Windows.Forms.Button();
            this.TxtMateriaPrima = new System.Windows.Forms.TextBox();
            this.TxtCantidad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.SuspendLayout();
            // 
            // BtnSeleccionarMateriaPrima
            // 
            this.BtnSeleccionarMateriaPrima.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSeleccionarMateriaPrima.Location = new System.Drawing.Point(12, 18);
            this.BtnSeleccionarMateriaPrima.Name = "BtnSeleccionarMateriaPrima";
            this.BtnSeleccionarMateriaPrima.Size = new System.Drawing.Size(230, 35);
            this.BtnSeleccionarMateriaPrima.TabIndex = 5;
            this.BtnSeleccionarMateriaPrima.Text = "Seleccionar Materia Prima";
            this.BtnSeleccionarMateriaPrima.UseVisualStyleBackColor = true;
            this.BtnSeleccionarMateriaPrima.Click += new System.EventHandler(this.BtnSeleccionarMateriaPrima_Click);
            // 
            // BtnIngresarInventario
            // 
            this.BtnIngresarInventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIngresarInventario.Location = new System.Drawing.Point(97, 137);
            this.BtnIngresarInventario.Name = "BtnIngresarInventario";
            this.BtnIngresarInventario.Size = new System.Drawing.Size(190, 29);
            this.BtnIngresarInventario.TabIndex = 6;
            this.BtnIngresarInventario.Text = "Ingresar Inventario";
            this.BtnIngresarInventario.UseVisualStyleBackColor = true;
            this.BtnIngresarInventario.Click += new System.EventHandler(this.BtnIngresarInventario_Click);
            // 
            // BtnEgresarInventario
            // 
            this.BtnEgresarInventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEgresarInventario.Location = new System.Drawing.Point(336, 137);
            this.BtnEgresarInventario.Name = "BtnEgresarInventario";
            this.BtnEgresarInventario.Size = new System.Drawing.Size(190, 29);
            this.BtnEgresarInventario.TabIndex = 7;
            this.BtnEgresarInventario.Text = "Egresar Inventario";
            this.BtnEgresarInventario.UseVisualStyleBackColor = true;
            this.BtnEgresarInventario.Click += new System.EventHandler(this.BtnEgresarInventario_Click);
            // 
            // TxtMateriaPrima
            // 
            this.TxtMateriaPrima.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMateriaPrima.Location = new System.Drawing.Point(248, 22);
            this.TxtMateriaPrima.Name = "TxtMateriaPrima";
            this.TxtMateriaPrima.Size = new System.Drawing.Size(278, 26);
            this.TxtMateriaPrima.TabIndex = 9;
            // 
            // TxtCantidad
            // 
            this.TxtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCantidad.Location = new System.Drawing.Point(248, 70);
            this.TxtCantidad.Name = "TxtCantidad";
            this.TxtCantidad.Size = new System.Drawing.Size(119, 26);
            this.TxtCantidad.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(156, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Cantidad ";
            // 
            // FmrGestionInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 178);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtCantidad);
            this.Controls.Add(this.TxtMateriaPrima);
            this.Controls.Add(this.BtnEgresarInventario);
            this.Controls.Add(this.BtnIngresarInventario);
            this.Controls.Add(this.BtnSeleccionarMateriaPrima);
            this.Name = "FmrGestionInventario";
            this.Text = "FmrGestionInventario";
            this.Load += new System.EventHandler(this.FmrGestionInventario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSeleccionarMateriaPrima;
        private System.Windows.Forms.Button BtnIngresarInventario;
        private System.Windows.Forms.Button BtnEgresarInventario;
        private System.Windows.Forms.TextBox TxtMateriaPrima;
        private System.Windows.Forms.TextBox TxtCantidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}