using System.Collections.Generic;
using Dominio;
using System.Linq;

namespace Persistencia

{
    public class RepositorioEscenario: IRepositorioEscenario
    {
        private readonly AppContext _appContext;
        public RepositorioEscenario(AppContext appContext)
        {
            _appContext=appContext;
        }
        bool IRepositorioEscenario.CrearEscenario(Escenario escenario)
        {
            bool creado=false;
            bool ex=Existe(escenario);
            if (!ex)
            {
               try{
                _appContext.Escenarios.Add(escenario);
                _appContext.SaveChanges();
                creado=true;
                }
                catch(System.Exception)
                {
                    return creado; 
                }
            }    
            try{
                _appContext.Escenarios.Add(escenario);
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
        bool IRepositorioEscenario.ActualizarEscenario(Escenario escenario)
        {
            bool actualizado=false;
            var esc=_appContext.Escenarios.Find(escenario.Id);
            if(esc!=null)
            {
                try
                {
                    esc.Nombre=escenario.Nombre;
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
        bool IRepositorioEscenario.EliminarEscenario(int idEscenario)
        {
            bool eliminado=false;
            var escenario=_appContext.Escenarios.Find(idEscenario);
            if(escenario!= null)
            {
                try
                {
                    _appContext.Escenarios.Remove(escenario);
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
        Escenario IRepositorioEscenario.BuscarEscenario(int idEscenario)
        {
           Escenario escenario=_appContext.Escenarios.Find(idEscenario);
           return escenario;
        }
        IEnumerable<Escenario> IRepositorioEscenario.ListarEscenarios()
        {
            return _appContext.Escenarios;
        }
        bool Existe(Escenario escen)
        {
            bool ex=false;
            var esc=_appContext.Escenarios.FirstOrDefault(m=>m.Nombre==escen.Nombre);
            if(esc!=null)
            {
                ex=true;
            }
            return ex;
            
        }
    }
}