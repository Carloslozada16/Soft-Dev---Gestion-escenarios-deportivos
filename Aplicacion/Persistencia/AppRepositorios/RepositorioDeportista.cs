// ARCHIVO REPOSITORIO DEPORTISTA**************PERSISTENCIA\REPOSITORIODEPORTISTA*******

using System.Collections.Generic;
using Dominio;
using System.Linq; 

namespace Persistencia
{
    public class RepositorioDeportista : IRepositorioDeportista
    {
        private readonly AppContext _appContext;
        public RepositorioDeportista(AppContext appContext)
        {
            _appContext = appContext;
        }
        Deportista IRepositorioDeportista.AddDeportista(Deportista deportista)
        {
            var DeportistaAdicionado=_appContext.Add(deportista);
            _appContext.SaveChanges();
            return DeportistaAdicionado.Entity;
        }

        bool IRepositorioDeportista.DeleteDeportista(int IdDeportista)
        {
            bool eliminado= false;
            var deportista=_appContext.Deportistas.Find(IdDeportista);
            if(deportista!=null)
            {
                try
                {
                     _appContext.Deportistas.Remove(deportista);
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
        /*
        bool IRepositorioDeportista.DeleteDeportista(int IdDeportista)
        {
            var DeportistaEncontrado=_appContext.Deportista.FirstOrDefault(p => p.Id==IdDeportista);
            if(DeportistaEncontrado==null)
            return;
            _appContext.Deportistas.Remove(DeportistaEncontrado);
            _appContext.SaveChanges();
        }
        */
        IEnumerable<Deportista> IRepositorioDeportista.GetAllDeportista()
        {
            return _appContext.Deportistas;
        }
        
        Deportista IRepositorioDeportista.GetDeportista(int IdDeportista)
        {
            return _appContext.Deportistas.FirstOrDefault(p => p.Id==IdDeportista);
        }

        bool IRepositorioDeportista.UpdateDeportista(Deportista deportista)
        {
           bool actualizado= false;
           var mun=_appContext.Deportistas.Find(deportista.Id);
           if(mun!=null)
           {
               try
               {
                    mun.Nombres=deportista.Nombres;
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
        /*
        bool IRepositorioDeportista.UpdateDeportista(Deportista deportista)
        {
            var DeportistaEncontrado=_appContext.Deportistas.FirstOrDefault(p => p.Id==deportista.Id);
            if (DeportistaEncontrado.Nombre!=null)
            {
                DeportistaEncontrado.Nombre=deportista.Nombre;
                _appContext.SaveChanges();
            }
            return DeportistaEncontrado;

        }*/
        
    }    


}
