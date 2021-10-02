using System.Collections.Generic;
using Dominio;
using System.Linq;

namespace Persistencia 
{
   public interface IRepositorioPatrocinador
   {
       IEnumerable<Patrocinador> GetAllPatrocinador();
       Patrocinador AddPatrocinador(Patrocinador patrocinador);
       bool UpdatePatrocinador(Patrocinador patrocinador);
       bool DeletePatrocinador(int IdPatrocinador);
       Patrocinador GetPatrocinador(int IdPatrocinador);

   }
}