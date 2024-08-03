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
    public partial class frmAltaModificacionCliente : Form
    {
        private Cliente cliente = null;
        private ClienteNegocio clienNegocio;
        public frmAltaModificacionCliente()
        {
            InitializeComponent();

            this.clienNegocio = new ClienteNegocio();
        }

        public frmAltaModificacionCliente(Cliente cliente)
        {
            InitializeComponent();

            this.cliente = cliente;
            this.clienNegocio = new ClienteNegocio();
        }

        private void frmAltaModificacionCliente_Load(object sender, EventArgs e)
        {
            if (this.cliente != null)
            {
                this.Text = "Modificar Cliente";

                txtNombreyApellido.Text = this.cliente.NombreApellido;
                txtTelefono.Text = this.cliente.Telefono;
                txtCorreo.Text = this.cliente.Correo;
            }
            else
            {
                this.Text = "Alta Cliente";
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
            txtNombreyApellido.BackColor = !this.ComprobarTxtVacio(txtNombreyApellido) ? System.Drawing.Color.Red : System.Drawing.Color.White;
            txtTelefono.BackColor = !this.ComprobarTxtVacio(txtTelefono) ? System.Drawing.Color.Red : System.Drawing.Color.White;
            txtCorreo.BackColor = !this.ComprobarTxtVacio(txtCorreo) ? System.Drawing.Color.Red : System.Drawing.Color.White;

            if(txtNombreyApellido.BackColor != System.Drawing.Color.Red && txtTelefono.BackColor != System.Drawing.Color.Red && txtCorreo.BackColor != System.Drawing.Color.Red)
            {
                if (this.cliente != null)
                {
                    this.cliente.NombreApellido = txtNombreyApellido.Text;
                    this.cliente.Telefono = txtTelefono.Text;
                    this.cliente.Correo = txtCorreo.Text;

                    if (this.clienNegocio.ModificarCliente(this.cliente))
                    {
                        MessageBox.Show("El Cliente Ha Sido Modificado Exitosamente", "Modificación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.None);
                    }
                    else
                    {
                        MessageBox.Show("El Cliente No Ha Sido Modificado", "Error Modificacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    Cliente auxiliar = new Cliente();

                    auxiliar.NombreApellido = txtNombreyApellido.Text;
                    auxiliar.Telefono = txtTelefono.Text;
                    auxiliar.Correo = txtCorreo.Text;

                    if (this.clienNegocio.InsertearCliente(auxiliar))
                    {
                        MessageBox.Show("El Cliente Ha Sido Agregado Exitosamente", "Alta Exitosa", MessageBoxButtons.OK, MessageBoxIcon.None);
                    }
                    else
                    {
                        MessageBox.Show("Error Al Agregar El Cliente", "Error Alta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                this.Close();
            }
            else
            {
                MessageBox.Show("Favor De Completar Los Campos Rojos", "Campos Vacios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
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
