﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDominio;

namespace CapaRepositorio
{
    public class ViaComunicacionRepo
    {
        public IEnumerable<ViaComunicacion> MostrarViaComunicacion()
        {
            using (ModeloDeDominio modeloDeDominio = new ModeloDeDominio())
            {
                IEnumerable<ViaComunicacion> result = modeloDeDominio.ViaComunicacions.ToList();

                return modeloDeDominio.CreateDetachedCopy(result);
            }
        }
    }
}
