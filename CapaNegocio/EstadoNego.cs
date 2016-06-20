using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDominio;
using CapaRepositorio;
namespace CapaNegocio
{
    public class EstadoNego
    {
        EstadoRepo estadoRepo = new EstadoRepo();

        public IEnumerable<Estado> MostrarEstado()
        {
            return estadoRepo.MostrarEstado();
        }

        public string TraerEstado(int id)
        {
            return estadoRepo.TraerEstado(id);
        }

        public void GuardarEstado(Estado estado)
        {
            estadoRepo.GuardarEstado(estado);
        }
    }
}
