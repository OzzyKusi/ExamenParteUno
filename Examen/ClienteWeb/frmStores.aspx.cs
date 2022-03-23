using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClienteWeb
{
    public partial class frmStores : System.Web.UI.Page
    {
           srstores.wsstoresSoapClient servicio = new srstores.wsstoresSoapClient();
            private void Listar()
            {
                jbStores.DataSource = servicio.Listar().Tables[0];
                jbStores.DataBind();
            }
            protected void Page_Load(object sender, EventArgs e)
            {
                if (!Page.IsPostBack)
                    Listar();
            }

            protected void btnAgregar_Click(object sender, EventArgs e)
            {
            string[] msj = servicio.Agregar(int.Parse(txtId.Text), txtName.Text, txtAdrress.Text, txtCity.Text, txtState.Text, txtZip.Text);
                Response.Write("<script>alert('" + msj[0] + " : " + msj[1] + "'); </script>");
                Listar();
            }

            protected void btnActualizar_Click(object sender, EventArgs e)
            {
                string[] msj = servicio.Actualizar(int.Parse(txtId.Text), txtName.Text, txtAdrress.Text, txtCity.Text, txtState.Text, txtZip.Text);
                Response.Write("<script>alert('" + msj[0] + " : " + msj[1] + "'); </script>");
                Listar();
            }

            protected void btnBuscar_Click(object sender, EventArgs e)
            {
                jbStores.DataSource = servicio.Buscar(int.Parse(txtId.Text)).Tables[0];
                jbStores.DataBind();
            }

            protected void btnEliminar_Click(object sender, EventArgs e)
            {
                string[] msj = servicio.Eliminar(int.Parse(txtId.Text));
                Response.Write("<script>alert('" + msj[0] + " : " + msj[1] + "'); </script>");
                Listar();
            }
        }
    }