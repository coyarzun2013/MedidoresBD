using MedidoresDB;
using MedidoresDB.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MedidoresWeb.Paginas
{
    public partial class VerUsuarios : System.Web.UI.Page
    {
        private IUsuarioDAL usuarioDAL = new UsuarioDalBD();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.cargarGrilla(this.usuarioDAL.ObtenerUsuarios());
            }
        }

        private void cargarGrilla(List<Usuario> usuarios)
        {
            this.grillaUsuarios.DataSource = usuarios;
            this.grillaUsuarios.DataBind();
        }

        protected void btnEliminar_click(object sender, EventArgs e)
        {
            int id;
            Button btnEliminar = (Button)sender;
            GridViewRow selectedRow = (GridViewRow)btnEliminar.NamingContainer;
            id = Convert.ToInt32(selectedRow.Cells[0].Text);
            this.usuarioDAL.EliminarUsuario(id);
            this.mensajesLbl.Text = "Usuario eliminado correctamente.";
            this.cargarGrilla(this.usuarioDAL.ObtenerUsuarios());
        }

        protected void btnEditar_click(object sender, EventArgs e)
        {
            int id;
            Button btnEditar = (Button)sender;
            GridViewRow selectedRow = (GridViewRow)btnEditar.NamingContainer;
            id = Convert.ToInt32(selectedRow.Cells[0].Text);
            Response.Redirect("VerUsuario.aspx?id="+id);
        }
    }
}