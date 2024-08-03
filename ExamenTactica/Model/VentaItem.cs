using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class VentaItem : Venta
    {
        [DisplayName("ID Venta Item")]
        public int IDVI { get; set; }
        public Producto Prodto { get; set; }
        [DisplayName("Precio Unitario")]
        public float PrecioUnitario { get; set; }
        public float Cantidad { get; set; }
        [DisplayName("Precio Total")]
        public float PrecioTotal { get; set; }

        public VentaItem()
        {
            this.IDV = 0;
            this.IDCliente = 0;
            this.Fecha = new DateTime() ;
            this.Total = 0;

            this.IDVI = 0;
            this.Prodto = new Producto();
            this.PrecioUnitario = 0;
            this.Cantidad = 0;
            this.PrecioTotal = 0;
        }

        public VentaItem(int IDVI, Venta Vta, Producto Prodto, float PrecioUnitario, float Cantidad, float PrecioTotal)
        {
            this.IDV = Vta.IDV;
            this.IDCliente = Vta.IDCliente;
            this.Fecha = Vta.Fecha;
            this.Total = Vta.Total;

            this.IDVI = IDVI;
            this.Prodto = Prodto;
            this.PrecioUnitario = PrecioUnitario;
            this.Cantidad = Cantidad;
            this.PrecioTotal = PrecioTotal;
        }

        public override string ToString()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.Append("ID:              " + this.IDVI + "\n");
            retorno.Append(base.ToString() + "\n");
            retorno.Append(this.Prodto.ToString() + "\n");
            retorno.Append("Precio Unitario: " + this.PrecioUnitario);
            retorno.Append("Cantidad:        " + this.Cantidad + "\n");
            retorno.Append("Precio Total:    " + this.PrecioTotal + "\n");

            return retorno.ToString();
        }
    }
}
