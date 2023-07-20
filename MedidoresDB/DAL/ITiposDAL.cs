using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresDB.DAL
{
    public interface ITiposDAL
    {
        List<TipoMedidor> ObtenerTipos();
    }
}
