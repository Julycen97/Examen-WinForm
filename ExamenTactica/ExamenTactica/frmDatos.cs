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
using Microsoft.Office.Interop.Excel;
using Application = Microsoft.Office.Interop.Excel.Application;

namespace ExamenTactica
{
    public partial class frmDatos : Form
    {
        private int testigo = 0;
        private ClienteNegocio clienNegocio;
        private ProductoNegocio prodNegocio;
        private VentaNegocio ventaNegocio;
        private List<Cliente> clientes;
        private List<Producto> productos;
        private List<Venta> ventas;
        public frmDatos()
        {
            InitializeComponent();

            this.clienNegocio = new ClienteNegocio();
            this.prodNegocio = new ProductoNegocio();
            this.ventaNegocio = new VentaNegocio();
            this.clientes = new List<Cliente>();
            this.productos = new List<Producto>();
            this.ventas = new List<Venta>();
        }

        public frmDatos(int testigo)
        {
            InitializeComponent();

            this.clienNegocio = new ClienteNegocio();
            this.prodNegocio = new ProductoNegocio();
            this.ventaNegocio = new VentaNegocio();
            this.clientes = new List<Cliente>();
            this.productos = new List<Producto>();
            this.ventas = new List<Venta>();
            this.testigo = testigo;
        }
        private void frmDatosClientes_Load(object sender, EventArgs e)
        {
            switch (this.testigo)
            {
                case 1:
                    {
                        this.CargarClientes();

                        this.Text = "Datos Clientes";
                    }
                    break;
                case 2:
                    {
                        this.CargarProductos();

                        this.Text = "Datos Productos";
                    }
                    break;
                case 3:
                    {
                        this.CargarVentas();

                        this.Text = "Datos Ventas";
                    }
                    break;
                default:
                    break;
            }
        }

        private void CargarClientes()
        {
            this.clientes = this.clienNegocio.ObtenerClientes();
            dgvDatos.DataSource = this.clientes;
        }

        private void CargarProductos()
        {
            this.productos = this.prodNegocio.ObtenerProductos();
            dgvDatos.DataSource = this.productos;
        }

        private void CargarVentas()
        {
            this.ventas = this.ventaNegocio.ObtenerVentas();
            dgvDatos.DataSource = this.ventas;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.CurrentRow != null)
            {
                DialogResult resultado = MessageBox.Show("¿Seguro Desea Eliminarlo?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (resultado == DialogResult.Yes)
                {
                    switch (this.testigo)
                    {
                        case 1:
                            {
                                Cliente cliente = new Cliente();

                                cliente = (Cliente)dgvDatos.CurrentRow.DataBoundItem;

                                if (this.clienNegocio.EliminarCliente(0, cliente))
                                {
                                    MessageBox.Show("Se Eliminó el Cliente", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("Error al Eliminar Cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }

                                this.CargarClientes();
                            }
                            break;
                        case 2:
                            {
                                Producto prodto = new Producto();

                                prodto = (Producto)dgvDatos.CurrentRow.DataBoundItem;

                                if (this.prodNegocio.EliminarProducto(0, prodto))
                                {
                                    MessageBox.Show("Se Eliminó el Producto", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("Error al Eliminar Producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }

                                this.CargarProductos();
                            }
                            break;
                        case 3:
                            {
                                Venta venta = new Venta();

                                venta = (Venta)dgvDatos.CurrentRow.DataBoundItem;

                                if (this.ventaNegocio.EliminarVenta(0, venta))
                                {
                                    MessageBox.Show("Se Eliminó La Venta", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("Error Al Eliminar Venta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }

                                this.CargarVentas();
                            }
                            break;
                        default:
                            break;
                    }
                }
            }
            else
            {
                MessageBox.Show("No Seleccionó Un Ítem De La Grilla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //TERMINAR PARA USAR FRM CON CLIENTES Y PRODUCTOS VIENE BIEN
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.CurrentRow != null)
            {
                switch (this.testigo)
                {
                    case 1:
                        {
                            frmAltaModificacionCliente altaModificacionCliente = new frmAltaModificacionCliente((Cliente)dgvDatos.CurrentRow.DataBoundItem);

                            altaModificacionCliente.ShowDialog();

                            this.CargarClientes();
                        }
                        break;
                    case 2:
                        {
                            frmAltaModificacionProducto altaModificacionProducto = new frmAltaModificacionProducto((Producto)dgvDatos.CurrentRow.DataBoundItem);

                            altaModificacionProducto.ShowDialog();

                            this.CargarProductos();
                        }
                        break;
                    case 3:
                        {
                            frmAltaModificacionVenta altaModificacionVenta = new frmAltaModificacionVenta((Venta)dgvDatos.CurrentRow.DataBoundItem);

                            altaModificacionVenta.ShowDialog();

                            this.CargarVentas();
                        }
                        break;
                    default:
                        break;
                }
            }
            else
            {
                MessageBox.Show("No Seleccionó Ningun Elemento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            switch (this.testigo)
            {
                case 1:
                    {
                        List<Cliente> listaFiltrada = clientes.FindAll(X => X.NombreApellido.ToUpper().Contains(txtBuscar.Text.ToUpper()));

                        dgvDatos.DataSource = null;
                        dgvDatos.DataSource = listaFiltrada;
                    }
                    break;
                case 2:
                    {
                        List<Producto> listaFiltrada = productos.FindAll(X => X.Nombre.ToUpper().Contains(txtBuscar.Text.ToUpper()));

                        dgvDatos.DataSource = null;
                        dgvDatos.DataSource = listaFiltrada;
                    }
                    break;
                case 3:
                    {
                        List<Venta> listaFiltrada = ventas.FindAll(X => X.IDV.ToString().ToUpper() == txtBuscar.Text.ToString().ToUpper());

                        dgvDatos.DataSource = null;
                        dgvDatos.DataSource = listaFiltrada;
                    }
                    break;
                default:
                    break;
            }

            txtBuscar.Text = string.Empty;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            //TERMINAR (INSTALAR OFFICE Y PROBAR)
            if (dgvDatos.Rows.Count > 0)
            {
                Application excelApp = new Application();
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "Excel Workbook (*.xlsx)|*.xlsx";
                saveFileDialog1.Title = "Guardar como archivo Excel";
                saveFileDialog1.ShowDialog();

                if (saveFileDialog1.FileName != "")
                {
                    excelApp.Visible = false;//worksheetfor (for (int j = 0; j < dataGridView1worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cellsworkbook.SaveAs(saveFileDialog1.FileName, Excelfalse, false, Excel.XlSaveAsAccessMode.xlexcelApp.Quit();MessageBox.Show("Datos exportados a Excel correctamente.");
                }
            }
            else
            {
                MessageBox.Show("No hay datos para exportar.");
            }
        }
    }
}
