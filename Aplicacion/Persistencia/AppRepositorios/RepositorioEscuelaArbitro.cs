using System.Collections.Generic;
using Dominio;
using System.Linq;

namespace Persistencia
{
    public class RepositorioEscuelaArbitro: IRepositorioEscuelaArbitro
    {
        private readonly AppContext _appContext;
        public RepositorioEscuelaArbitro(AppContext appContext)
        {
            _appContext=appContext;
        }
        bool IRepositorioEscuelaArbitro.CrearEscuelaArbitro(EscuelaArbitro escuelaArbitro)
        {
            bool creado=false;
            bool ex=Existe(escuelaArbitro);
            if (!ex)
            {
               try{
                _appContext.EscuelasArbitros.Add(escuelaArbitro);
                _appContext.SaveChanges();
                creado=true;
                }
                catch(System.Exception)
                {
                    return creado; 
                }
            }    
            try{
                _appContext.EscuelasArbitros.Add(escuelaArbitro);
                _appContext.SaveChanges();
                creado=true;
            }
            catch(System.Exception)
            {
                return creado;
                //throw;
            }
            return creado;
        }

        bool IRepositorioEscuelaArbitro.ActualizarEscuelaArbitro(EscuelaArbitro escuelaArbitro)
        {
            bool actualizado=false;
            var escArb=_appContext.EscuelasArbitros.Find(escuelaArbitro.Id);
            if(escArb!=null)
            {
                try
                {
                    escArb.Nombre=escuelaArbitro.Nombre;
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
        bool IRepositorioEscuelaArbitro.EliminarEscuelaArbitro(int idEscuelaArbitro)
        {
            bool eliminado=false;
            var escuelaArbitro=_appContext.EscuelasArbitros.Find(idEscuelaArbitro);
            if(escuelaArbitro!= null)
            {
                try
                {
                    _appContext.EscuelasArbitros.Remove(escuelaArbitro);
                    _appContext.SaveChanges();
                    eliminado=true;

                }
                catch(System.Exception)
                {
                    return eliminado;
                }
            }
            return eliminado;
        }
        EscuelaArbitro IRepositorioEscuelaArbitro.BuscarEscuelaArbitro(int idEscuelaArbitro)
        {
           EscuelaArbitro escuelaArbitro=_appContext.EscuelasArbitros.Find(idEscuelaArbitro);
           return escuelaArbitro;
        }
        IEnumerable<EscuelaArbitro> IRepositorioEscuelaArbitro.ListarEscuelaArbitros()
        {
            return _appContext.EscuelasArbitros;
        }
        bool Existe(EscuelaArbitro escArbit)
        {
            bool ex=false;
            var escArb=_appContext.Escenarios.FirstOrDefault(m=>m.Nombre==escArbit.Nombre);
            if(escArb!=null)
            {
                ex=true;
            }
            return ex;
            
        }
        
    }
}