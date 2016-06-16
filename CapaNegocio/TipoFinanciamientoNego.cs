using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDominio;
using CapaRepositorio;

namespace CapaNegocio
{
    public class TipoFinanciamientoNego
    {
        TipoFinanciamientoRepo tipoFinanciamientoRepo = new TipoFinanciamientoRepo();
        public void GuardarTipoFinanciamiento(TipoFinanciamiento tipoFinanciamiento)
        {
            tipoFinanciamientoRepo.GuardarTipoFinanciamiento(tipoFinanciamiento);
        }

        public IEnumerable<TipoFinanciamiento> MostrarTipoFinanciamientoes()
        {
            return tipoFinanciamientoRepo.MostrarTipoFinanciamientos();
        }
    }
}
