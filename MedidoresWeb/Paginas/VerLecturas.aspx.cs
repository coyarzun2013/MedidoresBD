using MedidoresDB;
using MedidoresDB.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MedidoresWeb.Paginas
{
    public partial class VerLecturas : System.Web.UI.Page
    {
        private static int sid = 0;
        ILecturaDAL lecturaDAL = new LecturaDalBD();
        IMedidorDAL medidorDAL = new MedidorDalBD();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["id"] != null)
            {
                sid = Convert.ToInt32(Request.QueryString["id"]);
                VerLecturasMedidor(sid);
            } else
            {
                VerLecturasBD();
            }
            
        }
        protected void VerLecturasBD()
        {
            List<Lectura> lecturas = lecturaDAL.ObtenerLecturas();
            string label = "Ver Lecturas de Medidor ";
            this.mensajesLbl.Text = label;
            this.grillaLecturas.DataSource = lecturas;
            this.grillaLecturas.DataBind();
        }

        protected void VerLecturasMedidor(int sid)
        {
            List<Lectura> lecturas = lecturaDAL.ObtenerLecturasMedidor(sid);
            Medidor medidor = medidorDAL.Obtener(sid);
            string label = "Ver Lecturas de Medidor ";
            if (medidor != null)
            {
                label = label + medidor.Numero.ToString();
            }
            this.mensajesLbl.Text = label;
            this.grillaLecturas.DataSource = lecturas;
            this.grillaLecturas.DataBind();
        }
    }
}