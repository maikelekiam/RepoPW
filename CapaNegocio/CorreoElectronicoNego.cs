using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDominio;
using CapaRepositorio;

namespace CapaNegocio
{
    public class CorreoElectronicoNego
    {
        CorreoElectronicoRepo correoElectronicoRepo = new CorreoElectronicoRepo();

        public void GuardarCorreoElectronico(IList<CorreoElectronico> listaCorreoElectronicos)
        {
            correoElectronicoRepo.GuardarCorreoElectronico(listaCorreoElectronicos);
        }
    }
}
