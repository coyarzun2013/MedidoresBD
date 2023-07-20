using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresDB.DAL
{
    public class MedidorDalBD : IMedidorDAL
    {
        private MedidorDBEntities medidorDB = new MedidorDBEntities();
        public void AgregarMedidor(Medidor medidor)
        {
            this.medidorDB.Medidors.Add(medidor);
            this.medidorDB.SaveChanges();
        }

        public void EliminarMedidor(int id)
        {
            Medidor medidor = this.medidorDB.Medidors.Find(id);
            this.medidorDB.Medidors.Remove(medidor);
            this.medidorDB.SaveChanges();
        }

        public Medidor Obtener(int id)
        {
            return this.medidorDB.Medidors.Find(id);
        }

        public List<Medidor> ObtenerMedidores()
        {
            return this.medidorDB.Medidors.ToList();
        }

        public List<Medidor> ObtenerMedidores(int Idusuario)
        {
            var query = from a in this.medidorDB.Medidors
                        where a.IdUsuario == Idusuario
                        select a;
            return query.ToList();
        }
    }
}
