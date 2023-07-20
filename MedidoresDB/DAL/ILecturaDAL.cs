using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresDB.DAL
{
    public interface ILecturaDAL
    {
        List<Lectura> ObtenerLecturasMedidor(int IdMedidor);
        List<Lectura> ObtenerLecturas();
        void AgregarLectura(Lectura lectura);
        void Eliminar(int id);
    }
}
