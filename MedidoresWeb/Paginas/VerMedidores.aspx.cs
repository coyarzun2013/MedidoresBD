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
    public partial class VerMedidores : System.Web.UI.Page
    {
        IMedidorDAL medidorDAL = new MedidorDalBD();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                List<Medidor> medidores = medidorDAL.ObtenerMedidores();
                this.grillaMedidores.DataSource = medidores;
                this.grillaMedidores.DataBind();
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

    }
}