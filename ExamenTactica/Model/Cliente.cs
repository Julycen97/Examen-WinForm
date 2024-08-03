using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Cliente
    {
        [DisplayName("ID Cliente")]
        public int ID { get; set; }
        [DisplayName("Nombre y Apellido")]
        public string NombreApellido { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }

        public Cliente()
        {
            this.ID = 0;
            this.NombreApellido = "No Nombre";
            this.Telefono = "11-11111111";
            this.Correo = "admin@example.com";
        }
        public Cliente(int ID, string NombreApellido, string Telefono, string Correo)
        {
            this.ID = ID;
            this.NombreApellido = NombreApellido;
            this.Telefono = Telefono;
            this.Correo = Correo;
        }

        public override string ToString()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.Append("ID Cliente:        " + this.ID + "\n");
            retorno.Append("Nombre y Apellido: " + this.NombreApellido + "\n");
            retorno.Append("Telefono:          " + this.Telefono + "\n");
            retorno.Append("Correo:            " + this.Correo);
             
            return retorno.ToString();
        }
    }
}
