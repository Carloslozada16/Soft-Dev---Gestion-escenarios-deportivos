using System.Collections.Generic;
using Dominio;
using System.Linq;

namespace Persistencia 
{
   public interface IRepositorioTorneo
   {
       IEnumerable<Torneo> GetAllTorneo();
       Torneo AddTorneo(Torneo torneo);
       bool UpdateTorneo(Torneo torneo);
       bool DeleteTorneo(int IdTorneo);
       Torneo GetTorneo(int IdTorneo);

   }
}