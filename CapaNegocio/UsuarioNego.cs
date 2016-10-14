using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDominio;
using CapaRepositorio;

namespace CapaNegocio
{
    public class UsuarioNego
    {
        UsuarioRepo usuarioRepo = new UsuarioRepo();

        public Usuario ObtenerUsuario(String nombreUsuario,String password)
        {
            return usuarioRepo.ObtenerUsuario(nombreUsuario,password);
        }
    }
}
