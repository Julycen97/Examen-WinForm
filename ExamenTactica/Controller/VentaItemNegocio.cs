using Controller.Querys;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class VentaItemNegocio
    {
        private AccesoDatos datos;
        private QuerysVentaItem querys;

        public List<VentaItem> ObtenerVentasItem()
        {
            this.datos = new AccesoDatos();
            this.querys = new QuerysVentaItem();

            List<VentaItem> listaRetorno = new List<VentaItem>();
            VentaNegocio ventNegocio = new VentaNegocio();
            ProductoNegocio prodNegocio = new ProductoNegocio();

            try
            {
                this.datos.SetearConsulta(this.querys.getSelect());
                this.datos.AbrirConexionEjecutarConsulta();

                while (this.datos.Lector.Read())
                {
                    VentaItem ventaItem = new VentaItem();
                    Venta ventAux = new VentaItem();

                    ventaItem.IDVI = (int)this.datos.Lector[this.querys.getParamID()] is DBNull ? 0 : (int)this.datos.Lector[this.querys.getParamID()];
                    ventaItem.PrecioUnitario = (float)this.datos.Lector[this.querys.getParamPreUni()] is DBNull ? 0 : (float)this.datos.Lector[this.querys.getParamPreUni()];
                    ventaItem.Cantidad = (float)this.datos.Lector[this.querys.getParamCant()] is DBNull ? 0 : (float)this.datos.Lector[this.querys.getParamCant()];
                    ventaItem.PrecioTotal = (float)this.datos.Lector[this.querys.getParamPreTot()] is DBNull ? 0 : (float)this.datos.Lector[this.querys.getParamPreTot()];

                    ventaItem.Prodto = prodNegocio.ObtenerProducto((int)this.datos.Lector[this.querys.getParamIDProd()]);
                    ventAux = ventNegocio.ObtenerVenta((int)this.datos.Lector[this.querys.getParamIDVen()]);

                    ventaItem.IDV = ventAux.IDV;
                    ventaItem.IDCliente = ventAux.IDCliente;
                    ventaItem.Fecha = ventAux.Fecha;
                    ventaItem.Total = ventAux.Total;

                    listaRetorno.Add(ventaItem);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.datos.CerrarConexion();
            }

            return listaRetorno;
        }
        public bool VerificarVentaItem(int IDVI)
        {
            foreach (VentaItem X in this.ObtenerVentasItem())
            {
                if (X.IDVI == IDVI)
                {
                    return true;
                }
            }

            return false;
        }
        public VentaItem ObtenerVentaItem(int IDVI)
        {
            if (this.VerificarVentaItem(IDVI))
            {
                return this.ObtenerVentasItem().Find(X => X.IDVI == IDVI);
            }

            return null;
        }
        public bool ModificarVentaItem(VentaItem ventaItem)
        {
            this.datos = new AccesoDatos();
            this.querys = new QuerysVentaItem();

            if (this.VerificarVentaItem(ventaItem.IDV))
            {
                try
                {
                    this.datos.SetearConsulta(this.querys.getUpdate());

                    this.datos.SetearParametro(this.querys.getParamIDVen(), ventaItem.IDV);
                    this.datos.SetearParametro(this.querys.getParamIDProd(), ventaItem.Prodto.ID);
                    this.datos.SetearParametro(this.querys.getParamPreUni(), ventaItem.PrecioUnitario);
                    this.datos.SetearParametro(this.querys.getParamCant(), ventaItem.Cantidad);
                    this.datos.SetearParametro(this.querys.getParamPreTot(), ventaItem.PrecioTotal);
                    this.datos.SetearParametro(this.querys.getParamID(), ventaItem.IDVI);

                    this.datos.AbrirConexionEjecutarAccion();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    this.datos.CerrarConexion();
                }

                return true;
            }

            return false;
        }
        public bool InsertearVentaItem(VentaItem ventaItem)
        {
            this.datos = new AccesoDatos();
            this.querys = new QuerysVentaItem();

            try
            {
                this.datos.SetearConsulta(this.querys.getInsert());

                this.datos.SetearParametro(this.querys.getParamIDVen(), ventaItem.IDV);
                this.datos.SetearParametro(this.querys.getParamIDProd(), ventaItem.Prodto.ID);
                this.datos.SetearParametro(this.querys.getParamPreUni(), ventaItem.PrecioUnitario);
                this.datos.SetearParametro(this.querys.getParamCant(), ventaItem.Cantidad);
                this.datos.SetearParametro(this.querys.getParamPreTot(), ventaItem.PrecioTotal);

                this.datos.AbrirConexionEjecutarAccion();

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.datos.CerrarConexion();
            }
        }
        public bool EliminarVentaItem(int IDVI = 0, VentaItem ventaItem = null)
        {
            this.datos = new AccesoDatos();
            this.querys = new QuerysVentaItem();

            try
            {
                this.datos.SetearConsulta(this.querys.getDelete());

                if (IDVI != 0)
                {
                    this.datos.SetearParametro(this.querys.getParamID(), IDVI);
                }
                else if (ventaItem != null)
                {
                    this.datos.SetearParametro(this.querys.getParamID(), ventaItem.IDVI);
                }
                else
                {
                    this.datos.CerrarConexion();

                    return false;
                }

                this.datos.AbrirConexionEjecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.datos.CerrarConexion();
            }

            return true;
        }
    }
}
