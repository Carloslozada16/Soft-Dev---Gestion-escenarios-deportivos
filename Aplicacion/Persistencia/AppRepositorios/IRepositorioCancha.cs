using System.Collections.Generic;
using Dominio;

namespace Persistencia
{
    public interface IRepositorioCancha
    {
        IEnumerable<Cancha> ListarCanchas();
        bool CrearCancha(Cancha cancha);
        bool ActualizarCancha (Cancha cancha);
        bool EliminarCancha(int idCancha);
        Cancha BuscarCancha(int idCancha);
    }
}