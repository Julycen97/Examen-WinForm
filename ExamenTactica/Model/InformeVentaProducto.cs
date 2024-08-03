using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class InformeVentaProducto : Producto
    {
        [DisplayName("Cantidad Vendida Ultimo Mes")]
        public int CantVendida { get; set; }
    }
}
