namespace UI
{
    partial class FmrAltaUsuario
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TxtRepetirContraseña = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.TxtContraseña = new System.Windows.Forms.TextBox();
            this.RdbSi = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.RdbNo = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.BtnCrearUsuario = new System.Windows.Forms.Button();
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
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TxtRepetirContraseña);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.TxtUsuario);
            this.groupBox2.Controls.Add(this.TxtContraseña);
            this.groupBox2.Controls.Add(this.RdbSi);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.RdbNo);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(407, 353);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Usuario";
            // 
            // TxtRepetirContraseña
            // 
            this.TxtRepetirContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRepetirContraseña.Location = new System.Drawing.Point(197, 164);
            this.TxtRepetirContraseña.Name = "TxtRepetirContraseña";
            this.TxtRepetirContraseña.PasswordChar = '*';
            this.TxtRepetirContraseña.Size = new System.Drawing.Size(165, 26);
            this.TxtRepetirContraseña.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "Repertir contraseña";
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUsuario.Location = new System.Drawing.Point(197, 83);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(165, 26);
            this.TxtUsuario.TabIndex = 17;
            // 
            // TxtContraseña
            // 
            this.TxtContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtContraseña.Location = new System.Drawing.Point(197, 120);
            this.TxtContraseña.Name = "TxtContraseña";
            this.TxtContraseña.PasswordChar = '*';
            this.TxtContraseña.Size = new System.Drawing.Size(165, 26);
            this.TxtContraseña.TabIndex = 18;
            // 
            // RdbSi
            // 
            this.RdbSi.AutoSize = true;
            this.RdbSi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdbSi.Location = new System.Drawing.Point(197, 268);
            this.RdbSi.Name = "RdbSi";
            this.RdbSi.Size = new System.Drawing.Size(43, 24);
            this.RdbSi.TabIndex = 12;
            this.RdbSi.TabStop = true;
            this.RdbSi.Text = "Si";
            this.RdbSi.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(101, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Habilitado";
            // 
            // RdbNo
            // 
            this.RdbNo.AutoSize = true;
            this.RdbNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdbNo.Location = new System.Drawing.Point(263, 268);
            this.RdbNo.Name = "RdbNo";
            this.RdbNo.Size = new System.Drawing.Size(49, 24);
            this.RdbNo.TabIndex = 13;
            this.RdbNo.TabStop = true;
            this.RdbNo.Text = "No";
            this.RdbNo.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(120, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Usuario";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(89, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Contraseña";
            // 
            // BtnCrearUsuario
            // 
            this.BtnCrearUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCrearUsuario.Location = new System.Drawing.Point(117, 384);
            this.BtnCrearUsuario.Name = "BtnCrearUsuario";
            this.BtnCrearUsuario.Size = new System.Drawing.Size(178, 29);
            this.BtnCrearUsuario.TabIndex = 22;
            this.BtnCrearUsuario.Text = "Crear Usuario";
            this.BtnCrearUsuario.UseVisualStyleBackColor = true;
            this.BtnCrearUsuario.Click += new System.EventHandler(this.BtnCrearUsuario_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(454, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 32;
            this.label3.Text = "Permisos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(454, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 31;
            this.label2.Text = "Perfiles";
            // 
            // BtnRemoverPermiso
            // 
            this.BtnRemoverPermiso.Location = new System.Drawing.Point(660, 268);
            this.BtnRemoverPermiso.Name = "BtnRemoverPermiso";
            this.BtnRemoverPermiso.Size = new System.Drawing.Size(75, 23);
            this.BtnRemoverPermiso.TabIndex = 30;
            this.BtnRemoverPermiso.Text = "<<";
            this.BtnRemoverPermiso.UseVisualStyleBackColor = true;
            this.BtnRemoverPermiso.Click += new System.EventHandler(this.BtnRemoverPermiso_Click);
            // 
            // BtnAgregarPermiso
            // 
            this.BtnAgregarPermiso.Location = new System.Drawing.Point(660, 239);
            this.BtnAgregarPermiso.Name = "BtnAgregarPermiso";
            this.BtnAgregarPermiso.Size = new System.Drawing.Size(75, 23);
            this.BtnAgregarPermiso.TabIndex = 29;
            this.BtnAgregarPermiso.Text = ">>";
            this.BtnAgregarPermiso.UseVisualStyleBackColor = true;
            this.BtnAgregarPermiso.Click += new System.EventHandler(this.BtnAgregarPermiso_Click);
            // 
            // BtnRemoverPerfil
            // 
            this.BtnRemoverPerfil.Location = new System.Drawing.Point(660, 66);
            this.BtnRemoverPerfil.Name = "BtnRemoverPerfil";
            this.BtnRemoverPerfil.Size = new System.Drawing.Size(75, 23);
            this.BtnRemoverPerfil.TabIndex = 28;
            this.BtnRemoverPerfil.Text = "<<";
            this.BtnRemoverPerfil.UseVisualStyleBackColor = true;
            this.BtnRemoverPerfil.Click += new System.EventHandler(this.BtnRemoverPerfil_Click);
            // 
            // BtnAgregarPerfil
            // 
            this.BtnAgregarPerfil.Location = new System.Drawing.Point(660, 37);
            this.BtnAgregarPerfil.Name = "BtnAgregarPerfil";
            this.BtnAgregarPerfil.Size = new System.Drawing.Size(75, 23);
            this.BtnAgregarPerfil.TabIndex = 27;
            this.BtnAgregarPerfil.Text = ">>";
            this.BtnAgregarPerfil.UseVisualStyleBackColor = true;
            this.BtnAgregarPerfil.Click += new System.EventHandler(this.BtnAgregarPerfil_Click);
            // 
            // LtbPermisosAgregados
            // 
            this.LtbPermisosAgregados.FormattingEnabled = true;
            this.LtbPermisosAgregados.Location = new System.Drawing.Point(741, 239);
            this.LtbPermisosAgregados.Name = "LtbPermisosAgregados";
            this.LtbPermisosAgregados.Size = new System.Drawing.Size(196, 160);
            this.LtbPermisosAgregados.TabIndex = 26;
            // 
            // LtbPermisos
            // 
            this.LtbPermisos.FormattingEnabled = true;
            this.LtbPermisos.Location = new System.Drawing.Point(458, 239);
            this.LtbPermisos.Name = "LtbPermisos";
            this.LtbPermisos.Size = new System.Drawing.Size(196, 160);
            this.LtbPermisos.TabIndex = 25;
            // 
            // LtbPerfilesAgregados
            // 
            this.LtbPerfilesAgregados.FormattingEnabled = true;
            this.LtbPerfilesAgregados.Location = new System.Drawing.Point(741, 37);
            this.LtbPerfilesAgregados.Name = "LtbPerfilesAgregados";
            this.LtbPerfilesAgregados.Size = new System.Drawing.Size(196, 160);
            this.LtbPerfilesAgregados.TabIndex = 24;
            // 
            // LtbPerfiles
            // 
            this.LtbPerfiles.FormattingEnabled = true;
            this.LtbPerfiles.Location = new System.Drawing.Point(458, 37);
            this.LtbPerfiles.Name = "LtbPerfiles";
            this.LtbPerfiles.Size = new System.Drawing.Size(196, 160);
            this.LtbPerfiles.TabIndex = 23;
            this.LtbPerfiles.TabStop = false;
            // 
            // FmrAltaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 425);
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
            this.Controls.Add(this.BtnCrearUsuario);
            this.Controls.Add(this.groupBox2);
            this.Name = "FmrAltaUsuario";
            this.Text = "FmrAltaUsuario";
            this.Load += new System.EventHandler(this.FmrAltaUsuario_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.RadioButton RdbSi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton RdbNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnCrearUsuario;
        private System.Windows.Forms.TextBox TxtRepetirContraseña;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtContraseña;
        private System.Windows.Forms.Label label8;
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
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}