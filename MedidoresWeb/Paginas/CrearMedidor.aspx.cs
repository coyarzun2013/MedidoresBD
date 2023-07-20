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
    public partial class CrearMedidor : System.Web.UI.Page
    {
        private ITiposDAL itiposDAL = new ITipoDalBD();
        private IUsuarioDAL usuarioDAL = new UsuarioDalBD();
        private IMedidorDAL medidorDAL = new MedidorDalBD();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                List<TipoMedidor> tipos = itiposDAL.ObtenerTipos();
                this.tiposDbl.DataSource = tipos;
                this.tiposDbl.DataTextField = "Descripcion";
                this.tiposDbl.DataValueField = "IdTipo";
                this.tiposDbl.DataBind();

                List<Usuario> usuarios = usuarioDAL.ObtenerUsuarios();
                this.usuariosDbl.DataSource = usuarios;
                this.usuariosDbl.DataTextField = "Nombre";
                this.usuariosDbl.DataValueField = "Id";
                this.usuariosDbl.DataBind();
            }
        }

        protected void agregarBtn_Click(object sender, EventArgs e)
        { 
            Medidor medidor = new Medidor();
            medidor.Numero = Convert.ToInt32(this.numerotxt.Text);
            medidor.IdTipo = Convert.ToInt32(this.tiposDbl.SelectedValue);
            int idUser = Convert.ToInt32(this.usuariosDbl.SelectedValue);
            medidor.IdUsuario = idUser;
            this.medidorDAL.AgregarMedidor(medidor);
            this.mensajesLbl.Text = "Medidor creado correctamente.";
            Response.Redirect("VerUsuario.aspx?id="+idUser);

        }
    }
}