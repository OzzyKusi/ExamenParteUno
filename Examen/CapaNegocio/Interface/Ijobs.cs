using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaDato;


namespace CapaNegocio.Interface
{
    interface Ijobs
    {
        DataSet Listar();
        bool Agregar(Jobs jobs);
        bool Eliminar(int job_id);
        bool Actualizar(Jobs jobs);
        DataSet Buscar(int job_id);
    }
}
