using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDominio;
using CapaRepositorio;

namespace CapaNegocio
{
    public class TipoDestinatarioNego
    {
        TipoDestinatarioRepo tipoDestinatarioRepo=new TipoDestinatarioRepo();
        public IEnumerable<TipoDestinatario> MostrarTipoDestinatarios()
        {
            return tipoDestinatarioRepo.MostrarTipoDestinatarios();
        }

        public TipoDestinatario ObtenerTipoDestinatario(int id)
        {
            return tipoDestinatarioRepo.ObtenerTipoDestinatario(id);
        }
    }
}
