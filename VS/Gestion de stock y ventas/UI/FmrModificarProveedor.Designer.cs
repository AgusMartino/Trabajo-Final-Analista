namespace UI
{
    partial class FmrModificarProveedor
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
            this.TxtCuit = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnBuscarProveedor = new System.Windows.Forms.Button();
            this.BtnModificarProveedor = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.SuspendLayout();
            // 
            // TxtNombre
            // 
            this.TxtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre.Location = new System.Drawing.Point(320, 46);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(188, 26);
            this.TxtNombre.TabIndex = 9;
            // 
            // TxtCuit
            // 
            this.TxtCuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCuit.Location = new System.Drawing.Point(320, 12);
            this.TxtCuit.Name = "TxtCuit";
            this.TxtCuit.Size = new System.Drawing.Size(188, 26);
            this.TxtCuit.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(234, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(264, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Cuit";
            // 
            // BtnBuscarProveedor
            // 
            this.BtnBuscarProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscarProveedor.Location = new System.Drawing.Point(12, 9);
            this.BtnBuscarProveedor.Name = "BtnBuscarProveedor";
            this.BtnBuscarProveedor.Size = new System.Drawing.Size(183, 33);
            this.BtnBuscarProveedor.TabIndex = 10;
            this.BtnBuscarProveedor.Text = "Buscar Proveedor";
            this.BtnBuscarProveedor.UseVisualStyleBackColor = true;
            this.BtnBuscarProveedor.Click += new System.EventHandler(this.BtnBuscarProveedor_Click);
            // 
            // BtnModificarProveedor
            // 
            this.BtnModificarProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificarProveedor.Location = new System.Drawing.Point(161, 112);
            this.BtnModificarProveedor.Name = "BtnModificarProveedor";
            this.BtnModificarProveedor.Size = new System.Drawing.Size(183, 33);
            this.BtnModificarProveedor.TabIndex = 11;
            this.BtnModificarProveedor.Text = "Modificar Proveedor";
            this.BtnModificarProveedor.UseVisualStyleBackColor = true;
            this.BtnModificarProveedor.Click += new System.EventHandler(this.BtnModificarProveedor_Click);
            // 
            // FmrModificarProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 157);
            this.Controls.Add(this.BtnModificarProveedor);
            this.Controls.Add(this.BtnBuscarProveedor);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.TxtCuit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FmrModificarProveedor";
            this.Text = "FmrModificarProveedor";
            this.Load += new System.EventHandler(this.FmrModificarProveedor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnBuscarProveedor;
        private System.Windows.Forms.Button BtnModificarProveedor;
        public System.Windows.Forms.TextBox TxtNombre;
        public System.Windows.Forms.TextBox TxtCuit;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}