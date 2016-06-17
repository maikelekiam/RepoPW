using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDominio;

namespace CapaRepositorio
{
    public class TematicaRepo
    {
        public IEnumerable<Tematica> MostrarTematica()
        {
            using (ModeloDeDominio modeloDeDominio = new ModeloDeDominio())
            {
                IEnumerable<Tematica> result = modeloDeDominio.Tematicas.ToList();

                return modeloDeDominio.CreateDetachedCopy(result);
            }
        }

    }
}
