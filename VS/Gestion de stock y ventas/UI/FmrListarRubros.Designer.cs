using SL.Services.Extensions;

namespace UI
{
    partial class FmrListarRubros
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
            this.DtgRubros = new System.Windows.Forms.DataGridView();
            this.BtnSeleccionarRubro = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.Codigo_rubro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DtgRubros)).BeginInit();
            this.SuspendLayout();
            // 
            // DtgRubros
            // 
            this.DtgRubros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgRubros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo_rubro,
            this.Nombre});
            this.DtgRubros.Location = new System.Drawing.Point(12, 12);
            this.DtgRubros.Name = "DtgRubros";
            this.DtgRubros.Size = new System.Drawing.Size(776, 301);
            this.DtgRubros.TabIndex = 0;
            // 
            // BtnSeleccionarRubro
            // 
            this.BtnSeleccionarRubro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSeleccionarRubro.Location = new System.Drawing.Point(12, 338);
            this.BtnSeleccionarRubro.Name = "BtnSeleccionarRubro";
            this.BtnSeleccionarRubro.Size = new System.Drawing.Size(221, 42);
            this.BtnSeleccionarRubro.TabIndex = 1;
            this.BtnSeleccionarRubro.Text = "Seleccionar Rubro";
            this.BtnSeleccionarRubro.UseVisualStyleBackColor = true;
            this.BtnSeleccionarRubro.Click += new System.EventHandler(this.BtnSeleccionarRubro_Click);
            // 
            // Codigo_rubro
            // 
            this.Codigo_rubro.HeaderText = "Codigo_rubro";
            this.Codigo_rubro.Name = "Codigo_rubro";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // FmrListarRubros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 401);
            this.Controls.Add(this.BtnSeleccionarRubro);
            this.Controls.Add(this.DtgRubros);
            this.Name = "FmrListarRubros";
            this.Text = "FmrListaRubros";
            this.Load += new System.EventHandler(this.FmrListaRubros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtgRubros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DtgRubros;
        private System.Windows.Forms.Button BtnSeleccionarRubro;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo_rubro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
    }
}