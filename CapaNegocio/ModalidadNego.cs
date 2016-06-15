using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDominio;
using CapaRepositorio;

namespace CapaNegocio
{
    public class ModalidadNego
    {
        ModalidadRepo modalidadRepo = new ModalidadRepo();
        public void GuardarModalidad(Modalidad modalidad)
        {
            modalidadRepo.GuardarModalidad(modalidad);
        }

        public IEnumerable<Modalidad> MostrarModalidades()
        {
            return modalidadRepo.MostrarModalidades();
        }
    }
}
