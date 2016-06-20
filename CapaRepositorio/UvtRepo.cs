using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDominio;

namespace CapaRepositorio
{
    public class UvtRepo
    {
        public IEnumerable<Uvt> MostrarUvt()
        {
            using (ModeloDeDominio modeloDeDominio = new ModeloDeDominio())
            {
                IEnumerable<Uvt> result = modeloDeDominio.Uvts.ToList();

                return modeloDeDominio.CreateDetachedCopy(result);
            }
        }
        public string TraerUvt(int id)
        {
            using (ModeloDeDominio modeloDeDominio = new ModeloDeDominio())
            {
                Uvt result = modeloDeDominio.Uvts.Where(c => c.IdUvt == id).FirstOrDefault();

                modeloDeDominio.CreateDetachedCopy(result);

                return result.NombreUvt;
            }
        }

        public void GuardarUvt(Uvt uvt)
        {
            using (ModeloDeDominio modeloDeDominio = new ModeloDeDominio())
            {
                modeloDeDominio.Add(uvt);
                modeloDeDominio.SaveChanges();
            }
        }
    }
}
