using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresDB.DAL
{
    public class LecturaDalBD : ILecturaDAL
    {
        MedidorDBEntities medidorDB = new MedidorDBEntities();

        public void AgregarLectura(Lectura lectura)
        {
            this.medidorDB.Lecturas.Add(lectura);
            this.medidorDB.SaveChanges();
        }

        public void Eliminar(int id)
        {
            Lectura lectura = this.medidorDB.Lecturas.Find(id);
            this.medidorDB.Lecturas.Remove(lectura);
            this.medidorDB.SaveChanges();
        }

        public List<Lectura> ObtenerLecturas()
        {
            return this.medidorDB.Lecturas.ToList();
        }

        public List<Lectura> ObtenerLecturasMedidor(int IdMedidor)
        {
            var query = from a in this.medidorDB.Lecturas
                        where a.IdMedidor == IdMedidor
                        select a;
            return query.ToList();
        }
    }
}
