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

                MostrarLocalidad(); //SIRVE PARA EL DROP DOWN LIST
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

        //Muestro en el DROPDOWNLIST las LOCALIDADES
        private void MostrarLocalidad()
        {
            ddlLocalidad.DataSource = personaNego.MostrarLocalidad().ToList();
            ddlLocalidad.DataValueField = "nombre";
            ddlLocalidad.DataBind();
        }

        private void GuardarPersona()
        {

            Persona persona = new Persona();

            persona.Nombre = txtNombre.Text;
            persona.Apellido = txtApellido.Text;
            persona.TipoDocumento = ddlTipoDocumento.SelectedValue.ToString();
            persona.Documento = txtDocumento.Text;
            persona.FechaNacimiento = Convert.ToDateTime(txtFechaNacimiento.Text);
            persona.Cuil = txtCuil.Text;
            persona.Direccion = txtDireccion.Text;
            persona.IdLocalidad = Convert.ToInt32(ddlLocalidad.SelectedIndex.ToString());






            personaNego.GuardarPersona(persona);

            MostrarPersona();
        }






    }
}