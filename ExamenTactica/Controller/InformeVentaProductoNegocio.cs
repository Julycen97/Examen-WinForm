using Controller.Querys;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class InformeVentaProductoNegocio
    {
        private AccesoDatos datos;
        private QuerysInforme querys;

        public List<InformeVentaProducto> ObtenerVentasProductos()
        {
            this.datos = new AccesoDatos();
            this.querys = new QuerysInforme();
            List<InformeVentaProducto> listaRetorno = new List<InformeVentaProducto>();

            try
            {
                this.datos.SetearConsulta(this.querys.getInformeVentasProd());
                this.datos.AbrirConexionEjecutarConsulta();

                while (this.datos.Lector.Read())
                {
                    InformeVentaProducto auxiliar = new InformeVentaProducto();

                    auxiliar.ID = (int)this.datos.Lector[this.querys.getParamID()] is DBNull ? 0 : (int)this.datos.Lector[this.querys.getParamID()];
                    auxiliar.Nombre = (string)this.datos.Lector[this.querys.getParamNom()] is DBNull ? "No Nombre" : (string)this.datos.Lector[this.querys.getParamNom()];
                    auxiliar.Precio = (double)this.datos.Lector[this.querys.getParamPre()] is DBNull ? 1.0d : (double)this.datos.Lector[this.querys.getParamPre()];
                    auxiliar.Categoria = (string)this.datos.Lector[this.querys.getParamCat()] is DBNull ? "No Categoria" : (string)this.datos.Lector[this.querys.getParamCat()];
                    auxiliar.CantVendida = (int)this.datos.Lector[this.querys.getParamCant()] is DBNull ? 0 : (int)this.datos.Lector[this.querys.getParamCant()];

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
