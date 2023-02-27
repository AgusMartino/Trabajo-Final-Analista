using SL.Services.Extensions;

namespace UI
{
    partial class FmrListarUsuarios
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
            this.DtgUsuario = new System.Windows.Forms.DataGridView();
            this.IdUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Habilitado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrnSeleccioarUsuario = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.DtgUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // DtgUsuario
            // 
            this.DtgUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgUsuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdUsuario,
            this.Usuario,
            this.Habilitado});
            this.DtgUsuario.Location = new System.Drawing.Point(12, 12);
            this.DtgUsuario.Name = "DtgUsuario";
            this.DtgUsuario.Size = new System.Drawing.Size(775, 340);
            this.DtgUsuario.TabIndex = 0;
            // 
            // IdUsuario
            // 
            this.IdUsuario.Name = "IdUsuario";
            // 
            // Usuario
            // 
            this.Usuario.Name = "Usuario";
            // 
            // Habilitado
            // 
            this.Habilitado.Name = "Habilitado";
            // 
            // BrnSeleccioarUsuario
            // 
            this.BrnSeleccioarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrnSeleccioarUsuario.Location = new System.Drawing.Point(13, 382);
            this.BrnSeleccioarUsuario.Name = "BrnSeleccioarUsuario";
            this.BrnSeleccioarUsuario.Size = new System.Drawing.Size(202, 37);
            this.BrnSeleccioarUsuario.TabIndex = 1;
            this.BrnSeleccioarUsuario.Text = "Seleccionar Usuario";
            this.BrnSeleccioarUsuario.UseVisualStyleBackColor = true;
            this.BrnSeleccioarUsuario.Click += new System.EventHandler(this.BrnSeleccioarUsuario_Click);
            // 
            // FmrListarUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BrnSeleccioarUsuario);
            this.Controls.Add(this.DtgUsuario);
            this.Name = "FmrListarUsuarios";
            this.Text = "FmrListarUsuarios";
            this.Load += new System.EventHandler(this.FmrListarUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtgUsuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DtgUsuario;
        private System.Windows.Forms.Button BrnSeleccioarUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Habilitado;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}