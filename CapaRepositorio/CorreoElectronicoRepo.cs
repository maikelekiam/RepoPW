using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDominio;

namespace CapaRepositorio
{
    public class CorreoElectronicoRepo
    {
        public void GuardarCorreoElectronico(IList<CorreoElectronico> listaCorreoElectronicos)
        {
            using (ModeloDeDominio modeloDeDominio = new ModeloDeDominio())
            {
                foreach (CorreoElectronico correoElectronico in listaCorreoElectronicos)
                {
                    modeloDeDominio.Add(correoElectronico);
                    modeloDeDominio.SaveChanges();
                }
            }
        }
    }
}
