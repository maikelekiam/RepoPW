using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDominio;

namespace CapaRepositorio
{
    public class ViaComunicacionRepo
    {
        public IEnumerable<ViaComunicacion> MostrarViaComunicacion()
        {
            using (ModeloDeDominio modeloDeDominio = new ModeloDeDominio())
            {
                IEnumerable<ViaComunicacion> result = modeloDeDominio.ViaComunicacions.ToList();

                return modeloDeDominio.CreateDetachedCopy(result);
            }
        }

        public string TraerViaComunicacion(int id)
        {
            using (ModeloDeDominio modeloDeDominio = new ModeloDeDominio())
            {
                ViaComunicacion result = modeloDeDominio.ViaComunicacions.Where(c => c.IdViaComunicacion == id).FirstOrDefault();

                modeloDeDominio.CreateDetachedCopy(result);

                return result.Nombre;
            }
        }
        public void GuardarViaComunicacion(ViaComunicacion viaComunicacion)
        {
            using (ModeloDeDominio modeloDeDominio = new ModeloDeDominio())
            {
                modeloDeDominio.Add(viaComunicacion);
                modeloDeDominio.SaveChanges();
            }
        }
    }
}
