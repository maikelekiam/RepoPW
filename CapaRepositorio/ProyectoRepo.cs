using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDominio;

namespace CapaRepositorio
{
    public class ProyectoRepo
    {
        public IEnumerable<Proyecto> MostrarProyecto()
        {
            using (ModeloDeDominio modeloDeDominio = new ModeloDeDominio())
            {
                IEnumerable<Proyecto> result = modeloDeDominio.Proyectos.ToList();

                return modeloDeDominio.CreateDetachedCopy(result);
            }
        }
        public string TraerProyecto(int id)
        {
            using (ModeloDeDominio modeloDeDominio = new ModeloDeDominio())
            {
                Proyecto result = modeloDeDominio.Proyectos.Where(c => c.IdProyecto == id).FirstOrDefault();

                modeloDeDominio.CreateDetachedCopy(result);

                return result.Nombre;
            }
        }

        public int GuardarProyecto(Proyecto proyecto)
        {
            using (ModeloDeDominio modeloDeDominio = new ModeloDeDominio())
            {
                modeloDeDominio.Add(proyecto);
                modeloDeDominio.SaveChanges();
                return proyecto.IdProyecto;
            }
        }

        public void ActualizarProyecto(Proyecto proyecto)
        {
            using (ModeloDeDominio modeloDeDominio = new ModeloDeDominio())
            {
                modeloDeDominio.AttachCopy(proyecto);
                modeloDeDominio.SaveChanges();
            }
        }

        public Proyecto ObtenerProyecto(int id)
        {
            using (ModeloDeDominio modeloDeDominio = new ModeloDeDominio())
            {
                Proyecto proyecto = modeloDeDominio.Proyectos.Where(c => c.IdProyecto == id).FirstOrDefault();

                return proyecto;
            }
        }
    }
}
