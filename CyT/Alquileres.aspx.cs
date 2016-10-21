using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CyT
{
    public partial class Alquileres : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            AlquileresWebService.MostrarAlquileres alq = new AlquileresWebService.MostrarAlquileres();


            dgvAlquiler.DataSource = alq.TodasLasPropiedades().ToList();
            dgvAlquiler.DataBind();



        }
    }
}