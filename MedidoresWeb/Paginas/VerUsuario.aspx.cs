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
    public partial class VerUsuario : System.Web.UI.Page
    {
        private static int sid = 0;
        private IUsuarioDAL usuarioDAL = new UsuarioDalBD();
        private IMedidorDAL medidorDAL = new MedidorDalBD();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["id"] != null)
                {
                    sid = Convert.ToInt32(Request.QueryString["id"]);
                    VerDetalleUsuario(sid);
                } else
                    Response.Redirect("VerUsuarios.aspx");
                {

                }
            }
        }

        protected void btnVer_click(object sender, EventArgs e)
        {
            int id;
            Button btnVerLecturas = (Button)sender;
            GridViewRow selectedRow = (GridViewRow)btnVerLecturas.NamingContainer;
            id = Convert.ToInt32(selectedRow.Cells[0].Text);
            Response.Redirect("VerLecturas.aspx?id=" + id);
        }

        protected void VerDetalleUsuario(int sid)
        {
            Usuario usuario = this.usuarioDAL.ObtenerUsuario(sid);
            if (usuario == null)
            {
                Response.Redirect("VerUsuarios.aspx");
            } else
            {
                this.ruttxt.Text = usuario.Rut.ToString();
                this.nombretxt.Text = usuario.Nombre.ToString();
                this.emailtxt.Text = usuario.Correo.ToString();
                this.passtxt.Text = usuario.Contrasena.ToString();

                List<Medidor> medidores = medidorDAL.ObtenerMedidores(sid);

                this.grillaMedidores.DataSource = medidores;
                this.grillaMedidores.DataBind();
            }
            
        
        }
    }
}