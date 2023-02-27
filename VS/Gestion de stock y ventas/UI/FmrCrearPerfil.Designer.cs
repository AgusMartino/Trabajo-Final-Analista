namespace UI
{
    partial class FmrCrearPerfil
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
            this.BtnCrearPerfil = new System.Windows.Forms.Button();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LtbPerfiles = new System.Windows.Forms.ListBox();
            this.LtbPerfilesAgregados = new System.Windows.Forms.ListBox();
            this.LtbPermisos = new System.Windows.Forms.ListBox();
            this.LtbPermisosAgregados = new System.Windows.Forms.ListBox();
            this.BtnAgregarPerfil = new System.Windows.Forms.Button();
            this.BtnRemoverPerfil = new System.Windows.Forms.Button();
            this.BtnAgregarPermiso = new System.Windows.Forms.Button();
            this.BtnRemoverPermiso = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.SuspendLayout();
            // 
            // BtnCrearPerfil
            // 
            this.BtnCrearPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCrearPerfil.Location = new System.Drawing.Point(176, 474);
            this.BtnCrearPerfil.Name = "BtnCrearPerfil";
            this.BtnCrearPerfil.Size = new System.Drawing.Size(221, 32);
            this.BtnCrearPerfil.TabIndex = 1;
            this.BtnCrearPerfil.Text = "Crear Perfil";
            this.BtnCrearPerfil.UseVisualStyleBackColor = true;
            this.BtnCrearPerfil.Click += new System.EventHandler(this.BtnCrearPerfil_Click);
            // 
            // TxtNombre
            // 
            this.TxtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre.Location = new System.Drawing.Point(176, 39);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(221, 26);
            this.TxtNombre.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(226, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre Perfil";
            // 
            // LtbPerfiles
            // 
            this.LtbPerfiles.FormattingEnabled = true;
            this.LtbPerfiles.Location = new System.Drawing.Point(39, 106);
            this.LtbPerfiles.Name = "LtbPerfiles";
            this.LtbPerfiles.Size = new System.Drawing.Size(196, 160);
            this.LtbPerfiles.TabIndex = 4;
            this.LtbPerfiles.TabStop = false;
            // 
            // LtbPerfilesAgregados
            // 
            this.LtbPerfilesAgregados.FormattingEnabled = true;
            this.LtbPerfilesAgregados.Location = new System.Drawing.Point(322, 106);
            this.LtbPerfilesAgregados.Name = "LtbPerfilesAgregados";
            this.LtbPerfilesAgregados.Size = new System.Drawing.Size(196, 160);
            this.LtbPerfilesAgregados.TabIndex = 5;
            // 
            // LtbPermisos
            // 
            this.LtbPermisos.FormattingEnabled = true;
            this.LtbPermisos.Location = new System.Drawing.Point(39, 308);
            this.LtbPermisos.Name = "LtbPermisos";
            this.LtbPermisos.Size = new System.Drawing.Size(196, 160);
            this.LtbPermisos.TabIndex = 6;
            // 
            // LtbPermisosAgregados
            // 
            this.LtbPermisosAgregados.FormattingEnabled = true;
            this.LtbPermisosAgregados.Location = new System.Drawing.Point(322, 308);
            this.LtbPermisosAgregados.Name = "LtbPermisosAgregados";
            this.LtbPermisosAgregados.Size = new System.Drawing.Size(196, 160);
            this.LtbPermisosAgregados.TabIndex = 7;
            // 
            // BtnAgregarPerfil
            // 
            this.BtnAgregarPerfil.Location = new System.Drawing.Point(241, 106);
            this.BtnAgregarPerfil.Name = "BtnAgregarPerfil";
            this.BtnAgregarPerfil.Size = new System.Drawing.Size(75, 23);
            this.BtnAgregarPerfil.TabIndex = 8;
            this.BtnAgregarPerfil.Text = ">>";
            this.BtnAgregarPerfil.UseVisualStyleBackColor = true;
            this.BtnAgregarPerfil.Click += new System.EventHandler(this.BtnAgregarPerfil_Click);
            // 
            // BtnRemoverPerfil
            // 
            this.BtnRemoverPerfil.Location = new System.Drawing.Point(241, 135);
            this.BtnRemoverPerfil.Name = "BtnRemoverPerfil";
            this.BtnRemoverPerfil.Size = new System.Drawing.Size(75, 23);
            this.BtnRemoverPerfil.TabIndex = 9;
            this.BtnRemoverPerfil.Text = "<<";
            this.BtnRemoverPerfil.UseVisualStyleBackColor = true;
            this.BtnRemoverPerfil.Click += new System.EventHandler(this.BtnRemoverPerfil_Click);
            // 
            // BtnAgregarPermiso
            // 
            this.BtnAgregarPermiso.Location = new System.Drawing.Point(241, 308);
            this.BtnAgregarPermiso.Name = "BtnAgregarPermiso";
            this.BtnAgregarPermiso.Size = new System.Drawing.Size(75, 23);
            this.BtnAgregarPermiso.TabIndex = 10;
            this.BtnAgregarPermiso.Text = ">>";
            this.BtnAgregarPermiso.UseVisualStyleBackColor = true;
            this.BtnAgregarPermiso.Click += new System.EventHandler(this.BtnAgregarPermiso_Click);
            // 
            // BtnRemoverPermiso
            // 
            this.BtnRemoverPermiso.Location = new System.Drawing.Point(241, 337);
            this.BtnRemoverPermiso.Name = "BtnRemoverPermiso";
            this.BtnRemoverPermiso.Size = new System.Drawing.Size(75, 23);
            this.BtnRemoverPermiso.TabIndex = 11;
            this.BtnRemoverPermiso.Text = "<<";
            this.BtnRemoverPermiso.UseVisualStyleBackColor = true;
            this.BtnRemoverPermiso.Click += new System.EventHandler(this.BtnRemoverPermiso_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Perfiles";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Permisos";
            // 
            // FmrCrearPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 517);
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
            this.Controls.Add(this.BtnCrearPerfil);
            this.Name = "FmrCrearPerfil";
            this.Text = "FmrCrearPerfil";
            this.Load += new System.EventHandler(this.FmrCrearPerfil_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnCrearPerfil;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox LtbPerfiles;
        private System.Windows.Forms.ListBox LtbPerfilesAgregados;
        private System.Windows.Forms.ListBox LtbPermisos;
        private System.Windows.Forms.ListBox LtbPermisosAgregados;
        private System.Windows.Forms.Button BtnAgregarPerfil;
        private System.Windows.Forms.Button BtnRemoverPerfil;
        private System.Windows.Forms.Button BtnAgregarPermiso;
        private System.Windows.Forms.Button BtnRemoverPermiso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}