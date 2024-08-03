namespace ExamenTactica
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.msMenuPrincipal = new System.Windows.Forms.MenuStrip();
            this.ttmClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.ttmiVerClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.ttmiAltaCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.ttmProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.ttmiVerProducto = new System.Windows.Forms.ToolStripMenuItem();
            this.ttmiIngresarProducto = new System.Windows.Forms.ToolStripMenuItem();
            this.ttmVentas = new System.Windows.Forms.ToolStripMenuItem();
            this.ttmiVerVentas = new System.Windows.Forms.ToolStripMenuItem();
            this.ttmiAltaVenta = new System.Windows.Forms.ToolStripMenuItem();
            this.ttmInformes = new System.Windows.Forms.ToolStripMenuItem();
            this.ttmiInformeVentas = new System.Windows.Forms.ToolStripMenuItem();
            this.ttmiInformeProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.pbxImgPrincipal = new System.Windows.Forms.PictureBox();
            this.msMenuPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImgPrincipal)).BeginInit();
            this.SuspendLayout();
            // 
            // msMenuPrincipal
            // 
            this.msMenuPrincipal.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.msMenuPrincipal.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.msMenuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ttmClientes,
            this.ttmProductos,
            this.ttmVentas,
            this.ttmInformes});
            this.msMenuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.msMenuPrincipal.Name = "msMenuPrincipal";
            this.msMenuPrincipal.Size = new System.Drawing.Size(1137, 33);
            this.msMenuPrincipal.TabIndex = 1;
            this.msMenuPrincipal.Text = "menuStrip1";
            // 
            // ttmClientes
            // 
            this.ttmClientes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ttmiVerClientes,
            this.ttmiAltaCliente});
            this.ttmClientes.Name = "ttmClientes";
            this.ttmClientes.Size = new System.Drawing.Size(89, 29);
            this.ttmClientes.Text = "Clientes";
            // 
            // ttmiVerClientes
            // 
            this.ttmiVerClientes.Name = "ttmiVerClientes";
            this.ttmiVerClientes.Size = new System.Drawing.Size(228, 34);
            this.ttmiVerClientes.Text = "Ver Clientes";
            this.ttmiVerClientes.Click += new System.EventHandler(this.ttmiVerClientes_Click);
            // 
            // ttmiAltaCliente
            // 
            this.ttmiAltaCliente.Name = "ttmiAltaCliente";
            this.ttmiAltaCliente.Size = new System.Drawing.Size(228, 34);
            this.ttmiAltaCliente.Text = "Alta de Cliente";
            this.ttmiAltaCliente.Click += new System.EventHandler(this.ttmiAltaCliente_Click);
            // 
            // ttmProductos
            // 
            this.ttmProductos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ttmiVerProducto,
            this.ttmiIngresarProducto});
            this.ttmProductos.Name = "ttmProductos";
            this.ttmProductos.Size = new System.Drawing.Size(109, 29);
            this.ttmProductos.Text = "Productos";
            // 
            // ttmiVerProducto
            // 
            this.ttmiVerProducto.Name = "ttmiVerProducto";
            this.ttmiVerProducto.Size = new System.Drawing.Size(256, 34);
            this.ttmiVerProducto.Text = "Ver Productos";
            this.ttmiVerProducto.Click += new System.EventHandler(this.ttmiVerProducto_Click);
            // 
            // ttmiIngresarProducto
            // 
            this.ttmiIngresarProducto.Name = "ttmiIngresarProducto";
            this.ttmiIngresarProducto.Size = new System.Drawing.Size(256, 34);
            this.ttmiIngresarProducto.Text = "Ingresar Producto";
            this.ttmiIngresarProducto.Click += new System.EventHandler(this.ttmiIngresarProducto_Click);
            // 
            // ttmVentas
            // 
            this.ttmVentas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ttmiVerVentas,
            this.ttmiAltaVenta});
            this.ttmVentas.Name = "ttmVentas";
            this.ttmVentas.Size = new System.Drawing.Size(80, 29);
            this.ttmVentas.Text = "Ventas";
            // 
            // ttmiVerVentas
            // 
            this.ttmiVerVentas.Name = "ttmiVerVentas";
            this.ttmiVerVentas.Size = new System.Drawing.Size(219, 34);
            this.ttmiVerVentas.Text = "Ver Ventas";
            this.ttmiVerVentas.Click += new System.EventHandler(this.ttmiVerVentas_Click);
            // 
            // ttmiAltaVenta
            // 
            this.ttmiAltaVenta.Name = "ttmiAltaVenta";
            this.ttmiAltaVenta.Size = new System.Drawing.Size(219, 34);
            this.ttmiAltaVenta.Text = "Alta de Venta";
            this.ttmiAltaVenta.Click += new System.EventHandler(this.ttmiAltaVenta_Click);
            // 
            // ttmInformes
            // 
            this.ttmInformes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ttmiInformeVentas,
            this.ttmiInformeProductos});
            this.ttmInformes.Name = "ttmInformes";
            this.ttmInformes.Size = new System.Drawing.Size(99, 29);
            this.ttmInformes.Text = "Informes";
            // 
            // ttmiInformeVentas
            // 
            this.ttmiInformeVentas.Name = "ttmiInformeVentas";
            this.ttmiInformeVentas.Size = new System.Drawing.Size(288, 34);
            this.ttmiInformeVentas.Text = "Informe de Ventas";
            this.ttmiInformeVentas.Click += new System.EventHandler(this.ttmiInformeVentas_Click);
            // 
            // ttmiInformeProductos
            // 
            this.ttmiInformeProductos.Name = "ttmiInformeProductos";
            this.ttmiInformeProductos.Size = new System.Drawing.Size(288, 34);
            this.ttmiInformeProductos.Text = "Informe de Productos";
            this.ttmiInformeProductos.Click += new System.EventHandler(this.ttmiInformeProductos_Click);
            // 
            // pbxImgPrincipal
            // 
            this.pbxImgPrincipal.Location = new System.Drawing.Point(41, 73);
            this.pbxImgPrincipal.Name = "pbxImgPrincipal";
            this.pbxImgPrincipal.Size = new System.Drawing.Size(1054, 427);
            this.pbxImgPrincipal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxImgPrincipal.TabIndex = 3;
            this.pbxImgPrincipal.TabStop = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 538);
            this.Controls.Add(this.pbxImgPrincipal);
            this.Controls.Add(this.msMenuPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msMenuPrincipal;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1163, 672);
            this.MinimumSize = new System.Drawing.Size(961, 449);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.msMenuPrincipal.ResumeLayout(false);
            this.msMenuPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImgPrincipal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMenuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem ttmClientes;
        private System.Windows.Forms.ToolStripMenuItem ttmiVerClientes;
        private System.Windows.Forms.ToolStripMenuItem ttmProductos;
        private System.Windows.Forms.ToolStripMenuItem ttmVentas;
        private System.Windows.Forms.ToolStripMenuItem ttmInformes;
        private System.Windows.Forms.ToolStripMenuItem ttmiAltaCliente;
        private System.Windows.Forms.ToolStripMenuItem ttmiVerProducto;
        private System.Windows.Forms.ToolStripMenuItem ttmiIngresarProducto;
        private System.Windows.Forms.ToolStripMenuItem ttmiVerVentas;
        private System.Windows.Forms.ToolStripMenuItem ttmiAltaVenta;
        private System.Windows.Forms.ToolStripMenuItem ttmiInformeVentas;
        private System.Windows.Forms.ToolStripMenuItem ttmiInformeProductos;
        private System.Windows.Forms.PictureBox pbxImgPrincipal;
    }
}

