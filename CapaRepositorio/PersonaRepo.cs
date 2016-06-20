using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDominio;

namespace CapaRepositorio
{
    public class PersonaRepo
    {
        // METODO PARA GUARDAR UNA PERSONA
        public int GuardarPersona(Persona persona)
        {
            using (ModeloDeDominio modeloDeDominio = new ModeloDeDominio())
            {
                modeloDeDominio.Add(persona);
                modeloDeDominio.SaveChanges();
                int idPersona = persona.IdPersona;
                return idPersona;
            }
        }

        // METODO PARA MOSTRAR LAS PERSONAS
        public IEnumerable<Persona> MostrarPersona()
        {
            using (ModeloDeDominio modeloDeDominio = new ModeloDeDominio())
            {
                IEnumerable<Persona> result = modeloDeDominio.Personas.ToList();

                return modeloDeDominio.CreateDetachedCopy(result);
            }
        }

        public void ActualizarPersona(Persona persona)
        {
            using (ModeloDeDominio modeloDeDominio = new ModeloDeDominio())
            {
                modeloDeDominio.AttachCopy(persona);
                modeloDeDominio.SaveChanges();
            }
        }

        public void EliminarPersona(int id)
        {
            using (ModeloDeDominio modeloDeDominio = new ModeloDeDominio())
            {
                IQueryable<Persona> query = modeloDeDominio.GetAll<Persona>().Where(c => c.IdPersona == id);

                foreach (Persona persona in query)
                {
                    modeloDeDominio.Delete(persona.CorreoElectronicos);
                    modeloDeDominio.Delete(persona.Telefonos);
                    modeloDeDominio.Delete(persona.Actuacions);
                    modeloDeDominio.Delete(persona.Integrantes);
                    modeloDeDominio.Delete(persona);
                    modeloDeDominio.SaveChanges();
                }
            }
        }
    }
}
