using Controller.Querys;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class ProductoNegocio
    {
        private AccesoDatos datos;
        private QuerysProducto querys;

        public List<Producto> ObtenerProductos()
        {
            this.datos = new AccesoDatos();
            this.querys = new QuerysProducto();
            List<Producto> listaRetorno = new List<Producto>();

            try
            {
                this.datos.SetearConsulta(this.querys.getSelect());
                this.datos.AbrirConexionEjecutarConsulta();

                while (this.datos.Lector.Read())
                {
                    Producto auxiliar = new Producto();

                    auxiliar.ID = (int)this.datos.Lector[this.querys.getParamID()] is DBNull ? 0 : (int)this.datos.Lector[this.querys.getParamID()];
                    auxiliar.Nombre = (string)this.datos.Lector[this.querys.getParamNom()] is DBNull ? "No Nombre" : (string)this.datos.Lector[this.querys.getParamNom()];
                    auxiliar.Precio = (double)this.datos.Lector[this.querys.getParamPre()] is DBNull ? 1.0d : (double)this.datos.Lector[this.querys.getParamPre()];
                    auxiliar.Categoria = (string)this.datos.Lector[this.querys.getParamCat()] is DBNull ? "No Categoria" : (string)this.datos.Lector[this.querys.getParamCat()];

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
        public bool VerificarProducto(int ID)
        {
            foreach (Producto X in this.ObtenerProductos())
            {
                if (X.ID == ID)
                {
                    return true;
                }
            }

            return false;
        }
        public Producto ObtenerProducto(int ID)
        {
            if (VerificarProducto(ID))
            {
                return this.ObtenerProductos().Find(X => X.ID == ID);
            }

            return null;
        }
        public bool ModificarProducto(Producto producto)
        {
            this.datos = new AccesoDatos();
            this.querys = new QuerysProducto();

            if (VerificarProducto(producto.ID))
            {
                try
                {
                    this.datos.SetearConsulta(this.querys.getUpdate());

                    this.datos.SetearParametro(this.querys.getParamNom(), producto.Nombre);
                    this.datos.SetearParametro(this.querys.getParamPre(), producto.Precio);
                    this.datos.SetearParametro(this.querys.getParamCat(), producto.Categoria);
                    this.datos.SetearParametro(this.querys.getParamID(), producto.ID);

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
        public bool InsertarProducto(Producto producto)
        {
            this.datos = new AccesoDatos();
            this.querys = new QuerysProducto();

            try
            {
                this.datos.SetearConsulta(this.querys.getInsert());

                this.datos.SetearParametro(this.querys.getParamNom(), producto.Nombre);
                this.datos.SetearParametro(this.querys.getParamPre(), producto.Precio);
                this.datos.SetearParametro(this.querys.getParamCat(), producto.Categoria);

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
        public bool EliminarProducto(int ID = 0, Producto producto = null)
        {
            this.datos = new AccesoDatos();
            this.querys = new QuerysProducto();

            try
            {
                this.datos.SetearConsulta(this.querys.getDelete());

                if (ID != 0)
                {
                    this.datos.SetearParametro(this.querys.getParamID(), ID);
                }
                else if (producto != null)
                {
                    this.datos.SetearParametro(this.querys.getParamID(), producto.ID);
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
