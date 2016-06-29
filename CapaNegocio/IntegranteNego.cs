using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDominio;
using CapaRepositorio;

namespace CapaNegocio
{
    public class IntegranteNego
    {
        IntegranteRepo integranteRepo = new IntegranteRepo();
        public void GuardarIntegrante(Integrante integrante)
        {
            integranteRepo.GuardarIntegrante(integrante);
        }

        public IEnumerable<Integrante> MostrarIntegrantes()
        {
            return integranteRepo.MostrarIntegrantes();
        }

        public void BorrarIntegrantesPorProyecto(int idProyecto)
        {
            integranteRepo.BorrarIntegrantesPorProyecto(idProyecto);
        }
    }
}
