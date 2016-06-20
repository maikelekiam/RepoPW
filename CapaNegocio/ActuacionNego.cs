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

        //public IEnumerable<Actuacion> MostrarActuacion()
        //{
        //    return actuacionRepo.MostrarActuacion();
        //}
        public int GuardarActuacion(Actuacion actuacion)
        {
            return actuacionRepo.GuardarActuacion(actuacion);
        }
        
        
        public IEnumerable<Actuacion> MostrarActuacionSegunPersona(int id)
        {
            return actuacionRepo.MostrarActuacionSegunPersona(id);
        }

        public void EliminarActuacion(int id)
        {
            actuacionRepo.EliminarActuacion(id);
        }

        public void ActualizarActuacion(Actuacion actuacion)
        {
            actuacionRepo.ActualizarActuacion(actuacion);
        }
    }
}
