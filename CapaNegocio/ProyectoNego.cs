using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDominio;
using CapaRepositorio;

namespace CapaNegocio
{
    public class ProyectoNego
    {
        ProyectoRepo proyectoRepo = new ProyectoRepo();

        public IEnumerable<Proyecto> MostrarProyecto()
        {
            return proyectoRepo.MostrarProyecto();
        }

        public string TraerProyecto(int id)
        {
            return proyectoRepo.TraerProyecto(id);
        }

        public void GuardarProyecto(Proyecto proyecto)
        {
            proyectoRepo.GuardarProyecto(proyecto);
        }
    }
}
