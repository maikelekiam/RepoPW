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
        public List<CorreoElectronico> TraerListaCorreoElectronicos(int id)
        {
            List<CorreoElectronico> datosLista;

            using (ModeloDeDominio modeloDeDominio = new ModeloDeDominio())
            {
                IEnumerable<CorreoElectronico> listaDeCorreos = modeloDeDominio.CorreoElectronicos.Where(c => c.IdPersona == id).ToList();
                datosLista = (List<CorreoElectronico>)listaDeCorreos;
            }
            return datosLista;
        }
    }
}
