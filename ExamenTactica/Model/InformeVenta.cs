using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class InformeVenta
    {
        [DisplayName("Nombre Cliente")]
        public string Cliente { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public DateTime Fecha { get; set; }
        [DisplayName("Nombre Producto")]
        public string NombreProd { get; set; }
        [DisplayName("Precio Unitario")]
        public double PrecioUni { get; set; }
        public string Categoria { get; set; }
        public double Total { get; set; }
    }
}
