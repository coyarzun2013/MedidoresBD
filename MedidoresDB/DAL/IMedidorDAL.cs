using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresDB.DAL
{
    public interface IMedidorDAL
    {
        List<Medidor> ObtenerMedidores();
        List<Medidor> ObtenerMedidores(int Idusuario);
        Medidor Obtener(int id);
        void AgregarMedidor(Medidor medidor);
        void EliminarMedidor(int id);
    }
}
