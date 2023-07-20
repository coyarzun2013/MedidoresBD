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
            string rut = this.ruttxt.Text.Trim();
            if(rut.Contains("-"))
            {
                if(validarRut(rut))
                {
                    usuario.Rut = this.ruttxt.Text.Trim();
                    usuario.Nombre = this.nombretxt.Text.Trim();
                    usuario.Correo = this.emailtxt.Text.Trim();
                    usuario.Contrasena = this.passtxt.Text.Trim();
                    this.usuarioDAL.AgregarUsuario(usuario);
                    this.mensajesLbl.Text = "Usuario creado correctamente.";
                    Response.Redirect("VerUsuarios.aspx");
                } 
                else
                {
                    this.mensajesLbl.Text = "Rut incorrecto, ingreselo nuevamente.";
                }
                
            } 
            else
            {
                this.mensajesLbl.Text = "El campo rut debe contener guión.";
            }
            
        }

        public bool validarRut(string rut)
        {
            bool validar = false;
            try
            {
                rut = rut.Trim();
                rut = rut.ToUpper();
                rut = rut.Replace(".", "");
                rut = rut.Replace(",", "");
                rut = rut.Replace("-", "");
                int rutAux = int.Parse(rut.Substring(0,rut.Length - 1));
                char dv = char.Parse(rut.Substring(rut.Length - 1,1));

                int m = 0, s = 1;
                for(;rutAux != 0; rutAux /= 10)
                {
                    s = (s + rutAux % 10 * (9 - m++ % 6)) % 11;
                }
                if(dv == (char)(s != 0 ? s + 47 : 75))
                {
                    validar = true;
                }
            }
            catch (Exception)
            {

            }
            return validar;
        }
    }
}