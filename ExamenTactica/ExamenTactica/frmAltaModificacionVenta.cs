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
    public partial class frmAltaModificacionVenta : Form
    {
        private Venta venta = null;
        private VentaNegocio ventaNegocio;
        public frmAltaModificacionVenta()
        {
            InitializeComponent();
            this.ventaNegocio = new VentaNegocio();
        }

        public frmAltaModificacionVenta(Venta venta)
        {
            InitializeComponent();
            this.ventaNegocio = new VentaNegocio();
            this.venta = venta;
        }

        private void frmAltaModificacionVenta_Load(object sender, EventArgs e)
        {
            if (this.venta != null)
            {
                this.Text = "Modificar Venta";

                txtIDCliente.Text = this.venta.IDCliente.ToString();
                txtFecha.Text = this.venta.Fecha.ToString();
                txtTotal.Text = this.venta.Total.ToString();
            }
            else
            {
                this.Text = "Alta Venta";
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
            txtIDCliente.BackColor = !this.ComprobarTxtVacio(txtIDCliente) ? System.Drawing.Color.Red : System.Drawing.Color.White;
            txtFecha.BackColor = !this.ComprobarTxtVacio(txtFecha) ? System.Drawing.Color.Red : System.Drawing.Color.White;
            txtTotal.BackColor = !this.ComprobarTxtVacio(txtTotal) ? System.Drawing.Color.Red : System.Drawing.Color.White;

            if (txtIDCliente.BackColor != System.Drawing.Color.Red && txtFecha.BackColor != System.Drawing.Color.Red && txtTotal.BackColor != System.Drawing.Color.Red)
            {
                if (this.venta != null)
                {
                    this.venta.IDCliente = int.Parse(txtIDCliente.Text);
                    this.venta.Fecha = DateTime.Parse(txtFecha.Text);
                    this.venta.Total = double.Parse(txtTotal.Text);

                    if (this.ventaNegocio.ModificarVenta(this.venta))
                    {
                        MessageBox.Show("La Venta Ha Sido Modificada Exitosamente", "Modificación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.None);
                    }
                    else
                    {
                        MessageBox.Show("La Venta No Ha Sido Modificada", "Error Modificación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    Venta auxiliar = new Venta();

                    auxiliar.IDCliente = int.Parse(txtIDCliente.Text);
                    auxiliar.Fecha = DateTime.Parse(txtFecha.Text);
                    auxiliar.Total = double.Parse(txtTotal.Text);

                    if (this.ventaNegocio.ModificarVenta(this.venta))
                    {
                        MessageBox.Show("La Venta Ha Sido Agregada Exitosamente", "Modificación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.None);
                    }
                    else
                    {
                        MessageBox.Show("Error Al Agregar Venta", "Error Alta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                this.Close();
            }
            else
            {
                MessageBox.Show("Favor De Completar Los Campos Rojos", "Campos Vacios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtTotal_KeyPress(object sender, KeyPressEventArgs e)
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
