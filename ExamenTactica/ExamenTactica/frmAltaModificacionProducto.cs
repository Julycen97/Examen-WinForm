using Controller;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenTactica
{
    public partial class frmAltaModificacionProducto : Form
    {
        private Producto producto = null;
        private ProductoNegocio prodNegocio;
        public frmAltaModificacionProducto()
        {
            InitializeComponent();
            this.prodNegocio = new ProductoNegocio();
        }
        public frmAltaModificacionProducto(Producto producto)
        {
            InitializeComponent();
            this.prodNegocio = new ProductoNegocio();
            this.producto = producto;
        }

        private void frmAltaModificacionProducto_Load(object sender, EventArgs e)
        {
            if (this.producto != null)
            {
                this.Text = "Modificar Producto";

                txtNombreProducto.Text = this.producto.Nombre;
                txtPrecioProducto.Text = this.producto.Precio.ToString();
                txtCategoriaProducto.Text = this.producto.Categoria;
            }
            else
            {
                this.Text = "Alta Producto";
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool ComprobarTxtVacio(TextBox txt)
        {
            if (txt.Text != string.Empty)
            {
                return true;
            }

            return false;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            txtNombreProducto.BackColor = !this.ComprobarTxtVacio(txtNombreProducto) ? System.Drawing.Color.Red : System.Drawing.Color.White;
            txtPrecioProducto.BackColor = !this.ComprobarTxtVacio(txtPrecioProducto) ? System.Drawing.Color.Red : System.Drawing.Color.White;
            txtCategoriaProducto.BackColor = !this.ComprobarTxtVacio(txtCategoriaProducto) ? System.Drawing.Color.Red : System.Drawing.Color.White;

            if (txtNombreProducto.BackColor != System.Drawing.Color.Red && txtPrecioProducto.BackColor != System.Drawing.Color.Red && txtCategoriaProducto.BackColor != System.Drawing.Color.Red)
            {
                if (this.producto != null)
                {
                    this.producto.Nombre = txtNombreProducto.Text;
                    this.producto.Precio = double.Parse(txtPrecioProducto.Text);
                    this.producto.Categoria = txtCategoriaProducto.Text;

                    if (this.prodNegocio.ModificarProducto(this.producto))
                    {
                        MessageBox.Show("El Producto Ha Sido Modificado Exitosamente", "Modificación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.None);
                    }
                    else
                    {
                        MessageBox.Show("El Producto No Ha Sido Modificado", "Error Modificación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    Producto auxiliar = new Producto();

                    auxiliar.Nombre = txtNombreProducto.Text;
                    auxiliar.Precio = double.Parse(txtPrecioProducto.Text);
                    auxiliar.Categoria = txtCategoriaProducto.Text;

                    if (this.prodNegocio.InsertarProducto(this.producto))
                    {
                        MessageBox.Show("El Producto Ha Sido Agregado Exitosamente", "Modificación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.None);
                    }
                    else
                    {
                        MessageBox.Show("Error Al Agregar Producto", "Error Alta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                this.Close();
            }
            else
            {
                MessageBox.Show("Favor De Completar Los Campos Rojos", "Campos Vacios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtPrecioProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar == 8))
            {
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
