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
        public void GuardarProyecto(Proyecto proyecto)
        {
            using (ModeloDeDominio modeloDeDominio = new ModeloDeDominio())
            {
                modeloDeDominio.Add(proyecto);
                modeloDeDominio.SaveChanges();
            }
        }
    }
}
