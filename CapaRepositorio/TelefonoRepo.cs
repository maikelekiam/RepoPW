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
        //Repositorio telefono
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

        public List<Telefono> TraerListaTelefonos(int id)
        {
            List<Telefono> datosLista;

            using (ModeloDeDominio modeloDeDominio = new ModeloDeDominio())
            {
                IEnumerable<Telefono> listaDeTelefonos = modeloDeDominio.Telefonos.Where(c => c.IdPersona == id).ToList();
                datosLista = (List<Telefono>)listaDeTelefonos;
            }
            return datosLista;
        }
    }
}