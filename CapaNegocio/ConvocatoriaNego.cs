using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDominio;
using CapaRepositorio;

namespace CapaNegocio
{
    public class ConvocatoriaNego
    {
        ConvocatoriaRepo convocatoriaRepo = new ConvocatoriaRepo();
        public void GuardarConvocatoria(Convocatorium convocatoria)
        {
            convocatoriaRepo.GuardarConvocatoria(convocatoria);
        }

        public IEnumerable<Convocatorium> MostrarConvocatorias()
        {
            return convocatoriaRepo.MostrarConvocatorias();
        }

        public void ActualizarConvocatoria(Convocatorium convocatoria)
        {
            convocatoriaRepo.ActualizarConvocatoria(convocatoria);
        }

        public Convocatorium ObtenerConvocatoria(int id)
        {
            return convocatoriaRepo.ObtenerConvocatoria(id);
        }
    }
}
