﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDominio;
using CapaRepositorio;


namespace CapaNegocio
{
    public class TelefonoNego
    {
        TelefonoRepo telefonoRepo = new TelefonoRepo();

        public void GuardarTelefono(IList<Telefono> listaTelefonos)
        {
            telefonoRepo.GuardarTelefono(listaTelefonos);
        }

        public List<Telefono> TraerListaTelefonos(int id)
        {
            return telefonoRepo.TraerListaTelefonos(id);
        }

        public void ActualizarTelefono(int id, IList<Telefono> listaTelefonos)
        {
            telefonoRepo.ActualizarTelefono(id, listaTelefonos);
        }
    }
}