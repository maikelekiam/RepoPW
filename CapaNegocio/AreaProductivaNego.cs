using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDominio;
using CapaRepositorio;
namespace CapaNegocio
{
    public class AreaProductivaNego
    {
        AreaProductivaRepo areaProductivaRepo = new AreaProductivaRepo();

        public IEnumerable<AreaProductiva> MostrarAreaProductiva()
        {
            return areaProductivaRepo.MostrarAreaProductiva();
        }

        public string TraerAreaProductiva(int id)
        {
            return areaProductivaRepo.TraerAreaProductiva(id);
        }

        public void GuardarAreaProductiva(AreaProductiva areaProductiva)
        {
            areaProductivaRepo.GuardarAreaProductiva(areaProductiva);
        }
    }
}
