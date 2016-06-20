using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDominio;

namespace CapaRepositorio
{
    public class EstadoRepo
    {
        public IEnumerable<Estado> MostrarEstado()
        {
            using (ModeloDeDominio modeloDeDominio = new ModeloDeDominio())
            {
                IEnumerable<Estado> result = modeloDeDominio.Estados.ToList();

                return modeloDeDominio.CreateDetachedCopy(result);
            }
        }

        public void GuardarEstado(Estado estado)
        {
            using (ModeloDeDominio modeloDeDominio = new ModeloDeDominio())
            {
                modeloDeDominio.Add(estado);
                modeloDeDominio.SaveChanges();
            }
        }

        public string TraerEstado(int id)
        {
            using (ModeloDeDominio modeloDeDominio = new ModeloDeDominio())
            {
                Estado result = modeloDeDominio.Estados.Where(c => c.IdEstado == id).FirstOrDefault();

                modeloDeDominio.CreateDetachedCopy(result);

                return result.Nombre;
            }
        }
    }
}
