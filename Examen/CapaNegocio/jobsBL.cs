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
        public class jobsBL : Interface.Ijobs
        {
            private string mensaje;
            public string Mensaje
            {
                get { return mensaje; }
            }
            Datos datos = new DatosSQL();
            public bool Actualizar(Jobs jobs)
            {
                DataRow fila = datos.TraerDataRow("spActualizarJobs ", jobs.Job_id, jobs.Job_decs);
                mensaje = fila["Mensaje"].ToString();
                byte codError = Convert.ToByte(fila["CodError"]);
                if (codError == 0) return false;
                else return true;
            }

            public bool Agregar(Jobs jobs)
            {
                DataRow fila = datos.TraerDataRow("spAgregarJobs",jobs.Job_id, jobs.Job_decs, jobs.Min_lvl, jobs.Max_lvl);
                mensaje = fila["Mensaje"].ToString();
                byte codError = Convert.ToByte(fila["CodError"]);
                if (codError == 0) return false;
                else return true;
            }

            public DataSet Buscar(int Job_id)
            {
                return datos.TraerDataSet("spBuscarJobs", Job_id);
            }

            public bool Eliminar(int job_id)
            {
                DataRow fila = datos.TraerDataRow("spEliminarJobs", job_id);
                mensaje = fila["Mensaje"].ToString();
                byte codError = Convert.ToByte(fila["CodError"]);
                if (codError == 0) return false;
                else return true;
            }

            public DataSet Listar()
            {
                return datos.TraerDataSet("spListarJobs");
            }
        }

    
}
