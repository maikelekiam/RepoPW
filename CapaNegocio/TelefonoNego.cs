using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDominio;
using CapaRepositorio;


namespace CapaNegocio
{
    public class TelefonoNego
    {
        TelefonoRepo telefonoRepo = new TelefonoRepo();

        public void GuardarTelefono(IList<Telefono> listaTelefonos)
        {
            telefonoRepo.GuardarTelefono(listaTelefonos);
        }
    }

}