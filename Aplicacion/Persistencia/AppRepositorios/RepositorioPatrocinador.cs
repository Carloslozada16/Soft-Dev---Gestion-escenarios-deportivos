using System.Collections.Generic;
using Dominio;
using System.Linq;

namespace Persistencia
{
    public class RepositorioPatrocinador : IRepositorioPatrocinador
    {
        private readonly AppContext _appContext;
        public RepositorioPatrocinador(AppContext appContext)
        {
            _appContext = appContext;
        }
        Patrocinador IRepositorioPatrocinador.AddPatrocinador(Patrocinador patrocinador)
        {
            var PatrocinadorAdicionado=_appContext.Add(patrocinador);
            _appContext.SaveChanges();
            return PatrocinadorAdicionado.Entity;
        }

        bool IRepositorioPatrocinador.DeletePatrocinador(int IdPatrocinador)
        {
            bool eliminado =false;
            var patrocinador=_appContext.Patrocinadores.Find(IdPatrocinador);
            if(patrocinador!=null)
            {
                try
                {
                    _appContext.Patrocinadores.Remove(patrocinador);
                    _appContext.SaveChanges();
                    eliminado = true;
                    
                }
                catch (System.Exception)
                {
                    return eliminado;
                }
            }
            return eliminado;
        }

        IEnumerable<Patrocinador> IRepositorioPatrocinador.GetAllPatrocinador()
        {
            return _appContext.Patrocinadores;

        }

        Patrocinador IRepositorioPatrocinador.GetPatrocinador(int IdPatrocinador)
        {
            return _appContext.Patrocinadores.FirstOrDefault(p => p.Id==IdPatrocinador);
        }

        bool IRepositorioPatrocinador.UpdatePatrocinador(Patrocinador patrocinador)
        {
            bool actualizado= false;
            var mun=_appContext.Patrocinadores.Find(patrocinador.Id);
            if(mun!=null)
            {
                try
                {
                    mun.Nombre=patrocinador.Nombre;
                    _appContext.SaveChanges();
                    actualizado=true;

                }
                catch (System.Exception)
                {
                    return actualizado;
                }
            }
             return actualizado;
        }
        
    }
}
