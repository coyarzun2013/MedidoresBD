using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresDB.DAL
{
    public class ITipoDalBD : ITiposDAL
    {
        private MedidorDBEntities medidorDB = new MedidorDBEntities();

        public List<TipoMedidor> ObtenerTipos()
        {
            return this.medidorDB.TipoMedidors.ToList();
        }
    }
}
