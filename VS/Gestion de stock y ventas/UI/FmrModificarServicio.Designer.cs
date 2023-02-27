namespace UI
{
    partial class FmrModificarServicio
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
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtCodigoServicio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnBuscarServicio = new System.Windows.Forms.Button();
            this.BtnModificarServicio = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.SuspendLayout();
            // 
            // TxtNombre
            // 
            this.TxtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre.Location = new System.Drawing.Point(365, 48);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(169, 26);
            this.TxtNombre.TabIndex = 9;
            // 
            // TxtCodigoServicio
            // 
            this.TxtCodigoServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodigoServicio.Location = new System.Drawing.Point(365, 12);
            this.TxtCodigoServicio.Name = "TxtCodigoServicio";
            this.TxtCodigoServicio.Size = new System.Drawing.Size(169, 26);
            this.TxtCodigoServicio.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(285, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(223, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Codigo Servicio";
            // 
            // BtnBuscarServicio
            // 
            this.BtnBuscarServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscarServicio.Location = new System.Drawing.Point(12, 9);
            this.BtnBuscarServicio.Name = "BtnBuscarServicio";
            this.BtnBuscarServicio.Size = new System.Drawing.Size(174, 32);
            this.BtnBuscarServicio.TabIndex = 10;
            this.BtnBuscarServicio.Text = "Buscar Servicio";
            this.BtnBuscarServicio.UseVisualStyleBackColor = true;
            this.BtnBuscarServicio.Click += new System.EventHandler(this.BtnBuscarServicio_Click);
            // 
            // BtnModificarServicio
            // 
            this.BtnModificarServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificarServicio.Location = new System.Drawing.Point(209, 108);
            this.BtnModificarServicio.Name = "BtnModificarServicio";
            this.BtnModificarServicio.Size = new System.Drawing.Size(174, 32);
            this.BtnModificarServicio.TabIndex = 11;
            this.BtnModificarServicio.Text = "Modificar Servicio";
            this.BtnModificarServicio.UseVisualStyleBackColor = true;
            this.BtnModificarServicio.Click += new System.EventHandler(this.BtnModificarServicio_Click);
            // 
            // FmrModificarServicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 152);
            this.Controls.Add(this.BtnModificarServicio);
            this.Controls.Add(this.BtnBuscarServicio);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.TxtCodigoServicio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FmrModificarServicio";
            this.Text = "FmrModificarServicio";
            this.Load += new System.EventHandler(this.FmrModificarServicio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnBuscarServicio;
        private System.Windows.Forms.Button BtnModificarServicio;
        public System.Windows.Forms.TextBox TxtNombre;
        public System.Windows.Forms.TextBox TxtCodigoServicio;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}