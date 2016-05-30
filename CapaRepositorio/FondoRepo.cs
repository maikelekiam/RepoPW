using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDominio;

namespace CapaRepositorio
{
    public class FondoRepo
    {
        public void GuardarFondo(Fondo fondo)
        {
            using (ModeloDeDominio modeloDeDominio = new ModeloDeDominio())
            {
                modeloDeDominio.Add(fondo);
                modeloDeDominio.SaveChanges();
            }
        }

        public IEnumerable<Fondo> MostrarFondos()
        {
            using (ModeloDeDominio modeloDeDominio = new ModeloDeDominio())
            {
                IEnumerable<Fondo> result = modeloDeDominio.Fondos.ToList();
                return modeloDeDominio.CreateDetachedCopy(result);
            }
        }
    }
}
