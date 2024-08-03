using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller.Querys
{
    public class QuerysVenta
    {
        private const string insert = "INSERT INTO [ventas] (IDCliente, Fecha, Total) VALUES (@IDCliente, @Fecha, @Total)";
        private const string select = "SELECT ID, IDCliente, Fecha, Total FROM [ventas] ORDER BY Fecha ASC";
        private const string where = " WHERE ID = @ID";
        private const string update = "UPDATE [ventas] SET IDCliente = @IDCliente, Fecha = @Fecha, Total = @Total" + where;
        private const string delete = "DELETE [ventas]" + where;

        private const string ParamID = "ID";
        private const string ParamIDCli = "IDCliente";
        private const string ParamFech = "Fecha";
        private const string ParamTot = "Total";

        public string getInsert() { return insert; }
        public string getSelect() { return select; }
        public string getWhere() { return where; }
        public string getUpdate() { return update; }
        public string getDelete() { return delete; }
        //PARÁMETROS
        public string getParamID() { return ParamID; }
        public string getParamIDCli() { return ParamIDCli; }
        public string getParamFech() { return ParamFech; }
        public string getParamTot() { return ParamTot; }
    }                         
}
