using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDominio;

namespace CapaRepositorio
{
    public class TipoDestinatarioRepo
    {
        public IEnumerable<TipoDestinatario> MostrarTipoDestinatarios()
        {
            using (ModeloDeDominio modeloDeDominio = new ModeloDeDominio())
            {
                IEnumerable<TipoDestinatario> result = modeloDeDominio.TipoDestinatarios.ToList();
                return modeloDeDominio.CreateDetachedCopy(result);
            }
        }

        public TipoDestinatario ObtenerTipoDestinatario(int id)
        {
            using (ModeloDeDominio modeloDeDominio = new ModeloDeDominio())
            {
                return modeloDeDominio.TipoDestinatarios.Where(c => c.IdTipoDestinatario == id).FirstOrDefault();

                
            }
        }

    }
}
