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
    public partial class frmInformes : Form
    {
        private InformeVentaProducto informeVentaProducto = null;
        private InformeVentaNegocio IVNegocio;
        private List<InformeVenta> InformeVentas;
        List<InformeVentaProducto> ventasProd;
        public frmInformes()
        {
            InitializeComponent();
            this.IVNegocio = new InformeVentaNegocio();
            this.InformeVentas = new List<InformeVenta>();
        }
        public frmInformes(InformeVentaProducto informeVentaProducto)
        {
            InitializeComponent();
            this.IVNegocio = new InformeVentaNegocio();
            this.InformeVentas = new List<InformeVenta>();
            this.informeVentaProducto = informeVentaProducto;
        }


        private void frmInformeVentas_Load(object sender, EventArgs e)
        {
            if (this.informeVentaProducto != null)
            {
                this.Text = "Informe De Productos";

                InformeVentaProductoNegocio IVPNeg = new InformeVentaProductoNegocio();

                this.ventasProd = IVPNeg.ObtenerVentasProductos();
                dgvDatosVentas.DataSource = this.ventasProd;
            }
            else
            {
                this.Text = "Informe De Ventas";

                this.InformeVentas = this.IVNegocio.ObtenerVentas();
                dgvDatosVentas.DataSource = this.InformeVentas;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (this.informeVentaProducto != null)
            {
                List<InformeVentaProducto> listaFiltrada = this.ventasProd.FindAll(X => X.Nombre.ToUpper().Contains(txtBuscar.Text.ToUpper()));

                dgvDatosVentas.DataSource = null;
                dgvDatosVentas.DataSource = listaFiltrada;
            }
            else
            {
                List<InformeVenta> listaFiltrada = InformeVentas.FindAll(X => X.Cliente.ToUpper().Contains(txtBuscar.Text.ToUpper()) || X.NombreProd.ToUpper().Contains(txtBuscar.Text.ToUpper()));

                dgvDatosVentas.DataSource = null;
                dgvDatosVentas.DataSource = listaFiltrada;

            }

            txtBuscar.Text = string.Empty;
        }
    }
}
