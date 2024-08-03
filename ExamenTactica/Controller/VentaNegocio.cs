using Controller.Querys;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class VentaNegocio
    {
        private AccesoDatos datos;
        private QuerysVenta querys;

        public List<Venta> ObtenerVentas()
        {
            this.datos = new AccesoDatos();
            this.querys = new QuerysVenta();
            List<Venta> listaRetorno = new List<Venta>();

            try
            {
                this.datos.SetearConsulta(this.querys.getSelect());
                this.datos.AbrirConexionEjecutarConsulta();

                while (this.datos.Lector.Read())
                {
                    Venta auxiliar = new Venta();

                    auxiliar.IDV = (int)this.datos.Lector[this.querys.getParamID()] is DBNull ? 0 : (int)this.datos.Lector[this.querys.getParamID()];
                    auxiliar.IDCliente = (int)this.datos.Lector[this.querys.getParamIDCli()] is DBNull ? 0 : (int)this.datos.Lector[this.querys.getParamIDCli()];
                    auxiliar.Fecha = (DateTime)this.datos.Lector[this.querys.getParamFech()] is DBNull ? new DateTime(1, 1, 1900) : (DateTime)this.datos.Lector[this.querys.getParamFech()];
                    auxiliar.Total = (double)this.datos.Lector[this.querys.getParamTot()] is DBNull ? 0 : (double)this.datos.Lector[this.querys.getParamTot()];

                    listaRetorno.Add(auxiliar);
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
        public bool VerificarVenta(int IDV)
        {
            foreach (Venta X in this.ObtenerVentas())
            {
                if (X.IDV == IDV)
                {
                    return true;
                }
            }

            return false;
        }
        public Venta ObtenerVenta(int IDV)
        {
            if (this.VerificarVenta(IDV))
            {
                return this.ObtenerVentas().Find(X => X.IDV == IDV);
            }

            return null;
        }
        public bool ModificarVenta(Venta venta)
        {
            this.datos = new AccesoDatos();
            this.querys = new QuerysVenta();

            if (this.VerificarVenta(venta.IDV))
            {
                try
                {
                    this.datos.SetearConsulta(this.querys.getUpdate());

                    this.datos.SetearParametro(this.querys.getParamIDCli(), venta.IDCliente);
                    this.datos.SetearParametro(this.querys.getParamFech(), venta.Fecha);
                    this.datos.SetearParametro(this.querys.getParamTot(), venta.Total);
                    this.datos.SetearParametro(this.querys.getParamID(), venta.IDV);

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
        public bool InsertearVenta(Venta venta)
        {
            this.datos = new AccesoDatos();
            this.querys = new QuerysVenta();

            try
            {
                this.datos.SetearConsulta(this.querys.getInsert());

                this.datos.SetearParametro(this.querys.getParamIDCli(), venta.IDCliente);
                this.datos.SetearParametro(this.querys.getParamFech(), venta.Fecha);
                this.datos.SetearParametro(this.querys.getParamTot(), venta.Total);

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
        public bool EliminarVenta(int IDV = 0, Venta venta = null)
        {
            this.datos = new AccesoDatos();
            this.querys = new QuerysVenta();

            try
            {
                this.datos.SetearConsulta(this.querys.getDelete());

                if (IDV != 0)
                {
                    this.datos.SetearParametro(this.querys.getParamID(), IDV);
                }
                else if (venta != null)
                {
                    this.datos.SetearParametro(this.querys.getParamID(), venta.IDV);
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
