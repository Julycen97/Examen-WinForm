using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Venta
    {
        [DisplayName("ID Venta")]
        public int IDV { get; set; }
        [DisplayName("ID Cliente")]
        public int IDCliente { get; set; }
        public DateTime Fecha { get; set; }
        public double Total { get; set; }

        public Venta()
        {
            this.IDV = 0;
            this.IDCliente = 0;
            this.Fecha = new DateTime();
            this.Total = 0;
        }

        public Venta(int ID, int IDCliente, DateTime Fecha, double Total)
        {
            this.IDV = ID;
            this.IDCliente = IDCliente;
            this.Fecha = Fecha;
            this.Total = Total;
        }

        public override string ToString()
        {
            StringBuilder retorno = new StringBuilder();
            retorno.Append("ID Venta:  " + this.IDV + "\n");
            retorno.Append("IDCliente: " + this.IDCliente + "\n");
            retorno.Append("Fecha:     " + this.Fecha + "\n");
            retorno.Append("Total:     " + this.Total);

            return retorno.ToString();
        }
    }
}
