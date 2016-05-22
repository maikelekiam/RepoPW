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
        public void GuardarPersona(Persona persona)
        {
            using (ModeloDeDominio modeloDeDominio = new ModeloDeDominio())
            {
                modeloDeDominio.Add(persona);
                modeloDeDominio.SaveChanges();
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

        public IEnumerable<Localidad> MostrarLocalidad()
        {
            using (ModeloDeDominio modeloDeDominio = new ModeloDeDominio())
            {
                IEnumerable<Localidad> result = modeloDeDominio.Localidads.ToList();

                return modeloDeDominio.CreateDetachedCopy(result);
            }
        }
        public IEnumerable<Telefono> MostrarTelefono()
        {
            using (ModeloDeDominio modeloDeDominio = new ModeloDeDominio())
            {
                IEnumerable<Telefono> result = modeloDeDominio.Telefonos.ToList();

                return modeloDeDominio.CreateDetachedCopy(result);
            }
        }
        public IEnumerable<CorreoElectronico> MostrarCorreoElectronico()
        {
            using (ModeloDeDominio modeloDeDominio = new ModeloDeDominio())
            {
                IEnumerable<CorreoElectronico> result = modeloDeDominio.CorreoElectronicos.ToList();

                return modeloDeDominio.CreateDetachedCopy(result);
            }
        }
        public void GuardarTelefono(Telefono telefono)
        {
            using (ModeloDeDominio modeloDeDominio = new ModeloDeDominio())
            {
                modeloDeDominio.Add(telefono);
                modeloDeDominio.SaveChanges();
            }

        }
    }
}
