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

                //foreach (Telefono telefono in listaTelefonos)
                //{
                //    Telefono newTelefono = new Telefono();
                //    newTelefono.Telefono1 = telefono.Telefono1.ToString();
                //    newTelefono.IdPersona = idPersona;
                //    newTelefono.Activo = true;

                //    persona.Telefonos.Add(newTelefono);
                   
                //}

                //foreach (CorreoElectronico correoe in listaCorreoElectronicos)
                //{
                //    CorreoElectronico newCorreoElectronico = new CorreoElectronico();
                //    newCorreoElectronico.CorreoElectronico1 = correoe.CorreoElectronico1.ToString();
                //    newCorreoElectronico.Activo = true;

                //    modeloDeDominio.Add(persona);

                //    persona.CorreoElectronicos.Add(newCorreoElectronico);
                //    modeloDeDominio.SaveChanges();
                //}
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

        public IEnumerable<Localidad> MostrarLocalidad()
        {
            using (ModeloDeDominio modeloDeDominio = new ModeloDeDominio())
            {
                IEnumerable<Localidad> result = modeloDeDominio.Localidads.ToList();

                return modeloDeDominio.CreateDetachedCopy(result);
            }
        }
        //public void GuardarTelefonos(List<string> lista, Int32 idTemporal)
        //{
        //    using (ModeloDeDominio modeloDeDominio = new ModeloDeDominio())
        //    {
        //        foreach (string elemento in lista)
        //        {
        //            Telefono tel = new Telefono();
        //            tel.IdPersona = idTemporal;
        //            tel.Telefono1 = elemento;
        //            tel.Activo = true;

        //            modeloDeDominio.Add(tel);
        //            modeloDeDominio.SaveChanges();
        //        }
        //    }
        //}

        //public Int32 MostrarUltimoIdPersona()
        //{
        //    using (ModeloDeDominio modeloDeDominio = new ModeloDeDominio())
        //    {
        //        Persona result = modeloDeDominio.Personas.LastOrDefault();
        //        return result.IdPersona;
        //    }
        //}
    }
}
