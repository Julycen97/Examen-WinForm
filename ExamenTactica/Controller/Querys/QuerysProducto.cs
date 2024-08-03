using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Controller.Querys
{
    public class QuerysProducto
    {
        private const string insert = "INSERT INTO [productos] (Nombre, Precio, Categoria) VALUES (@Nombre, @Precio, @Categoria)";
        private const string select = "SELECT ID, Nombre, Precio, Categoria FROM [productos] ORDER BY Nombre ASC";
        private const string where = " WHERE ID = @ID";
        private const string update = "UPDATE [productos] SET Nombre = @Nombre, Precio = @Precio, Categoria = @Categoria" + where;
        private const string delete = "DELETE [productos]" + where;

        private const string ParamID = "ID";
        private const string ParamNom = "Nombre";
        private const string ParamPre = "Precio";
        private const string ParamCat = "Categoria";

        public string getInsert() { return insert; }
        public string getSelect(){ return select;}
        public string getWhere(){ return where;}
        public string getUpdate(){ return update;}
        public string getDelete(){ return delete;}
        //PARÁMETROS
        public string getParamID(){ return ParamID;}
        public string getParamNom(){ return ParamNom;}
        public string getParamPre (){ return ParamPre;}
        public string getParamCat(){ return ParamCat;}
    }
}
