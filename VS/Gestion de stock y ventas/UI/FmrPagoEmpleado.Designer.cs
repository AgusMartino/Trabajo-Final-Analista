namespace UI
{
    partial class FmrPagoEmpleado
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
            this.label2 = new System.Windows.Forms.Label();
            this.BtnSeleccionarEmpleado = new System.Windows.Forms.Button();
            this.BtnRealizarPago = new System.Windows.Forms.Button();
            this.TxtSeleccionarEmpleado = new System.Windows.Forms.TextBox();
            this.TxtMotoAPagar = new System.Windows.Forms.TextBox();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(75, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Monto a pagar";
            // 
            // BtnSeleccionarEmpleado
            // 
            this.BtnSeleccionarEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSeleccionarEmpleado.Location = new System.Drawing.Point(12, 24);
            this.BtnSeleccionarEmpleado.Name = "BtnSeleccionarEmpleado";
            this.BtnSeleccionarEmpleado.Size = new System.Drawing.Size(197, 34);
            this.BtnSeleccionarEmpleado.TabIndex = 2;
            this.BtnSeleccionarEmpleado.Text = "Seleccionar Empleado";
            this.BtnSeleccionarEmpleado.UseVisualStyleBackColor = true;
            this.BtnSeleccionarEmpleado.Click += new System.EventHandler(this.BtnSeleccionarEmpleado_Click);
            // 
            // BtnRealizarPago
            // 
            this.BtnRealizarPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRealizarPago.Location = new System.Drawing.Point(147, 122);
            this.BtnRealizarPago.Name = "BtnRealizarPago";
            this.BtnRealizarPago.Size = new System.Drawing.Size(155, 46);
            this.BtnRealizarPago.TabIndex = 3;
            this.BtnRealizarPago.Text = "Realizar Pago";
            this.BtnRealizarPago.UseVisualStyleBackColor = true;
            this.BtnRealizarPago.Click += new System.EventHandler(this.BtnRealizarPago_Click);
            // 
            // TxtSeleccionarEmpleado
            // 
            this.TxtSeleccionarEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSeleccionarEmpleado.Location = new System.Drawing.Point(215, 28);
            this.TxtSeleccionarEmpleado.Name = "TxtSeleccionarEmpleado";
            this.TxtSeleccionarEmpleado.Size = new System.Drawing.Size(168, 26);
            this.TxtSeleccionarEmpleado.TabIndex = 4;
            // 
            // TxtMotoAPagar
            // 
            this.TxtMotoAPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMotoAPagar.Location = new System.Drawing.Point(215, 64);
            this.TxtMotoAPagar.Name = "TxtMotoAPagar";
            this.TxtMotoAPagar.Size = new System.Drawing.Size(168, 26);
            this.TxtMotoAPagar.TabIndex = 5;
            // 
            // FmrPagoEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 197);
            this.Controls.Add(this.TxtMotoAPagar);
            this.Controls.Add(this.TxtSeleccionarEmpleado);
            this.Controls.Add(this.BtnRealizarPago);
            this.Controls.Add(this.BtnSeleccionarEmpleado);
            this.Controls.Add(this.label2);
            this.Name = "FmrPagoEmpleado";
            this.Text = "FmrPagoEmpleado";
            this.Load += new System.EventHandler(this.FmrPagoEmpleado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnSeleccionarEmpleado;
        private System.Windows.Forms.Button BtnRealizarPago;
        private System.Windows.Forms.TextBox TxtSeleccionarEmpleado;
        private System.Windows.Forms.TextBox TxtMotoAPagar;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}