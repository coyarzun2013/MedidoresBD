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
    public partial class CrearUsuario : System.Web.UI.Page
    {
        private IUsuarioDAL usuarioDAL = new UsuarioDalBD();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void agregarBtn_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.Rut = this.ruttxt.Text.Trim();
            usuario.Nombre = this.nombretxt.Text.Trim();
            usuario.Correo = this.emailtxt.Text.Trim();
            usuario.Contrasena = this.passtxt.Text.Trim();
            this.usuarioDAL.AgregarUsuario(usuario);
            this.mensajesLbl.Text = "Usuario creado correctamente.";
            Response.Redirect("VerUsuarios.aspx");
        }
    }
}