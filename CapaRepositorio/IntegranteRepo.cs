using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDominio;

namespace CapaRepositorio
{
    public class IntegranteRepo
    {
        public void GuardarIntegrante(Integrante integrante)
        {
            using (ModeloDeDominio modeloDeDominio = new ModeloDeDominio())
            {
                modeloDeDominio.Add(integrante);
                modeloDeDominio.SaveChanges();
            }
        }

        public IEnumerable<Integrante> MostrarIntegrantes()
        {
            using (ModeloDeDominio modeloDeDominio = new ModeloDeDominio())
            {
                IEnumerable<Integrante> result = modeloDeDominio.Integrantes.ToList();
                return modeloDeDominio.CreateDetachedCopy(result);
            }
        }

        public void BorrarIntegrantesPorProyecto(int idProyecto)
        {
            using (ModeloDeDominio modeloDeDominio = new ModeloDeDominio())
            {
                IQueryable<Integrante> query = modeloDeDominio.GetAll<Integrante>().Where(c => c.IdProyecto == idProyecto);

                foreach (Integrante i in query)
                {
                    modeloDeDominio.Delete(i);
                    modeloDeDominio.SaveChanges();
                }
            }
        }
    }
}
