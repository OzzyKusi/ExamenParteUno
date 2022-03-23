using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

//Declarar los namespace
using System.Data; // con bases de datos
using System.Data.SqlClient; // sql server
using System.Configuration; // web config

namespace ServiciosNorthwind
{
    /// <summary>
    /// Descripción breve de wsRegion
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class wsRegion : System.Web.Services.WebService
    {
        // Traer la cadena de conexion desde el archivo seguro desde web.config
        private static string cadena = ConfigurationManager.ConnectionStrings["Cadena"].ConnectionString;
        private static SqlConnection conexion = new SqlConnection(cadena);

        [WebMethod(Description = "Listar los datos de la tabla Region")]
        public DataSet Listar()
        {
            string consulta = "select * from Region";
            SqlCommand comando = new SqlCommand(consulta, conexion);
            SqlDataAdapter adapter = new SqlDataAdapter(comando);
            DataSet data = new DataSet();
            adapter.Fill(data);
            return data;
        }

        [WebMethod(Description = "Agregar un registro")]
        public bool Agregar(int id, string description)
        {
            try
            {
                string consulta = "insert into Region values('" + id + "','" + description + "')";
                SqlCommand comando = new SqlCommand(consulta, conexion);
                conexion.Open();
                // Ejecutar la consulta
                int i = comando.ExecuteNonQuery();
                conexion.Close();
                if (i == 1) return true;
                else return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        [WebMethod(Description = "Eliminar un registro")]
        public bool Eliminar(int Id)
        {
            try
            {
                string consulta = "Delete from Region where RegionID = '" + Id + "'";
                SqlCommand comando = new SqlCommand(consulta, conexion);
                conexion.Open();
                int i = comando.ExecuteNonQuery();
                conexion.Close();
                if (i == 1) return true;
                else return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        [WebMethod(Description = "Actualizar un registro")]
        public bool Actualizar(int Id, string Description )
        {
            try
            {
                string consulta = " UPDATE Region SET RegionDescription = '" + Description + "' Where RegionID = '" + Id + "'";
                SqlCommand comando = new SqlCommand(consulta, conexion);
                conexion.Open();
                int i = comando.ExecuteNonQuery();
                conexion.Close();
                if (i == 1) return true;
                else return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        [WebMethod(Description = "Buscar en la tabla Region")]
        public DataSet Buscar(string texto, string criterio)
        {
            string consulta = String.Empty;
            if (criterio == "id")
                consulta = "select * from Region where RegionId = '" + int.Parse(texto) + "'";
            else if (criterio == "description")
                consulta = "select * from Region where RegionDescription = '" + texto + "'";
            SqlCommand command = new SqlCommand(consulta, conexion);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataSet data = new DataSet();
            adapter.Fill(data);
            return data;
        }
    }
}
