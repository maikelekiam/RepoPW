using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDominio;


namespace CapaRepositorio
{
    public class UsuarioRepo
    {
        public Usuario ObtenerUsuario(String nombreUsuario,String password)
        {
            using (ModeloDeDominio modeloDeDominio=new ModeloDeDominio())
            {
                return modeloDeDominio.Usuarios.Where(c => c.Usuario1 == nombreUsuario && c.Password == password).FirstOrDefault();

            }
        }
    }
}
