using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDominio;
using CapaRepositorio;

namespace CapaNegocio
{
    //nada
    public class PersonaNego
    {
        PersonaRepo personaRepo = new PersonaRepo();

        public IEnumerable<Persona> MostrarPersona()
        {
            return personaRepo.MostrarPersona();
        }
        public int GuardarPersona(Persona persona)
        {
            return personaRepo.GuardarPersona(persona);
        }

        public void ActualizarPersona(Persona persona)
        {
            personaRepo.ActualizarPersona(persona);
        }

        public void EliminarPersona(int id)
        {
            personaRepo.EliminarPersona(id);
        }
    }
}
