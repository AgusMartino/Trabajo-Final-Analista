using SL.Services.Extensions;

namespace UI
{
    partial class FmrListarPerfil
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
            this.DtgPerfil = new System.Windows.Forms.DataGridView();
            this.IdPerfil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombrePerfil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnSeleccionarPerfil = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.DtgPerfil)).BeginInit();
            this.SuspendLayout();
            // 
            // DtgPerfil
            // 
            this.DtgPerfil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgPerfil.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdPerfil,
            this.NombrePerfil});
            this.DtgPerfil.Location = new System.Drawing.Point(13, 13);
            this.DtgPerfil.Name = "DtgPerfil";
            this.DtgPerfil.Size = new System.Drawing.Size(685, 215);
            this.DtgPerfil.TabIndex = 0;
            // 
            // IdPerfil
            // 
            this.IdPerfil.Name = "IdPerfil";
            // 
            // NombrePerfil
            // 
            this.NombrePerfil.Name = "NombrePerfil";
            // 
            // BtnSeleccionarPerfil
            // 
            this.BtnSeleccionarPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSeleccionarPerfil.Location = new System.Drawing.Point(13, 266);
            this.BtnSeleccionarPerfil.Name = "BtnSeleccionarPerfil";
            this.BtnSeleccionarPerfil.Size = new System.Drawing.Size(210, 33);
            this.BtnSeleccionarPerfil.TabIndex = 1;
            this.BtnSeleccionarPerfil.Text = "Seleccionar Perfil";
            this.BtnSeleccionarPerfil.UseVisualStyleBackColor = true;
            this.BtnSeleccionarPerfil.Click += new System.EventHandler(this.BtnSeleccionarPerfil_Click);
            // 
            // FmrListarPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 326);
            this.Controls.Add(this.BtnSeleccionarPerfil);
            this.Controls.Add(this.DtgPerfil);
            this.Name = "FmrListarPerfil";
            this.Text = "FmrListarPerfil";
            this.Load += new System.EventHandler(this.FmrListarPerfil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtgPerfil)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DtgPerfil;
        private System.Windows.Forms.Button BtnSeleccionarPerfil;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPerfil;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombrePerfil;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}