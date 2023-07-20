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
    public partial class CrearLectura : System.Web.UI.Page
    {
        ILecturaDAL lecturaDAL = new LecturaDalBD();
        IMedidorDAL medidorDAL = new MedidorDalBD();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<Medidor> medidores = medidorDAL.ObtenerMedidores();
                this.medidoresDbl.DataSource = medidores;
                this.medidoresDbl.DataTextField = "Numero";
                this.medidoresDbl.DataValueField = "IdMedidor";
                this.medidoresDbl.DataBind();
            }
        }
        protected void agregarBtn_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                int consumo = Convert.ToInt32(this.consumotxt.Text);
                int hora = Convert.ToInt32(this.horatxt.Text);
                int minuto = Convert.ToInt32(this.minutostxt.Text);
                string fecha = this.fechatxt.SelectedDate.ToString();
                string[] partesFecha = fecha.Split(' ');
                fecha = partesFecha[0];
                int medidor = Convert.ToInt32(this.medidoresDbl.SelectedValue);
                String horaString = hora.ToString() + ":" + minuto.ToString();
                Lectura lectura = new Lectura()
                {
                    Consumo = consumo,
                    Fecha = fecha,
                    Hora = horaString,
                    IdMedidor = medidor
                };
                lecturaDAL.AgregarLectura(lectura);

                this.mensajesLbl.Text = "Lectura agregada correctamente" + fecha;
                Response.Redirect("VerLecturas.aspx");
            }
        }
    }
}