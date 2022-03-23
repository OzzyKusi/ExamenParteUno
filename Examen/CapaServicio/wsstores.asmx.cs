using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

using CapaNegocio;
using CapaEntidad;
using System.Data;

namespace CapaServicio
{
    /// <summary>
    /// Descripción breve de wsstores
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class wsstores : System.Web.Services.WebService
    {
        [WebMethod(Description = "Listar Stores")]
        public DataSet Listar()
        {
            StoresBL stores = new StoresBL();
            return stores.Listar();
        }

        [WebMethod(Description = "Agregar Stores")]
        public string[] Agregar(int stor_id,string stor_name,string stor_address,string city,string state,string zip)
        {
            StoresBL store = new StoresBL();
            Stores store1 = new Stores();
            store1.Stor_id = stor_id;
            store1.Stor_name = stor_name;
            store1.Stor_address = stor_address;
            store1.City = city;
            store1.State = state;
            store1.Zip = zip;


            string[] valores = new string[2];
            valores[0] = store.Agregar(store1).ToString();
            valores[1] = store.Mensaje;

            return valores;
        }

        [WebMethod(Description = "Actualizar Stores")]
        public string[] Actualizar(int stor_id, string stor_name, string stor_address, string city, string state, string zip)
        {
            StoresBL store = new StoresBL();
            Stores store1 = new Stores();
            store1.Stor_id = stor_id;
            store1.Stor_name = stor_name;
            store1.Stor_address = stor_address;
            store1.City = city;
            store1.State = state;
            store1.Zip = zip;

            string[] valores = new string[2];
            valores[0] = store.Actualizar(store1).ToString();
            valores[0] = store.Mensaje;

            return valores;

        }

        [WebMethod(Description = "Eliminar Stores")]
        public string[] Eliminar(int stor_id)
        {
            StoresBL store = new StoresBL();
            Stores store1 = new Stores();
            store1.Stor_id = stor_id;
            string[] valores = new string[2];
            valores[0] = store.Eliminar(stor_id).ToString();
            valores[1] = store.Mensaje;

            return valores;
        }

        [WebMethod(Description = "Buscar Stores")]
        public DataSet Buscar(int stor_id)
        {
            StoresBL jobs = new StoresBL();
            return jobs.Buscar(stor_id);
        }

    }
}

