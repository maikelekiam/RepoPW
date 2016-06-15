using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDominio;
using CapaRepositorio;

namespace CapaNegocio
{
    class TipoDestinatarioNego
    {
        TipoDestinatarioRepo tipoDestinatarioRepo = new TipoDestinatarioRepo();
        public void GuardarTipoDestinatario(TipoDestinatario tipoDestinatario)
        {
            tipoDestinatarioRepo.GuardarTipoDestinatario(tipoDestinatario);
        }

        public IEnumerable<TipoDestinatario> MostrarTipoDestinatarioes()
        {
            return tipoDestinatarioRepo.MostrarTipoDestinatarios();
        }
    }
}
