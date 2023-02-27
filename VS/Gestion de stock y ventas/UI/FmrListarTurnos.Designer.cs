using SL.Services.Extensions;

namespace UI
{
    partial class FmrListarTurnos
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
            this.DtgTurno = new System.Windows.Forms.DataGridView();
            this.IdTurno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Caja_inicial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_de_inicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_de_cierre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnSeleccionarTurno = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.DtgTurno)).BeginInit();
            this.SuspendLayout();
            // 
            // DtgTurno
            // 
            this.DtgTurno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgTurno.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdTurno,
            this.Caja_inicial,
            this.Fecha_de_inicio,
            this.Fecha_de_cierre});
            this.DtgTurno.Location = new System.Drawing.Point(12, 12);
            this.DtgTurno.Name = "DtgTurno";
            this.DtgTurno.Size = new System.Drawing.Size(548, 197);
            this.DtgTurno.TabIndex = 0;
            // 
            // IdTurno
            // 
            this.IdTurno.Name = "IdTurno";
            // 
            // Caja_inicial
            // 
            this.Caja_inicial.Name = "Caja_inicial";
            // 
            // Fecha_de_inicio
            // 
            this.Fecha_de_inicio.Name = "Fecha_de_inicio";
            // 
            // Fecha_de_cierre
            // 
            this.Fecha_de_cierre.Name = "Fecha_de_cierre";
            // 
            // BtnSeleccionarTurno
            // 
            this.BtnSeleccionarTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSeleccionarTurno.Location = new System.Drawing.Point(12, 270);
            this.BtnSeleccionarTurno.Name = "BtnSeleccionarTurno";
            this.BtnSeleccionarTurno.Size = new System.Drawing.Size(190, 26);
            this.BtnSeleccionarTurno.TabIndex = 1;
            this.BtnSeleccionarTurno.Text = "Seleccionar Turno";
            this.BtnSeleccionarTurno.UseVisualStyleBackColor = true;
            this.BtnSeleccionarTurno.Click += new System.EventHandler(this.BtnSeleccionarTurno_Click);
            // 
            // FmrListarTurnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 308);
            this.Controls.Add(this.BtnSeleccionarTurno);
            this.Controls.Add(this.DtgTurno);
            this.Name = "FmrListarTurnos";
            this.Text = "FmrListarTurnos";
            this.Load += new System.EventHandler(this.FmrListarTurnos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtgTurno)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DtgTurno;
        private System.Windows.Forms.Button BtnSeleccionarTurno;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdTurno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Caja_inicial;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_de_inicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_de_cierre;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}