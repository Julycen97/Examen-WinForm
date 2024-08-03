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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void ttmiVerClientes_Click(object sender, EventArgs e)
        {
            frmDatos frmDatosClientes = new frmDatos(1);

            frmDatosClientes.ShowDialog();
        }

        private void ttmiAltaCliente_Click(object sender, EventArgs e)
        {
            frmAltaModificacionCliente frmAltaoModi = new frmAltaModificacionCliente();

            frmAltaoModi.ShowDialog();
        }

        private void ttmiVerProducto_Click(object sender, EventArgs e)
        {
            frmDatos frmProductos = new frmDatos(2);

            frmProductos.ShowDialog();
        }

        private void ttmiIngresarProducto_Click(object sender, EventArgs e)
        {
            frmAltaModificacionProducto altaModificacionProducto = new frmAltaModificacionProducto();

            altaModificacionProducto.ShowDialog();
        }

        private void ttmiInformeVentas_Click(object sender, EventArgs e)
        {
            frmInformes informeVentas = new frmInformes();

            informeVentas.ShowDialog();
        }

        private void ttmiInformeProductos_Click(object sender, EventArgs e)
        {
            frmInformes informeVentas = new frmInformes(new Model.InformeVentaProducto());

            informeVentas.ShowDialog();
        }

        private void ttmiVerVentas_Click(object sender, EventArgs e)
        {
            frmDatos frmVentas = new frmDatos(3);

            frmVentas.ShowDialog();
        }

        private void ttmiAltaVenta_Click(object sender, EventArgs e)
        {
            frmAltaModificacionVenta altaModificacionVenta = new frmAltaModificacionVenta();

            altaModificacionVenta.ShowDialog();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                pbxImgPrincipal.Load("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRF-wXjxacFZmNAGUrmSLIh4YxgFtppU4g4TQ&s");
            }
            catch (Exception)
            {
                pbxImgPrincipal.Load("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcS1f4C-cWV03_czRXhL1THkOdS9RDnAtPxRnA&s");
            }
        }
    }
}
