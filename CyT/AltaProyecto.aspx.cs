using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaDominio;
using CapaNegocio;
using System.Data;

namespace CyT
{
    public partial class AltaProyecto : System.Web.UI.Page
    {
        ProyectoNego proyectoNego = new ProyectoNego();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;

            //Agregar Metodos
        }


        protected void btnGuardarProyecto_Click(object sender, EventArgs e)
        {
            GuardarProyecto();
        }

        private void GuardarProyecto(){

            Proyecto proyecto = new Proyecto();





            proyectoNego.GuardarProyecto(proyecto);
        }
    }
}