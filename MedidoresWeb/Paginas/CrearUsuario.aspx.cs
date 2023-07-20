using MedidoresDB;
using MedidoresDB.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
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
                if(ValidaRut(rut))
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

        public static bool ValidaRut(string rut)
        {
            rut = rut.Replace(".", "").ToUpper();
            Regex expresion = new Regex("^([0-9]+-[0-9K])$");
            string dv = rut.Substring(rut.Length - 1, 1);
            if (!expresion.IsMatch(rut))
            {
                return false;
            }
            char[] charCorte = { '-' };
            string[] rutTemp = rut.Split(charCorte);
            if (dv != Digito(int.Parse(rutTemp[0])))
            {
                return false;
            }
            return true;
        }

        public static string Digito(int rut)
        {
            int suma = 0;
            int multiplicador = 1;
            while (rut != 0)
            {
                multiplicador++;
                if (multiplicador == 8)
                    multiplicador = 2;
                suma += (rut % 10) * multiplicador;
                rut = rut / 10;
            }
            suma = 11 - (suma % 11);
            if (suma == 11)
            {
                return "0";
            }
            else if (suma == 10)
            {
                return "K";
            }
            else
            {
                return suma.ToString();
            }
        }
    }
}