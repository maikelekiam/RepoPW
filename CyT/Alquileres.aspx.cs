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

            //AlquileresWebService.MostrarAlquileres alq = new AlquileresWebService.MostrarAlquileres();
            //localhost.ConvocatoriasAbiertas otro = new localhost.ConvocatoriasAbiertas();

            //dgvAlquiler.DataSource = alq.TodasLasPropiedades().ToList();

            //dgvAlquiler.DataSource = otro.MostrarConvocatoriasAbiertas().ToList();
            
            //dgvAlquiler.DataBind();

            web_reference_01.ConvocatoriasAbiertas otrotro = new web_reference_01.ConvocatoriasAbiertas();

            //dgvAlquiler.DataSource = otrotro.MostrarConvocatoriasAbiertas().ToList();

            String moda;
            moda = "publica";


            dgvAlquiler.DataSource = otrotro.MostrarConvocatoriasPorModalidad(moda).ToList();


            dgvAlquiler.DataBind();


            

            
        }
    }
}