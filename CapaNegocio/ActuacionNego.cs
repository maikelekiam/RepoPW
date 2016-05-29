using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDominio;
using CapaRepositorio;

namespace CapaNegocio
{
    public class ActuacionNego
    {
        ActuacionRepo actuacionRepo = new ActuacionRepo();

        public IEnumerable<Actuacion> MostrarActuacion()
        {
            return actuacionRepo.MostrarActuacion();
        }
        public void GuardarActuacion(Actuacion actuacion)
        {
            actuacionRepo.GuardarActuacion(actuacion);
        }
        public IEnumerable<Tematica> MostrarTematica()
        {
            return actuacionRepo.MostrarTematica();
        }
        public IEnumerable<ViaComunicacion> MostrarViaComunicacion()
        {
            return actuacionRepo.MostrarViaComunicacion();
        }
        public IEnumerable<Persona> MostrarPersona()
        {
            return actuacionRepo.MostrarPersona();
        }
        public IEnumerable<Actuacion> MostrarActuacionSegunPersona(string doc)
        {
            return actuacionRepo.MostrarActuacionSegunPersona(doc);
        }
        public Int32 MostrarIdPersonaSegunDocumento(string documento)
        {
            return actuacionRepo.MostrarIdPersonaSegunDocumento(documento);
        }

    }
}
