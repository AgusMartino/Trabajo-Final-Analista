namespace UI
{
    partial class FmrModificarRubro
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
            this.TxtCodigoRubro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnBuscarRubro = new System.Windows.Forms.Button();
            this.BtnModificarRubro = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.SuspendLayout();
            // 
            // TxtNombre
            // 
            this.TxtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre.Location = new System.Drawing.Point(367, 51);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(159, 26);
            this.TxtNombre.TabIndex = 9;
            // 
            // TxtCodigoRubro
            // 
            this.TxtCodigoRubro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodigoRubro.Location = new System.Drawing.Point(367, 12);
            this.TxtCodigoRubro.Name = "TxtCodigoRubro";
            this.TxtCodigoRubro.Size = new System.Drawing.Size(159, 26);
            this.TxtCodigoRubro.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(274, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(226, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Codigo Rubro";
            // 
            // BtnBuscarRubro
            // 
            this.BtnBuscarRubro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscarRubro.Location = new System.Drawing.Point(12, 5);
            this.BtnBuscarRubro.Name = "BtnBuscarRubro";
            this.BtnBuscarRubro.Size = new System.Drawing.Size(195, 40);
            this.BtnBuscarRubro.TabIndex = 10;
            this.BtnBuscarRubro.Text = "Buscar Rubro";
            this.BtnBuscarRubro.UseVisualStyleBackColor = true;
            this.BtnBuscarRubro.Click += new System.EventHandler(this.BtnBuscarRubro_Click);
            // 
            // BtnModificarRubro
            // 
            this.BtnModificarRubro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificarRubro.Location = new System.Drawing.Point(185, 98);
            this.BtnModificarRubro.Name = "BtnModificarRubro";
            this.BtnModificarRubro.Size = new System.Drawing.Size(195, 40);
            this.BtnModificarRubro.TabIndex = 11;
            this.BtnModificarRubro.Text = "Modificar Rubro";
            this.BtnModificarRubro.UseVisualStyleBackColor = true;
            this.BtnModificarRubro.Click += new System.EventHandler(this.BtnModificarRubro_Click);
            // 
            // FmrModificarRubro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 165);
            this.Controls.Add(this.BtnModificarRubro);
            this.Controls.Add(this.BtnBuscarRubro);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.TxtCodigoRubro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FmrModificarRubro";
            this.Text = "FmrModificarRubro";
            this.Load += new System.EventHandler(this.FmrModificarRubro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnBuscarRubro;
        private System.Windows.Forms.Button BtnModificarRubro;
        public System.Windows.Forms.TextBox TxtNombre;
        public System.Windows.Forms.TextBox TxtCodigoRubro;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}