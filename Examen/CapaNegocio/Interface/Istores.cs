using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using System.Data;
using CapaDato;


namespace CapaNegocio.Interface
{
    interface Istores
    {
        DataSet Listar();
        bool Agregar(Stores stores);
        bool Eliminar(int stores_id);
        bool Actualizar(Stores stores);
        DataSet Buscar(int stores_id);

    }
}
