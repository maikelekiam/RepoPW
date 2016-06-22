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
                return result;
            }
        }

        public Fondo ObtenerFondo(int id)
        {
            using (ModeloDeDominio modeloDeDominio = new ModeloDeDominio())
            {
                Fondo fondo = modeloDeDominio.Fondos.Where(c => c.IdFondo == id).FirstOrDefault();

                return fondo;
            }
        }

        public void ActualizarFondo(Fondo fondo)
        {
            using (ModeloDeDominio modeloDeDominio = new ModeloDeDominio())
            {
                modeloDeDominio.AttachCopy(fondo);
                modeloDeDominio.SaveChanges();
            }
        }

        public void EliminarFondo(int id)
        {
            using (ModeloDeDominio modeloDeDominio = new ModeloDeDominio())
            {
                IQueryable<Fondo> query = modeloDeDominio.GetAll<Fondo>().Where(c => c.IdFondo == id);

                foreach (Fondo fondo in query)
                {
                    modeloDeDominio.Delete(fondo.Convocatoria);

                    
                    modeloDeDominio.Delete(fondo);
                    modeloDeDominio.SaveChanges();
                }
            }
        }
    }
}
