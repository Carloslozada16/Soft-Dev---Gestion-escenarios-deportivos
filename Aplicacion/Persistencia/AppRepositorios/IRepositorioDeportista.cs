// IREPOSITORIO DEPORTISTA*********PERSISTENCIA\IREPOSITORIODEPORTISTA******

using System.Collections.Generic;
using Dominio;
using System.Linq;

namespace Persistencia
{
    public interface IRepositorioDeportista
    {
        IEnumerable<Deportista> GetAllDeportista();
        Deportista AddDeportista(Deportista deportista);
        bool UpdateDeportista(Deportista deportista);
        bool DeleteDeportista (int IdDeportista);
        Deportista GetDeportista (int IdDeportista);
    }
}