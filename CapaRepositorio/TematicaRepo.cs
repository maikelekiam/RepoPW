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
        public string TraerTematica(int id)
        {
            using (ModeloDeDominio modeloDeDominio = new ModeloDeDominio())
            {
                Tematica result = modeloDeDominio.Tematicas.Where(c => c.IdTematica == id).FirstOrDefault();

                modeloDeDominio.CreateDetachedCopy(result);

                return result.Nombre;
            }
        }

        public void GuerdarTematica(Tematica tematica)
        {
            using (ModeloDeDominio modeloDeDominio = new ModeloDeDominio())
            {
                modeloDeDominio.Add(tematica);
                modeloDeDominio.SaveChanges();
            }
        }

    }
}
