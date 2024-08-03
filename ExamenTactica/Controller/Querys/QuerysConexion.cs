using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller.Querys
{
    public class QuerysConexion
    {
        private const string conexion = "server= .\\SQLEXPRESS; database= pruebademo; integrated security= true";

        public string getConexion() {  return conexion; }
    }
}
