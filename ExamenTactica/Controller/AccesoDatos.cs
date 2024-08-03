using Controller.Querys;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class AccesoDatos
    {
        private QuerysConexion querys;
        public SqlCommand Comando { get; set; }
        public SqlConnection Conexion { get; set; }
        public SqlDataReader Lector { get; set; }

        public AccesoDatos()
        {
            this.Comando = new SqlCommand();
            this.Conexion = new SqlConnection();
            this.querys = new QuerysConexion();

            this.Comando.CommandType = System.Data.CommandType.Text;
            this.Conexion.ConnectionString = this.querys.getConexion();
        }
        public void SetearConsulta(string consulta)
        {
            this.Comando.CommandText = consulta;
        }
        public void SetearParametro(string parametro, object valor)
        {
            this.Comando.Parameters.AddWithValue(parametro, valor);
        }
        public void AbrirConexionEjecutarConsulta()
        {
            try
            {
                Comando.Connection = Conexion;

                Conexion.Open();

                Lector = Comando.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void AbrirConexionEjecutarAccion()
        {
            try
            {
                Comando.Connection = Conexion;

                Conexion.Open();

                Comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void CerrarConexion()
        {
            if (this.Lector != null)
            {
                this.Lector.Close();
            }

            this.Conexion.Close();
        }
    }
}
