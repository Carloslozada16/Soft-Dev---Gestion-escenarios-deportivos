//  IREPOSITORIO DEPARTAMENTO*********PERSISTENCIA\DEPARTAMENTO******

using System.Collections.Generic;
using Dominio;
using System.Linq;

namespace Persistencia
{
    public interface IRepositorioDepartamento
    {
        IEnumerable<Departamento> GetAllDepartamento();
        Departamento AddDepartamento(Departamento departamento);
        bool UpdateDepartamento(Departamento departamento);
        bool DeleteDepartamento (int IdDepartamento);
        Departamento GetDepartamento (int IdDepartamento);
    }
}