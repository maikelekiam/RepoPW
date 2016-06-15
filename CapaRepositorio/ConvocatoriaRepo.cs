using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDominio;


namespace CapaRepositorio
{
    public class ConvocatoriaRepo
    {
        public void GuardarConvocatoria(Convocatorium convocatoria)
        {
            using (ModeloDeDominio modeloDeDominio = new ModeloDeDominio())
            {
                modeloDeDominio.Add(convocatoria);
                modeloDeDominio.SaveChanges();
            }
        }

        public IEnumerable<Convocatorium> MostrarConvocatorias()
        {
            using (ModeloDeDominio modeloDeDominio = new ModeloDeDominio())
            {
                IEnumerable<Convocatorium> result = modeloDeDominio.Convocatoria.ToList();
                return result;
            }
        }

        public void ActualizarConvocatoria(Convocatorium convocatoria)
        {
            using (ModeloDeDominio modeloDeDominio = new ModeloDeDominio())
            {
                modeloDeDominio.AttachCopy(convocatoria);
                modeloDeDominio.SaveChanges();
            }
        }

        public Convocatorium ObtenerConvocatoria(int id)
        {
            using (ModeloDeDominio modeloDeDominio = new ModeloDeDominio())
            {
                Convocatorium convocatoria = modeloDeDominio.Convocatoria.Where(c => c.IdConvocatoria == id).FirstOrDefault();

                return convocatoria;
            }
        }
    }
}
