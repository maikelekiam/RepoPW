﻿using System;
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
        public void GuardarPersona(Persona persona)
        {
            personaRepo.GuardarPersona(persona);
        }
        public IEnumerable<Localidad> MostrarLocalidad()
        {
            return personaRepo.MostrarLocalidad();
        }
        public IEnumerable<Telefono> MostrarTelefono()
        {
            return personaRepo.MostrarTelefono();
        }
        public IEnumerable<CorreoElectronico> MostrarCorreoElectronico()
        {
            return personaRepo.MostrarCorreoElectronico();
        }
        public void GuardarTelefono(Telefono telefono)
        {
            personaRepo.GuardarTelefono(telefono);
        }
    }

}