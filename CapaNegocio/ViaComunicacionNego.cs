using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDominio;
using CapaRepositorio;

namespace CapaNegocio
{
    public class ViaComunicacionNego
    {
        ViaComunicacionRepo viaComunicacionRepo = new ViaComunicacionRepo();

        public IEnumerable<ViaComunicacion> MostrarViaComunicacion()
        {
            return viaComunicacionRepo.MostrarViaComunicacion();
        }

        public string TraerViaComunicacion(int id)
        {
            return viaComunicacionRepo.TraerViaComunicacion(id);
        }
        public int GuardarViaComunicacion(ViaComunicacion viaComunicacion)
        {
            return viaComunicacionRepo.GuardarViaComunicacion(viaComunicacion);
        }
        public int TraerViaComunicacionIdSegunItem(string item)
        {
            return viaComunicacionRepo.TraerViaComunicacionIdSegunItem(item);
        }
    }
}
