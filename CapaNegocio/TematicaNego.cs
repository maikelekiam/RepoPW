using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDominio;
using CapaRepositorio;

namespace CapaNegocio
{
    public class TematicaNego
    {
        TematicaRepo tematicaRepo = new TematicaRepo();

        public IEnumerable<Tematica> MostrarTematica()
        {
            return tematicaRepo.MostrarTematica();
        }

        public string TraerTematica(int id)
        {
            return tematicaRepo.TraerTematica(id);
        }

        public int GuardarTematica(Tematica tematica)
        {
            return tematicaRepo.GuardarTematica(tematica);
        }
        public int TraerTematicaIdSegunItem(string item)
        {
            return tematicaRepo.TraerTematicaIdSegunItem(item);
        }

    }
}
