
using System;
using System.Collections.Generic;
using System.Linq;
using Dominio;

namespace Persistencia
{
public class RepositoryPersona : IRepositoryPersona
{
private readonly AplicationContext _appContext;

    public RepositoryPersona(AplicationContext appContext)
    {
        _appContext= appContext;
    }


    Persona IRepositoryPersona.AddPersona(Persona persona)
    {
        var personaAdicionada= _appContext.Personas.Add(persona);
        _appContext.SaveChanges();
        return personaAdicionada.Entity;
    }


    void IRepositoryPersona.DeletePersona(int idPersona)
    {
        var personaEncontrada= _appContext.Personas.FirstOrDefault(p=> p.id.Equals(idPersona));
        if (personaEncontrada== null)
        return;
        _appContext.Personas.Remove(personaEncontrada);
        _appContext.SaveChanges();
    }


    IEnumerable<Persona> IRepositoryPersona.GetAllPersona()
    {
        return _appContext.Personas;
    }


    Persona IRepositoryPersona.GetPersona(int idPersona)
    {
        return _appContext.Personas.FirstOrDefault(p=> p.id.Equals(idPersona));
    }
    

    Persona IRepositoryPersona.UpdatePersona(Persona persona)
    {
        var personaEncontrada= _appContext.Personas.FirstOrDefault(p=> p.id.Equals(persona.id));
        if (personaEncontrada!=null)
        {
            personaEncontrada.nombre=persona.nombre;
            personaEncontrada.edad=persona.edad;
            personaEncontrada.direccion=persona.direccion;
            personaEncontrada.telefono=persona.telefono;

            _appContext.SaveChanges();

        }
        return personaEncontrada;
    }
} 
}