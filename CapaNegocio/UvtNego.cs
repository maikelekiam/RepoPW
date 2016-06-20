using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDominio;
using CapaRepositorio;


namespace CapaNegocio
{
    public class UvtNego
    {
        UvtRepo uvtRepo = new UvtRepo();

        public IEnumerable<Uvt> MostrarUvt()
        {
            return uvtRepo.MostrarUvt();
        }

        public string TraerUvt(int id)
        {
            return uvtRepo.TraerUvt(id);
        }

        public void GuardarUvt(Uvt uvt)
        {
            uvtRepo.GuardarUvt(uvt);
        }
    }
}
