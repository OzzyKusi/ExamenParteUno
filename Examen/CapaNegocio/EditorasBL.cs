using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDato;


namespace CapaNegocio
{
    public class EditorasBL : Interface.IEditoras
    {

        //Utilizar los archivos cs de la capa de datos
        Datos datos = new DatosSQL();

        public bool Actualizar(Editoras editoras)
        {
            throw new NotImplementedException();
        }

        public bool Agregar(Editoras editoras)
        {
            throw new NotImplementedException();
        }

        public DataSet Buscar(string texto, string criterio)
        {
            return datos.TraerDataSet("spBuscarEditoras",texto,criterio);
        }

        public bool Eliminar(string codigo)
        {
            throw new NotImplementedException();
        }

        public DataSet Listar()
        {
            return datos.TraerDataSet("spListarEditoras");
        }
    }
}
