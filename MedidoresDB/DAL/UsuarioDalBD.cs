using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresDB.DAL
{
    public class UsuarioDalBD : IUsuarioDAL
    {
        private MedidorDBEntities medidorDB = new MedidorDBEntities();
        public void AgregarUsuario(Usuario usuario)
        {
            this.medidorDB.Usuarios.Add(usuario);
            this.medidorDB.SaveChanges();
        }

        public void EliminarUsuario(int id)
        {
            Usuario usuario = this.medidorDB.Usuarios.Find(id);
            this.medidorDB.Usuarios.Remove(usuario);
            this.medidorDB.SaveChanges();
        }

        public Usuario ObtenerUsuario(int id)
        {
            return this.medidorDB.Usuarios.Find(id);
        }

        public List<Usuario> ObtenerUsuarios()
        {
            return this.medidorDB.Usuarios.ToList();
        }
    }
}
