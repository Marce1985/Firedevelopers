using Dominio;
using  System.Collections.Generic;
namespace Persistencia
{
    public interface IRepositoryPersona
    {
        IEnumerable<Persona> GetAllPersona();
        Persona AddPersona(Persona persona);
        Persona UpdatePersona(Persona persona);
        void DeletePersona(int idPersona);
        Persona GetPersona(int idPersona);
         
    }
}