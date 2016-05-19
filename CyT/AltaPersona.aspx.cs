using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaDominio;
using CapaNegocio;

namespace CyT
{
    public partial class AltaPersona : System.Web.UI.Page
    {
        PersonaNego personaNego = new PersonaNego();
        protected void Page_Load(object sender, EventArgs e)
        {
            {
                if (IsPostBack) return;

                //MostrarListas(); //SIRVE PARA EL DROP DOWN LIST
                MostrarPersona(); //SIRVE PARA LA GRILLA
            }
        }

        //Los muestro en la GRILLA
        private void MostrarPersona()
        {
            dgvPersona.DataSource = personaNego.MostrarPersona().ToList();
            dgvPersona.DataBind();
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarPersona();
        }

        private void GuardarPersona()
        {

            Persona persona = new Persona();

            persona.Nombre = txtNombre.Text;
            persona.Apellido = txtApellido.Text;

            personaNego.GuardarPersona(persona);

            MostrarPersona();
        } 






    }
}