using SL.Services.Extensions;

namespace UI
{
    partial class FmrListarServicio
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
            this.BtnSeleccionarServicio = new System.Windows.Forms.Button();
            this.DtgServicio = new System.Windows.Forms.DataGridView();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.Codigo_servicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DtgServicio)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnSeleccionarServicio
            // 
            this.BtnSeleccionarServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSeleccionarServicio.Location = new System.Drawing.Point(12, 356);
            this.BtnSeleccionarServicio.Name = "BtnSeleccionarServicio";
            this.BtnSeleccionarServicio.Size = new System.Drawing.Size(225, 33);
            this.BtnSeleccionarServicio.TabIndex = 0;
            this.BtnSeleccionarServicio.Text = "Seleccionar Servicio";
            this.BtnSeleccionarServicio.UseVisualStyleBackColor = true;
            this.BtnSeleccionarServicio.Click += new System.EventHandler(this.BtnSeleccionarServicio_Click);
            // 
            // DtgServicio
            // 
            this.DtgServicio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgServicio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo_servicio,
            this.Nombre});
            this.DtgServicio.Location = new System.Drawing.Point(12, 12);
            this.DtgServicio.Name = "DtgServicio";
            this.DtgServicio.Size = new System.Drawing.Size(776, 317);
            this.DtgServicio.TabIndex = 2;
            // 
            // Codigo_servicio
            // 
            this.Codigo_servicio.HeaderText = "Codigo_servicio";
            this.Codigo_servicio.Name = "Codigo_servicio";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // FmrListarServicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 413);
            this.Controls.Add(this.DtgServicio);
            this.Controls.Add(this.BtnSeleccionarServicio);
            this.Name = "FmrListarServicio";
            this.Text = "FmrListarServicio";
            this.Load += new System.EventHandler(this.FmrListarServicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtgServicio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnSeleccionarServicio;
        private System.Windows.Forms.DataGridView DtgServicio;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo_servicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
    }
}