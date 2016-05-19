﻿using System;
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

    }
}
