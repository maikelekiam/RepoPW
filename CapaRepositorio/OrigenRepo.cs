using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDominio;


namespace CapaRepositorio
{
    public class OrigenRepo
    {
        public void GuardarOrigen(Origen origen)
        {
            using (ModeloDeDominio modeloDeDominio = new ModeloDeDominio())
            {
                modeloDeDominio.Add(origen);
                modeloDeDominio.SaveChanges();
            }
        }

        public IEnumerable<Origen> MostrarOrigenes()
        {
            using (ModeloDeDominio modeloDeDominio = new ModeloDeDominio())
            {
                IEnumerable<Origen> result = modeloDeDominio.Origens.ToList();
                return modeloDeDominio.CreateDetachedCopy(result);
            }
        }
    }
}


