// ARCHIVO REPOSITORIO DEPARTAMENTO**********PERSISTENCIA\REPOSITORIODEPARTAMENTO*******

using System.Collections.Generic;
using Dominio;
using System.Linq; 

namespace Persistencia
{
    public class RepositorioDepartamento : IRepositorioDepartamento
    {
        private readonly AppContext _appContext;
        public RepositorioDepartamento(AppContext appContext)
        {
            _appContext = appContext;
        }
        Departamento IRepositorioDepartamento.AddDepartamento(Departamento departamento)
        {
            var DepartamentoAdicionado=_appContext.Add(departamento);
            _appContext.SaveChanges();
            return DepartamentoAdicionado.Entity;
        }

        bool IRepositorioDepartamento.DeleteDepartamento(int IdDepartamento)
        {
            bool eliminado= false;
            var departamento=_appContext.Departamentos.Find(IdDepartamento);
            if(departamento!=null)
            {
                try
                {
                     _appContext.Departamentos.Remove(departamento);
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
        bool IRepositorioDepartamento.DeleteDepartamento(int IdDepartamento)
        {
            var DepartamentoEncontrado=_appContext.Departamentos.FirstOrDefault(p => p.Id==IdDepartamento);
            if(DepartamentoEncontrado==null)
            return;
            _appContext.Departamentos.Remove(DepartamentoEncontrado);
            _appContext.SaveChanges();
        }
        */
        IEnumerable<Departamento> IRepositorioDepartamento.GetAllDepartamento()
        {
            return _appContext.Departamentos;
        }
        
        Departamento IRepositorioDepartamento.GetDepartamento(int IdDepartamento)
        {
            return _appContext.Departamentos.FirstOrDefault(p => p.Id==IdDepartamento);
        }

        bool IRepositorioDepartamento.UpdateDepartamento(Departamento departamento)
        {
           bool actualizado= false;
           var mun=_appContext.Departamentos.Find(departamento.Id);
           if(mun!=null)
           {
               try
               {
                    mun.Nombre=departamento.Nombre;
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
        bool IRepositorioDepartamento.UpdateDepartamento(Departamento departamento)
        {
            var DepartamentoEncontrado=_appContext.Departamentos.FirstOrDefault(p => p.Id==departamento.Id);
            if (DepartamentoEncontrado.Nombre!=null)
            {
                DepartamentoEncontrado.Nombre=departamento.Nombre;
                _appContext.SaveChanges();
            }
            return DepartamentoEncontrado;

        }*/
        
    }    


}
