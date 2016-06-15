using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDominio;

namespace CapaRepositorio
{
    public class TelefonoRepo
    {
        public void GuardarTelefono(IList<Telefono> listaTelefonos)
        {
            using (ModeloDeDominio modeloDeDominio = new ModeloDeDominio())
            {
                foreach (Telefono telefono in listaTelefonos)
                {
                    modeloDeDominio.Add(telefono);
                    modeloDeDominio.SaveChanges();
                }
            }
        }
    }
}