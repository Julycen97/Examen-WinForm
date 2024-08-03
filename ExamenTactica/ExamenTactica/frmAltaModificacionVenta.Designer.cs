namespace ExamenTactica
{
    partial class frmAltaModificacionVenta
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.txtIDCliente = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblIDCliente = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Location = new System.Drawing.Point(410, 225);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(101, 41);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Location = new System.Drawing.Point(246, 225);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(101, 41);
            this.btnAceptar.TabIndex = 14;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTotal.Location = new System.Drawing.Point(353, 154);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(244, 26);
            this.txtTotal.TabIndex = 13;
            this.txtTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTotal_KeyPress);
            // 
            // txtFecha
            // 
            this.txtFecha.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtFecha.Location = new System.Drawing.Point(353, 104);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(244, 26);
            this.txtFecha.TabIndex = 12;
            // 
            // txtIDCliente
            // 
            this.txtIDCliente.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtIDCliente.Location = new System.Drawing.Point(353, 54);
            this.txtIDCliente.Name = "txtIDCliente";
            this.txtIDCliente.Size = new System.Drawing.Size(244, 26);
            this.txtIDCliente.TabIndex = 11;
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(172, 154);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(48, 20);
            this.lblTotal.TabIndex = 10;
            this.lblTotal.Text = "Total:";
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(172, 104);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(58, 20);
            this.lblFecha.TabIndex = 9;
            this.lblFecha.Text = "Fecha:";
            // 
            // lblIDCliente
            // 
            this.lblIDCliente.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblIDCliente.AutoSize = true;
            this.lblIDCliente.Location = new System.Drawing.Point(172, 54);
            this.lblIDCliente.Name = "lblIDCliente";
            this.lblIDCliente.Size = new System.Drawing.Size(83, 20);
            this.lblIDCliente.TabIndex = 8;
            this.lblIDCliente.Text = "ID Cliente:";
            // 
            // frmAltaModificacionVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 321);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.txtIDCliente);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblIDCliente);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(920, 444);
            this.MinimumSize = new System.Drawing.Size(672, 349);
            this.Name = "frmAltaModificacionVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Venta";
            this.Load += new System.EventHandler(this.frmAltaModificacionVenta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.TextBox txtIDCliente;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblIDCliente;
    }
}