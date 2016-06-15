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
        public void GuardarTipoDestinatario(TipoDestinatario tipoDestinatario)
        {
            using (ModeloDeDominio modeloDeDominio = new ModeloDeDominio())
            {
                modeloDeDominio.Add(tipoDestinatario);
                modeloDeDominio.SaveChanges();
            }
        }

        public IEnumerable<TipoDestinatario> MostrarTipoDestinatarios()
        {
            using (ModeloDeDominio modeloDeDominio = new ModeloDeDominio())
            {
                IEnumerable<TipoDestinatario> result = modeloDeDominio.TipoDestinatarios.ToList();
                return modeloDeDominio.CreateDetachedCopy(result);
            }
        }
    }
    }
}
