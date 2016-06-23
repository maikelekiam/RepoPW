using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDominio;
using CapaRepositorio;

namespace CapaNegocio
{
    public class FondoNego
    {
        FondoRepo fondoRepo = new FondoRepo();
        public void GuardarFondo(Fondo fondo)
        {
            fondoRepo.GuardarFondo(fondo);
        }

        public IEnumerable<Fondo> MostrarFondos()
        {
            return fondoRepo.MostrarFondos();
        }

        public void ActualizarFondo(Fondo fondo)
        {
            fondoRepo.ActualizarFondo(fondo);
        }

        public void EliminarFondo(int id)
        {
            fondoRepo.EliminarFondo(id);
        }
        public Fondo ObtenerFondo(int id)
        {
            return fondoRepo.ObtenerFondo(id);
        }

    }
}
