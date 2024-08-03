namespace ExamenTactica
{
    partial class frmAltaModificacionProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAltaModificacionProducto));
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtPrecioProducto = new System.Windows.Forms.TextBox();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.lblPrecioProducto = new System.Windows.Forms.Label();
            this.lblNombreProducto = new System.Windows.Forms.Label();
            this.lblCategoriaProducto = new System.Windows.Forms.Label();
            this.txtCategoriaProducto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Location = new System.Drawing.Point(390, 233);
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
            this.btnAceptar.Location = new System.Drawing.Point(226, 233);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(101, 41);
            this.btnAceptar.TabIndex = 14;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtPrecioProducto
            // 
            this.txtPrecioProducto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPrecioProducto.Location = new System.Drawing.Point(345, 101);
            this.txtPrecioProducto.Name = "txtPrecioProducto";
            this.txtPrecioProducto.Size = new System.Drawing.Size(244, 26);
            this.txtPrecioProducto.TabIndex = 13;
            this.txtPrecioProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioProducto_KeyPress);
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNombreProducto.Location = new System.Drawing.Point(345, 51);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(244, 26);
            this.txtNombreProducto.TabIndex = 12;
            // 
            // lblPrecioProducto
            // 
            this.lblPrecioProducto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPrecioProducto.AutoSize = true;
            this.lblPrecioProducto.Location = new System.Drawing.Point(164, 101);
            this.lblPrecioProducto.Name = "lblPrecioProducto";
            this.lblPrecioProducto.Size = new System.Drawing.Size(57, 20);
            this.lblPrecioProducto.TabIndex = 10;
            this.lblPrecioProducto.Text = "Precio:";
            // 
            // lblNombreProducto
            // 
            this.lblNombreProducto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNombreProducto.AutoSize = true;
            this.lblNombreProducto.Location = new System.Drawing.Point(164, 51);
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(69, 20);
            this.lblNombreProducto.TabIndex = 9;
            this.lblNombreProducto.Text = "Nombre:";
            // 
            // lblCategoriaProducto
            // 
            this.lblCategoriaProducto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCategoriaProducto.AutoSize = true;
            this.lblCategoriaProducto.Location = new System.Drawing.Point(164, 150);
            this.lblCategoriaProducto.Name = "lblCategoriaProducto";
            this.lblCategoriaProducto.Size = new System.Drawing.Size(82, 20);
            this.lblCategoriaProducto.TabIndex = 16;
            this.lblCategoriaProducto.Text = "Categoria:";
            // 
            // txtCategoriaProducto
            // 
            this.txtCategoriaProducto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCategoriaProducto.Location = new System.Drawing.Point(345, 150);
            this.txtCategoriaProducto.Name = "txtCategoriaProducto";
            this.txtCategoriaProducto.Size = new System.Drawing.Size(244, 26);
            this.txtCategoriaProducto.TabIndex = 17;
            // 
            // frmAltaModificacionProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 309);
            this.Controls.Add(this.txtCategoriaProducto);
            this.Controls.Add(this.lblCategoriaProducto);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtPrecioProducto);
            this.Controls.Add(this.txtNombreProducto);
            this.Controls.Add(this.lblPrecioProducto);
            this.Controls.Add(this.lblNombreProducto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(920, 444);
            this.MinimumSize = new System.Drawing.Size(672, 349);
            this.Name = "frmAltaModificacionProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAltaModificacionProducto";
            this.Load += new System.EventHandler(this.frmAltaModificacionProducto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txtPrecioProducto;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.Label lblPrecioProducto;
        private System.Windows.Forms.Label lblNombreProducto;
        private System.Windows.Forms.Label lblCategoriaProducto;
        private System.Windows.Forms.TextBox txtCategoriaProducto;
    }
}