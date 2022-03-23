using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using System.Data;

namespace CapaNegocio.Interface
{
    interface IEditoras
    {
        //Declarar metodos comunes
        DataSet Listar();
        bool Agregar(Editoras editoras);
        bool Eliminar(string codigo);
        bool Actualizar(Editoras editoras);
        DataSet Buscar
            (string texto, string criterio);

    }
}
