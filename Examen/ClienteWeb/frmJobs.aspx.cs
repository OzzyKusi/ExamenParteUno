using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClienteWeb
{
    public partial class frmJobs : System.Web.UI.Page
    {

        srjobs.wsjobsSoapClient servicio = new srjobs.wsjobsSoapClient();
        private void Listar()
        {
            jbJobs.DataSource = servicio.Listar().Tables[0];
            jbJobs.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
                Listar();
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            string[] msj = servicio.Agregar(int.Parse(txtId.Text), txtName.Text, int.Parse(txtmin.Text), int.Parse(txtmax.Text));
            Response.Write("<script>alert('" + msj[0] + " : " + msj[1] + "'); </script>");
            Listar();
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            string[] msj = servicio.Actualizar(int.Parse(txtId.Text), txtName.Text, int.Parse(txtmin.Text), int.Parse(txtmax.Text));
            Response.Write("<script>alert('" + msj[0] + " : " + msj[1] + "'); </script>");
            Listar();
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            jbJobs.DataSource = servicio.Buscar(int.Parse(txtId.Text)).Tables[0];
            jbJobs.DataBind();
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            string[] msj = servicio.Eliminar(int.Parse(txtId.Text));
            Response.Write("<script>alert('" + msj[0] + " : " + msj[1] + "'); </script>");
            Listar();
        }
    }
}