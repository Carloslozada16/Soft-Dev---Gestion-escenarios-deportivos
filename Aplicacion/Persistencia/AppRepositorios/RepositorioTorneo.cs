using System.Collections.Generic;
using Dominio;
using System.Linq;

namespace Persistencia
{
    public class RepositorioTorneo : IRepositorioTorneo
    {
        private readonly AppContext _appContext;
        public RepositorioTorneo(AppContext appContext)
        {
            _appContext = appContext;
        }
        Torneo IRepositorioTorneo.AddTorneo(Torneo torneo)
        {
            var TorneoAdicionado=_appContext.Add(torneo);
            _appContext.SaveChanges();
            return TorneoAdicionado.Entity;
        }

        bool IRepositorioTorneo.DeleteTorneo(int IdTorneo)
        {
            bool eliminado=false;
            var departamento=_appContext.Torneos.Find(IdTorneo);
            if(departamento!=null)
            {
                try
                {
                    _appContext.Torneos.Remove(departamento);
                    _appContext.SaveChanges();
                    eliminado=true;
                }
                catch (System.Exception)
                {
                    return eliminado;
                }
               
            }
            return eliminado;
        }
    
        IEnumerable<Torneo> IRepositorioTorneo.GetAllTorneo()
        {
            return _appContext.Torneos;
        }

        Torneo IRepositorioTorneo.GetTorneo(int IdTorneo)
        {
            return _appContext.Torneos.FirstOrDefault(p => p.Id==IdTorneo);
        }

        bool IRepositorioTorneo.UpdateTorneo(Torneo torneo)
        {
            bool actualizado=false;
            var mun=_appContext.Torneos.Find(torneo.Id);
            if(mun!=null)
            {
                try
                {
                    mun.Nombre=torneo.Nombre;
                    _appContext.SaveChanges();
                    actualizado=true;
                }
                catch(System.Exception)
                {
                    return actualizado;
                }
            }
            return actualizado;
        }

    }
}