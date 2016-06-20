using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDominio;

namespace CapaRepositorio
{
    public class AreaProductivaRepo
    {
        public IEnumerable<AreaProductiva> MostrarAreaProductiva()
        {
            using (ModeloDeDominio modeloDeDominio = new ModeloDeDominio())
            {
                IEnumerable<AreaProductiva> result = modeloDeDominio.AreaProductivas.ToList();

                return modeloDeDominio.CreateDetachedCopy(result);
            }
        }
        public string TraerAreaProductiva(int id)
        {
            using (ModeloDeDominio modeloDeDominio = new ModeloDeDominio())
            {
                AreaProductiva result = modeloDeDominio.AreaProductivas.Where(c => c.IdAreaProductiva == id).FirstOrDefault();

                modeloDeDominio.CreateDetachedCopy(result);

                return result.Nombre;
            }
        }

        public void GuardarAreaProductiva(AreaProductiva areaProductiva)
        {
            using (ModeloDeDominio modeloDeDominio = new ModeloDeDominio())
            {
                modeloDeDominio.Add(areaProductiva);
                modeloDeDominio.SaveChanges();
            }
        }


    }
}
