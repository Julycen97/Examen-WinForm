using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller.Querys
{
    public class QuerysVentaItem
    {
        private const string insert = "INSERT INTO [ventasitems] (IDVenta, IDProducto, PrecioUnitario, Cantidad, PrecioTotal) VALUES (@IDVenta, @IDProducto, @PrecioUnitario, @Cantidad, @PrecioTotal)";
        private const string select = "SELECT ID, IDVenta, IDProducto, PrecioUnitario, Cantidad, PrecioTotal FROM [ventasitems] ORDER BY PrecioTotal DESC";
        private const string where = " WHERE ID = @ID";
        private const string update = "UPDATE [ventasitems] SET IDVenta = @IDVenta, IDProducto = @IDProducto, PrecioUnitario = @PrecioUnitario, Cantidad = @Cantidad, PrecioTotal = @PrecioTotal" + where;
        private const string delete = "DELETE [ventasitems]" + where;

        private const string ParamID = "ID";
        private const string ParamIDVen = "IDVenta";
        private const string ParamIDProd = "IDProducto";
        private const string ParamPreUni = "PrecioUnitario";
        private const string ParamCant = "Cantidad";
        private const string ParamPreTot = "PrecioTotal";

        public string getInsert() { return insert; }
        public string getSelect() { return select; }
        public string getWhere() { return where; }
        public string getUpdate() { return update; }
        public string getDelete() { return delete; }
        //PARÁMETROS
        public string getParamID() { return ParamID; }
        public string getParamIDVen() { return ParamIDVen; }
        public string getParamIDProd() { return ParamIDProd; }
        public string getParamPreUni() { return ParamPreUni; }
        public string getParamCant() { return ParamCant; }
        public string getParamPreTot() { return ParamPreTot; }
    }
}
