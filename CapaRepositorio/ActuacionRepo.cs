using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDominio;

namespace CapaRepositorio
{
    public class ActuacionRepo
    {
        // METODO PARA GUARDAR UNA ACTUACION
        public void GuardarActuacion(Actuacion actuacion)
        {
            using (ModeloDeDominio modeloDeDominio = new ModeloDeDominio())
            {
                modeloDeDominio.Add(actuacion);
                modeloDeDominio.SaveChanges();
            }
        }

        // METODO PARA MOSTRAR LAS ACTUACIONES
        public IEnumerable<Actuacion> MostrarActuacion()
        {
            using (ModeloDeDominio modeloDeDominio = new ModeloDeDominio())
            {
                IEnumerable<Actuacion> result = modeloDeDominio.Actuacions.ToList();

                return modeloDeDominio.CreateDetachedCopy(result);
            }
        }
        public IEnumerable<Tematica> MostrarTematica()
        {
            using (ModeloDeDominio modeloDeDominio = new ModeloDeDominio())
            {
                IEnumerable<Tematica> result = modeloDeDominio.Tematicas.ToList();

                return modeloDeDominio.CreateDetachedCopy(result);
            }
        }
        public IEnumerable<ViaComunicacion> MostrarViaComunicacion()
        {
            using (ModeloDeDominio modeloDeDominio = new ModeloDeDominio())
            {
                IEnumerable<ViaComunicacion> result = modeloDeDominio.ViaComunicacions.ToList();

                return modeloDeDominio.CreateDetachedCopy(result);
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
        public IEnumerable<Actuacion> MostrarActuacionSegunPersona(Int32 id)
        {
            using (ModeloDeDominio modeloDeDominio = new ModeloDeDominio())
            {
                IEnumerable<Actuacion> result = modeloDeDominio.Actuacions.Where(c => c.IdPersona == id).ToList();

                return modeloDeDominio.CreateDetachedCopy(result);
            }
        }
    }
}
