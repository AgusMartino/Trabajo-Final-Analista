using SL.Services.Extensions;

namespace UI
{
    partial class FmrListarMateriaPrima
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
            this.DtgMateriaPrima = new System.Windows.Forms.DataGridView();
            this.BtnSeleccionaMateriaPrima = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.CodigoMateriaPrima = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnidadDeMedida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DtgMateriaPrima)).BeginInit();
            this.SuspendLayout();
            // 
            // DtgMateriaPrima
            // 
            this.DtgMateriaPrima.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgMateriaPrima.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoMateriaPrima,
            this.UnidadDeMedida,
            this.Nombre,
            this.Costo});
            this.DtgMateriaPrima.Location = new System.Drawing.Point(12, 12);
            this.DtgMateriaPrima.Name = "DtgMateriaPrima";
            this.DtgMateriaPrima.Size = new System.Drawing.Size(776, 304);
            this.DtgMateriaPrima.TabIndex = 0;
            // 
            // BtnSeleccionaMateriaPrima
            // 
            this.BtnSeleccionaMateriaPrima.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSeleccionaMateriaPrima.Location = new System.Drawing.Point(12, 357);
            this.BtnSeleccionaMateriaPrima.Name = "BtnSeleccionaMateriaPrima";
            this.BtnSeleccionaMateriaPrima.Size = new System.Drawing.Size(248, 34);
            this.BtnSeleccionaMateriaPrima.TabIndex = 1;
            this.BtnSeleccionaMateriaPrima.Text = "Seleccionar Materia Prima";
            this.BtnSeleccionaMateriaPrima.UseVisualStyleBackColor = true;
            this.BtnSeleccionaMateriaPrima.Click += new System.EventHandler(this.BtnSeleccionaMateriaPrima_Click);
            // 
            // CodigoMateriaPrima
            // 
            this.CodigoMateriaPrima.HeaderText = "CodigoMateriaPrima";
            this.CodigoMateriaPrima.Name = "CodigoMateriaPrima";
            // 
            // UnidadDeMedida
            // 
            this.UnidadDeMedida.HeaderText = "UnidadDeMedida";
            this.UnidadDeMedida.Name = "UnidadDeMedida";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Costo
            // 
            this.Costo.HeaderText = "Costo";
            this.Costo.Name = "Costo";
            // 
            // FmrListarMateriaPrima
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 414);
            this.Controls.Add(this.BtnSeleccionaMateriaPrima);
            this.Controls.Add(this.DtgMateriaPrima);
            this.Name = "FmrListarMateriaPrima";
            this.Text = "FmrListarMateriaPrima";
            this.Load += new System.EventHandler(this.FmrListarMateriaPrima_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtgMateriaPrima)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DtgMateriaPrima;
        private System.Windows.Forms.Button BtnSeleccionaMateriaPrima;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoMateriaPrima;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnidadDeMedida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Costo;
    }
}