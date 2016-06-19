using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDominio;
using CapaRepositorio;

namespace CapaNegocio
{
    public class LocalidadNego
    {
        LocalidadRepo localidadRepo = new LocalidadRepo();

        public IEnumerable<Localidad> MostrarLocalidades()
        {
            return localidadRepo.MostrarLocalidades();
        }

        public string TraerLocalidadSegunIdPersona(int id)
        {
            return localidadRepo.TraerLocalidadSegunIdPersona(id);
        }
    }
}
