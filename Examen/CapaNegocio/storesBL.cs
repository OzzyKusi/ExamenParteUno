using CapaDato;
using CapaEntidad;
using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class StoresBL : Interface.Istores
    {
        private string mensaje;
        public string Mensaje
        {
            get { return mensaje; }
        }
        Datos datos = new DatosSQL();
        public bool Actualizar(Stores stores)
        {
            DataRow fila = datos.TraerDataRow("spActualizarStores ", stores.Stor_id, stores.Stor_name);
            mensaje = fila["Mensaje"].ToString();
            byte codError = Convert.ToByte(fila["CodError"]);
            if (codError == 0) return false;
            else return true;
        }

        public bool Agregar(Stores stores)
        {
            DataRow fila = datos.TraerDataRow("spAgregarStores", stores.Stor_id, stores.Stor_name, stores.Stor_address, stores.City,stores.State,stores.Zip);
            mensaje = fila["Mensaje"].ToString();
            byte codError = Convert.ToByte(fila["CodError"]);
            if (codError == 0) return false;
            else return true;
        }

        public DataSet Buscar(int stores_id)
        {
            return datos.TraerDataSet("spBuscarStores", stores_id);
        }

        public bool Eliminar(int stores_id)
        {
            DataRow fila = datos.TraerDataRow("spEliminarStores", stores_id);
            mensaje = fila["Mensaje"].ToString();
            byte codError = Convert.ToByte(fila["CodError"]);
            if (codError == 0) return false;
            else return true;
        }

        public DataSet Listar()
        {
            return datos.TraerDataSet("spListarStores");
        }
    }
}

