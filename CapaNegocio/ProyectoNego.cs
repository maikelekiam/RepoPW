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

        public IEnumerable<Proyecto> MostrarProyectosEnEjecucion()
        {
            return proyectoRepo.MostrarProyectosEnEjecucion();
        }

        public string TraerProyecto(int id)
        {
            return proyectoRepo.TraerProyecto(id);
        }

        public int GuardarProyecto(Proyecto proyecto)
        {
            return proyectoRepo.GuardarProyecto(proyecto);
        }
        public void ActualizarProyecto(Proyecto proyecto)
        {
            proyectoRepo.ActualizarProyecto(proyecto);
        }
        public Proyecto ObtenerProyecto(int id)
        {
            return proyectoRepo.ObtenerProyecto(id);
        }
    }
}
