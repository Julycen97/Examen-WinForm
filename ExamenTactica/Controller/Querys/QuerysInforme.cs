using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Controller.Querys
{
    public class QuerysInforme
    {
        private const string informeVentas = "SELECT [C].Cliente, [C].Telefono, [C].Correo, [V].Fecha AS FechaVenta, [P].Nombre AS NombreProducto, [VI].PrecioUnitario, [P].Categoria, [V].Total FROM [dbo].[ventas] AS [V] INNER JOIN [dbo].[clientes] AS [C] ON [V].IDCliente = [C].ID INNER JOIN [dbo].[ventasitems] AS [VI] ON [V].ID = [VI].IDVenta INNER JOIN [dbo].[productos] AS [P] ON [VI].IDProducto = [P].ID";
        private const string informeVentasProd = "SELECT [P].ID, [P].Nombre, [P].Precio, [P].Categoria, COALESCE((SELECT COUNT([VI].ID) AS Cantidad FROM [ventas] AS [V] INNER JOIN [ventasitems] AS [VI] ON [V].ID = [VI].IDVenta  WHERE MONTH([V].Fecha) = MONTH(GETDATE()) GROUP BY [VI].IDProducto HAVING [VI].IDProducto = [P].ID), 0) AS CantVendidaUltimoMes FROM [dbo].[productos] AS [P]";

        private const string ParamID = "ID";
        private const string ParamCli = "Cliente";
        private const string ParamTel = "Telefono";
        private const string ParamCorr = "Correo";
        private const string ParamFech = "FechaVenta";
        private const string ParamNomProd = "NombreProducto";
        private const string ParamNom = "Nombre";
        private const string ParamPreUni = "PrecioUnitario";
        private const string ParamCat = "Categoria";
        private const string ParamTot = "Total";
        private const string ParamPre = "Precio";
        private const string ParamCant = "CantVendidaUltimoMes";
        public string getInformeVentas() { return informeVentas; }
        public string getInformeVentasProd() {  return informeVentasProd; }
        //PARÁMETROS
        public string getParamID() { return ParamID; }
        public string getParamCli() {  return ParamCli; }
        public string getParamTel() {  return ParamTel; }
        public string getParamCorr() {  return ParamCorr; }
        public string getParamFech() {  return ParamFech; }
        public string getParamNomProd() {  return ParamNomProd; }
        public string getParamNom() {  return ParamNom; }
        public string getParamPreUni() {  return ParamPreUni; }
        public string getParamCat() {  return ParamCat; }
        public string getParamTot() {  return ParamTot; }
        public string getParamPre() {  return ParamPre; }
        public string getParamCant() {  return ParamCant; }
    }
}
