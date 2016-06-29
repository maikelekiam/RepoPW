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
    public partial class MostrarBeneficiario : System.Web.UI.Page
    {
        PersonaNego personaNego = new PersonaNego();
        LocalidadNego localidadNego = new LocalidadNego();
        TelefonoNego telefonoNego = new TelefonoNego();
        CorreoElectronicoNego correoElectronicoNego = new CorreoElectronicoNego();
        List<string> listaTelefonosString=new List<string>();
        List<string> listaCorreosString = new List<string>();



        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;

            MostrarBeneficiarioSeleccionado();

        }

        private void MostrarBeneficiarioSeleccionado()
        {
            Persona persona = new Persona();

            persona = personaNego.ObtenerPersona(ListarBeneficiarios.idPersonaSeleccionada);

            listaTelefonosString.Clear();


            txtNombre.Text = persona.Nombre;
            txtApellido.Text = persona.Apellido;
            txtTipoDocumento.Text = persona.TipoDocumento;
            txtDocumento.Text = persona.Documento;
            txtCuil.Text = persona.Cuil;
            txtFechaNacimiento.Text = Convert.ToString(persona.FechaNacimiento);
            txtDireccion.Text = persona.Direccion;
            txtLocalidad.Text = localidadNego.TraerLocalidadSegunIdPersona(ListarBeneficiarios.idPersonaSeleccionada);
            txtEmpresa.Text = persona.Empresa;

            List<Telefono> listaTelefonos = telefonoNego.TraerListaTelefonos(ListarBeneficiarios.idPersonaSeleccionada);
            foreach (Telefono tel in listaTelefonos)
            {
                string str = tel.Telefono1.ToString();
                listaTelefonosString.Add(str);
            }
            dgvTelefonoModal.DataSource = listaTelefonosString;
            dgvTelefonoModal.DataBind();

            List<CorreoElectronico> listaCorreos = correoElectronicoNego.TraerListaCorreoElectronicos(ListarBeneficiarios.idPersonaSeleccionada);
            foreach (CorreoElectronico corr in listaCorreos)
            {
                string str = corr.CorreoElectronico1.ToString();
                listaCorreosString.Add(str);
            }
            dgvCorreoModal.DataSource = listaCorreosString;
            dgvCorreoModal.DataBind();


        }



    }
}