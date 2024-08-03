using Controller.Querys;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class InformeVentaNegocio
    {
        private AccesoDatos datos;
        private QuerysInforme querys;

        public List<InformeVenta> ObtenerVentas()
        {
            this.datos = new AccesoDatos();
            this.querys = new QuerysInforme();
            List<InformeVenta> listaRetorno = new List<InformeVenta>();

            try
            {
                this.datos.SetearConsulta(this.querys.getInformeVentas());
                this.datos.AbrirConexionEjecutarConsulta();

                while (this.datos.Lector.Read())
                {
                    InformeVenta auxiliar = new InformeVenta();

                    auxiliar.Cliente = (string)this.datos.Lector[this.querys.getParamCli()] is DBNull ? "No Cliente" : (string)this.datos.Lector[this.querys.getParamCli()];
                    auxiliar.Telefono = (string)this.datos.Lector[this.querys.getParamTel()] is DBNull ? "No Teléfono" : (string)this.datos.Lector[this.querys.getParamTel()];
                    auxiliar.Correo = (string)this.datos.Lector[this.querys.getParamCorr()] is DBNull ? "No Correo" : (string)this.datos.Lector[this.querys.getParamCorr()];
                    auxiliar.Fecha = (DateTime)this.datos.Lector[this.querys.getParamFech()] is DBNull ? new DateTime(1, 1, 1900) : (DateTime)this.datos.Lector[this.querys.getParamFech()];
                    auxiliar.NombreProd = (string)this.datos.Lector[this.querys.getParamNomProd()] is DBNull ? "No Nombre Producto" : (string)this.datos.Lector[this.querys.getParamNomProd()];
                    auxiliar.PrecioUni = (double)this.datos.Lector[this.querys.getParamPreUni()] is DBNull ? 1.0d : (double)this.datos.Lector[this.querys.getParamPreUni()];
                    auxiliar.Categoria = (string)this.datos.Lector[this.querys.getParamCat()] is DBNull ? "No Categoria" : (string)this.datos.Lector[this.querys.getParamCat()];
                    auxiliar.Total = (double)this.datos.Lector[this.querys.getParamTot()] is DBNull ? 1.0d : (double)this.datos.Lector[this.querys.getParamTot()];

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
    }
}
