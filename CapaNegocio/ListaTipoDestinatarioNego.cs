using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDominio;
using CapaRepositorio;

namespace CapaNegocio
{
    public class ListaTipoDestinatarioNego
    {
        ListaTipoDestinatarioRepo listaTipoDestinatarioRepo = new ListaTipoDestinatarioRepo();
        public void GuardarListaTipoDestinatario(ListaTipoDestinatario listaTipoDestinatario)
        {
            listaTipoDestinatarioRepo.GuardarListaTipoDestinatario(listaTipoDestinatario);
        }

        public IEnumerable<ListaTipoDestinatario> MostrarListaTipoDestinatarios()
        {
            return listaTipoDestinatarioRepo.MostrarListaTipoDestinatarios();
        }

        public void BorrarListaDestinatarioPorConvocatoria(int id)
        {
            listaTipoDestinatarioRepo.BorrarListaDestinatarioPorConvocatoria(id);
        }
    }
}
