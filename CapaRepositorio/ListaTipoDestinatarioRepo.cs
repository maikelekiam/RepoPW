using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDominio;

namespace CapaRepositorio
{
    public class ListaTipoDestinatarioRepo
    {
        public void GuardarListaTipoDestinatario(ListaTipoDestinatario listaTipoDestinatario)
        {
            using (ModeloDeDominio modeloDeDominio = new ModeloDeDominio())
            {
                modeloDeDominio.Add(listaTipoDestinatario);
                modeloDeDominio.SaveChanges();
            }
        }

        public IEnumerable<ListaTipoDestinatario> MostrarListaTipoDestinatarios()
        {
            using (ModeloDeDominio modeloDeDominio = new ModeloDeDominio())
            {
                IEnumerable<ListaTipoDestinatario> result = modeloDeDominio.ListaTipoDestinatarios.ToList();
                return modeloDeDominio.CreateDetachedCopy(result);
            }
        }

        public void BorrarListaDestinatarioPorConvocatoria(int id)
        {
            using (ModeloDeDominio modeloDeDominio = new ModeloDeDominio())
            {
                IQueryable<ListaTipoDestinatario> query = modeloDeDominio.GetAll<ListaTipoDestinatario>().Where(c => c.IdConvocatoria == id);

                foreach (ListaTipoDestinatario ltd in query)
                {
                    modeloDeDominio.Delete(ltd);
                    modeloDeDominio.SaveChanges();
                }
            }
        }
    }
}
