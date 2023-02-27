namespace UI
{
    partial class FmrModificarPerfil
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
            this.BtnSeleccionarPerfil = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnRemoverPermiso = new System.Windows.Forms.Button();
            this.BtnAgregarPermiso = new System.Windows.Forms.Button();
            this.BtnRemoverPerfil = new System.Windows.Forms.Button();
            this.BtnAgregarPerfil = new System.Windows.Forms.Button();
            this.LtbPermisosAgregados = new System.Windows.Forms.ListBox();
            this.LtbPermisos = new System.Windows.Forms.ListBox();
            this.LtbPerfilesAgregados = new System.Windows.Forms.ListBox();
            this.LtbPerfiles = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.BtnModificarPerfil = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.SuspendLayout();
            // 
            // BtnSeleccionarPerfil
            // 
            this.BtnSeleccionarPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSeleccionarPerfil.Location = new System.Drawing.Point(290, 12);
            this.BtnSeleccionarPerfil.Name = "BtnSeleccionarPerfil";
            this.BtnSeleccionarPerfil.Size = new System.Drawing.Size(221, 32);
            this.BtnSeleccionarPerfil.TabIndex = 8;
            this.BtnSeleccionarPerfil.Text = "Seleccionar Perfil";
            this.BtnSeleccionarPerfil.UseVisualStyleBackColor = true;
            this.BtnSeleccionarPerfil.Click += new System.EventHandler(this.BtnSeleccionarPerfil_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(149, 329);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 26;
            this.label3.Text = "Permisos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(149, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "Perfiles";
            // 
            // BtnRemoverPermiso
            // 
            this.BtnRemoverPermiso.Location = new System.Drawing.Point(355, 381);
            this.BtnRemoverPermiso.Name = "BtnRemoverPermiso";
            this.BtnRemoverPermiso.Size = new System.Drawing.Size(75, 23);
            this.BtnRemoverPermiso.TabIndex = 24;
            this.BtnRemoverPermiso.Text = "<<";
            this.BtnRemoverPermiso.UseVisualStyleBackColor = true;
            this.BtnRemoverPermiso.Click += new System.EventHandler(this.BtnRemoverPermiso_Click);
            // 
            // BtnAgregarPermiso
            // 
            this.BtnAgregarPermiso.Location = new System.Drawing.Point(355, 352);
            this.BtnAgregarPermiso.Name = "BtnAgregarPermiso";
            this.BtnAgregarPermiso.Size = new System.Drawing.Size(75, 23);
            this.BtnAgregarPermiso.TabIndex = 23;
            this.BtnAgregarPermiso.Text = ">>";
            this.BtnAgregarPermiso.UseVisualStyleBackColor = true;
            this.BtnAgregarPermiso.Click += new System.EventHandler(this.BtnAgregarPermiso_Click);
            // 
            // BtnRemoverPerfil
            // 
            this.BtnRemoverPerfil.Location = new System.Drawing.Point(355, 179);
            this.BtnRemoverPerfil.Name = "BtnRemoverPerfil";
            this.BtnRemoverPerfil.Size = new System.Drawing.Size(75, 23);
            this.BtnRemoverPerfil.TabIndex = 22;
            this.BtnRemoverPerfil.Text = "<<";
            this.BtnRemoverPerfil.UseVisualStyleBackColor = true;
            this.BtnRemoverPerfil.Click += new System.EventHandler(this.BtnRemoverPerfil_Click);
            // 
            // BtnAgregarPerfil
            // 
            this.BtnAgregarPerfil.Location = new System.Drawing.Point(355, 150);
            this.BtnAgregarPerfil.Name = "BtnAgregarPerfil";
            this.BtnAgregarPerfil.Size = new System.Drawing.Size(75, 23);
            this.BtnAgregarPerfil.TabIndex = 21;
            this.BtnAgregarPerfil.Text = ">>";
            this.BtnAgregarPerfil.UseVisualStyleBackColor = true;
            this.BtnAgregarPerfil.Click += new System.EventHandler(this.BtnAgregarPerfil_Click);
            // 
            // LtbPermisosAgregados
            // 
            this.LtbPermisosAgregados.FormattingEnabled = true;
            this.LtbPermisosAgregados.Location = new System.Drawing.Point(436, 352);
            this.LtbPermisosAgregados.Name = "LtbPermisosAgregados";
            this.LtbPermisosAgregados.Size = new System.Drawing.Size(196, 160);
            this.LtbPermisosAgregados.TabIndex = 20;
            // 
            // LtbPermisos
            // 
            this.LtbPermisos.FormattingEnabled = true;
            this.LtbPermisos.Location = new System.Drawing.Point(153, 352);
            this.LtbPermisos.Name = "LtbPermisos";
            this.LtbPermisos.Size = new System.Drawing.Size(196, 160);
            this.LtbPermisos.TabIndex = 19;
            // 
            // LtbPerfilesAgregados
            // 
            this.LtbPerfilesAgregados.FormattingEnabled = true;
            this.LtbPerfilesAgregados.Location = new System.Drawing.Point(436, 150);
            this.LtbPerfilesAgregados.Name = "LtbPerfilesAgregados";
            this.LtbPerfilesAgregados.Size = new System.Drawing.Size(196, 160);
            this.LtbPerfilesAgregados.TabIndex = 18;
            // 
            // LtbPerfiles
            // 
            this.LtbPerfiles.FormattingEnabled = true;
            this.LtbPerfiles.Location = new System.Drawing.Point(153, 150);
            this.LtbPerfiles.Name = "LtbPerfiles";
            this.LtbPerfiles.Size = new System.Drawing.Size(196, 160);
            this.LtbPerfiles.TabIndex = 17;
            this.LtbPerfiles.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(340, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Nombre Perfil";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre.Location = new System.Drawing.Point(290, 83);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(221, 26);
            this.TxtNombre.TabIndex = 15;
            // 
            // BtnModificarPerfil
            // 
            this.BtnModificarPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificarPerfil.Location = new System.Drawing.Point(290, 518);
            this.BtnModificarPerfil.Name = "BtnModificarPerfil";
            this.BtnModificarPerfil.Size = new System.Drawing.Size(221, 32);
            this.BtnModificarPerfil.TabIndex = 14;
            this.BtnModificarPerfil.Text = "Modificar Perfil";
            this.BtnModificarPerfil.UseVisualStyleBackColor = true;
            this.BtnModificarPerfil.Click += new System.EventHandler(this.BtnModificarPerfil_Click_1);
            // 
            // FmrModificarPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 583);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnRemoverPermiso);
            this.Controls.Add(this.BtnAgregarPermiso);
            this.Controls.Add(this.BtnRemoverPerfil);
            this.Controls.Add(this.BtnAgregarPerfil);
            this.Controls.Add(this.LtbPermisosAgregados);
            this.Controls.Add(this.LtbPermisos);
            this.Controls.Add(this.LtbPerfilesAgregados);
            this.Controls.Add(this.LtbPerfiles);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.BtnModificarPerfil);
            this.Controls.Add(this.BtnSeleccionarPerfil);
            this.Name = "FmrModificarPerfil";
            this.Text = "FmrModificarPerfil";
            this.Load += new System.EventHandler(this.FmrModificarPerfil_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnSeleccionarPerfil;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnRemoverPermiso;
        private System.Windows.Forms.Button BtnAgregarPermiso;
        private System.Windows.Forms.Button BtnRemoverPerfil;
        private System.Windows.Forms.Button BtnAgregarPerfil;
        private System.Windows.Forms.ListBox LtbPermisosAgregados;
        private System.Windows.Forms.ListBox LtbPermisos;
        private System.Windows.Forms.ListBox LtbPerfilesAgregados;
        private System.Windows.Forms.ListBox LtbPerfiles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Button BtnModificarPerfil;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}