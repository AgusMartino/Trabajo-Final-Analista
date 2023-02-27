using SL.Services.Extensions;

namespace UI
{
    partial class FmrListarProveedor
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
            this.DtgProveedor = new System.Windows.Forms.DataGridView();
            this.BtnSeleccionarProveedor = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.Cuit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DtgProveedor)).BeginInit();
            this.SuspendLayout();
            // 
            // DtgProveedor
            // 
            this.DtgProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgProveedor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cuit,
            this.Nombre});
            this.DtgProveedor.Location = new System.Drawing.Point(12, 12);
            this.DtgProveedor.Name = "DtgProveedor";
            this.DtgProveedor.Size = new System.Drawing.Size(776, 313);
            this.DtgProveedor.TabIndex = 0;
            // 
            // BtnSeleccionarProveedor
            // 
            this.BtnSeleccionarProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSeleccionarProveedor.Location = new System.Drawing.Point(12, 349);
            this.BtnSeleccionarProveedor.Name = "BtnSeleccionarProveedor";
            this.BtnSeleccionarProveedor.Size = new System.Drawing.Size(257, 33);
            this.BtnSeleccionarProveedor.TabIndex = 1;
            this.BtnSeleccionarProveedor.Text = "Seleccionar Proveedor";
            this.BtnSeleccionarProveedor.UseVisualStyleBackColor = true;
            this.BtnSeleccionarProveedor.Click += new System.EventHandler(this.BtnSeleccionarProveedor_Click);
            // 
            // Cuit
            // 
            this.Cuit.HeaderText = "Cuit";
            this.Cuit.Name = "Cuit";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // FmrListarProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 409);
            this.Controls.Add(this.BtnSeleccionarProveedor);
            this.Controls.Add(this.DtgProveedor);
            this.Name = "FmrListarProveedor";
            this.Text = "FmrListarProveedor";
            this.Load += new System.EventHandler(this.FmrListarProveedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtgProveedor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DtgProveedor;
        private System.Windows.Forms.Button BtnSeleccionarProveedor;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
    }
}