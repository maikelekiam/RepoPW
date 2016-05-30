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

        public void GuardarProyecto(Proyecto proyecto)
        {
            proyectoRepo.GuardarProyecto(proyecto);
        }
    }
}
