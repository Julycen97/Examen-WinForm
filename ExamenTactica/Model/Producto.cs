using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Producto
    {
        [DisplayName("ID Producto")]
        public int ID { get; set; }
        public string Nombre { get; set; }
        public double Precio { get; set; }
        public string Categoria { get; set; }

        public Producto()
        {
            this.ID = 0;
            this.Nombre = "No Nombre";
            this.Precio = 0;
            this.Categoria = "No Categoria";
        }

        public Producto(int ID, string Nombre, double Precio, string Categoria)
        {
            this.ID = ID;
            this.Nombre = Nombre;
            this.Precio = Precio;
            this.Categoria = Categoria;
        }

        public override string ToString()
        {
            StringBuilder retorno = new StringBuilder();
            retorno.Append("ID Producto: " + this.ID + "\n");
            retorno.Append("Nombre:      " + this.Nombre + "\n");
            retorno.Append("Precio:      " + this.Precio + "\n");
            retorno.Append("Categoria:   " + this.Categoria);

            return retorno.ToString();
        }
    }
}
