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
    /// Descripción breve de wsjobs
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class wsjobs : System.Web.Services.WebService
    {
        [WebMethod(Description = "Listar jobs")]
        public DataSet Listar()
        {
            jobsBL jobs = new jobsBL();
            return jobs.Listar();
        }

        [WebMethod(Description = "Agregar jobs")]
        public string[] Agregar(int Job_Id, string Job_decs, int Min_lvl, int Max_lvl)
        {
            jobsBL jobs = new jobsBL();
            Jobs jobs1 = new Jobs();
            jobs1.Job_id = Job_Id;
            jobs1.Job_decs = Job_decs;
            jobs1.Min_lvl = Min_lvl;
            jobs1.Max_lvl = Max_lvl;

            string[] valores = new string[2];
            valores[0] = jobs.Agregar(jobs1).ToString();
            valores[1] = jobs.Mensaje;

            return valores;
        }

        [WebMethod(Description = "Actualizar Publishers")]
        public string[] Actualizar(int Job_Id, string Job_decs, int Min_lvl, int Max_lvl)
        {
            jobsBL jobs = new jobsBL();
            Jobs jobs1 = new Jobs();
            jobs1.Job_id = Job_Id;
            jobs1.Job_decs = Job_decs;
            jobs1.Min_lvl = Min_lvl;
            jobs1.Max_lvl = Max_lvl;

            string[] valores = new string[2];
            valores[0] = jobs.Actualizar(jobs1).ToString();
            valores[0] = jobs.Mensaje;

            return valores;

        }

        [WebMethod(Description = "Eliminar Publishers")]
        public string[] Eliminar(int Job_Id)
        {
            jobsBL jobs = new jobsBL();
            Jobs jobs1 = new Jobs();
            jobs1.Job_id = Job_Id;
            string[] valores = new string[2];
            valores[0] = jobs.Eliminar(Job_Id).ToString();
            valores[1] = jobs.Mensaje;

            return valores;
        }

        [WebMethod(Description = "Buscar Publishers")]
        public DataSet Buscar(int Job_Id)
        {
            jobsBL jobs = new jobsBL();
            return jobs.Buscar(Job_Id);
        }

    }
}
