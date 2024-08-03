using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller.Querys
{
    public class QuerysCliente
    {
        private const string insert = "INSERT INTO [clientes] (Cliente, Telefono, Correo) VALUES (@Cliente, @Telefono, @Correo)";
        private const string select = "SELECT ID, Cliente, Telefono, Correo FROM [clientes] ORDER BY ID ASC";
        private const string where = " WHERE ID = @ID";
        private const string update = "UPDATE [clientes] SET Cliente = @Cliente, Telefono = @Telefono, Correo = @Correo" + where;
        private const string delete = "DELETE [clientes]" + where;
        
        private const string ParamCli = "Cliente";
        private const string ParamTel = "Telefono";
        private const string ParamCorr = "Correo";
        private const string ParamID = "ID";

        public string getInsert() {  return insert; }
        public string getSelect() {  return select; }
        public string getWhere() { return where; }
        public string getUpdate() {  return update; }
        public string getDelete() {  return delete; }
        //PARÁMETROS
        public string getParamCli() { return ParamCli; }
        public string getParamTel() {  return ParamTel; }
        public string getParamCorr() {  return ParamCorr; }
        public string getParamID() {  return ParamID; }
    }
}
