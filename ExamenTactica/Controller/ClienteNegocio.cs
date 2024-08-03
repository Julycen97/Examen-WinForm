using Controller.Querys;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class ClienteNegocio
    {
        private AccesoDatos datos;
        private QuerysCliente querys;

        public List<Cliente> ObtenerClientes()
        {
            this.datos = new AccesoDatos();
            this.querys = new QuerysCliente();
            List<Cliente> listaRetorno = new List<Cliente>();

            try
            {
                this.datos.SetearConsulta(this.querys.getSelect());
                this.datos.AbrirConexionEjecutarConsulta();

                while (this.datos.Lector.Read())
                {
                    Cliente auxiliar = new Cliente();

                    auxiliar.ID = (int)this.datos.Lector[this.querys.getParamID()] is DBNull ? 0 : (int)this.datos.Lector[this.querys.getParamID()];
                    auxiliar.NombreApellido = (string)this.datos.Lector[this.querys.getParamCli()] is DBNull ? "No Nombre" : (string)this.datos.Lector[this.querys.getParamCli()];
                    auxiliar.Telefono = (string)this.datos.Lector[this.querys.getParamTel()] is DBNull ? "No Telefono" : (string)this.datos.Lector[this.querys.getParamTel()];
                    auxiliar.Correo = (string)this.datos.Lector[this.querys.getParamCorr()] is DBNull ? "No Correo" : (string)this.datos.Lector[this.querys.getParamCorr()];
                
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
        public bool VerificarCliente(int ID)
        {
            foreach (Cliente X in this.ObtenerClientes())
            {
                if (X.ID == ID)
                {
                    return true;
                }
            }

            return false;
        }
        public Cliente ObtenerCliente(int ID)
        {
            if (this.VerificarCliente(ID))
            {
                return this.ObtenerClientes().Find(X => X.ID == ID);
            }

            return null;
        }
        public bool ModificarCliente(Cliente cliente)
        {
            this.datos = new AccesoDatos();
            this.querys = new QuerysCliente();

            if (this.VerificarCliente(cliente.ID))
            {
                try
                {
                    this.datos.SetearConsulta(this.querys.getUpdate());

                    this.datos.SetearParametro(this.querys.getParamCli(), cliente.NombreApellido);
                    this.datos.SetearParametro(this.querys.getParamTel(), cliente.Telefono);
                    this.datos.SetearParametro(this.querys.getParamCorr(), cliente.Correo);
                    this.datos.SetearParametro(this.querys.getParamID(), cliente.ID);

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
        public bool InsertearCliente(Cliente cliente)
        {
            this.datos = new AccesoDatos();
            this.querys = new QuerysCliente();

            try
            {
                this.datos.SetearConsulta(this.querys.getInsert());

                this.datos.SetearParametro(this.querys.getParamCli(), cliente.NombreApellido);
                this.datos.SetearParametro(this.querys.getParamTel(), cliente.Telefono);
                this.datos.SetearParametro(this.querys.getParamCorr(), cliente.Correo);

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
        public bool EliminarCliente(int ID = 0, Cliente cliente = null)
        {
            this.datos = new AccesoDatos();
            this.querys = new QuerysCliente();

            try
            {
                this.datos.SetearConsulta(this.querys.getDelete());

                if (ID != 0)
                {
                    this.datos.SetearParametro(this.querys.getParamID(), ID);
                }
                else if (cliente != null)
                {
                    this.datos.SetearParametro(this.querys.getParamID(), cliente.ID);
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
