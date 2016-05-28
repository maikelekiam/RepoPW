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
    public partial class AltaPersona : System.Web.UI.Page
    {
        PersonaNego personaNego = new PersonaNego();
        static List<string> listaTelefonosModal = new List<string>();
        static List<string> listaCorreosModal = new List<string>();

        protected void Page_Load(object sender, EventArgs e)
        {
            {
                if (IsPostBack) return;

                MostrarLocalidad(); //SIRVE PARA EL DROP DOWN LIST
                MostrarPersona(); //SIRVE PARA LA GRILLA
                listaTelefonosModal.Clear();
                listaCorreosModal.Clear();
                
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
            persona.Empresa = txtEmpresa.Text;
            persona.IsBeneficiario = chkIsBeneficiario.Checked;
            persona.IsInteresado = chkIsInteresado.Checked;

            
            //FALTA AGREGAR TELEFONOS Y CORREOS


            personaNego.GuardarPersona(persona);
            MostrarPersona();
        }

        private void MostrarTelefono()
        {
            dgvTelefonoModal.DataSource = listaTelefonosModal;
            dgvTelefonoModal.DataBind();
            dgvTelefonoModal2.DataSource = listaTelefonosModal;
            dgvTelefonoModal2.DataBind();
        }

        private void MostrarCorreoElectronico()
        {
            dgvCorreoModal.DataSource = listaCorreosModal;
            dgvCorreoModal.DataBind();
            dgvCorreoModal2.DataSource = listaCorreosModal;
            dgvCorreoModal2.DataBind();
        }
        protected void dgvTelefonoModal2_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.Header)
            {
                e.Row.Cells[0].Text = "Lista de Telefonos:";
            }
        }

        protected void dgvCorreoModal2_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.Header)
            {
                e.Row.Cells[0].Text = "Lista de Correos:";
            }
        }
        
        protected void btnModalTelefonoGuardar_Click(object sender, EventArgs e)
        {
            listaTelefonosModal.Add(txtTelefonoModal.Text);
            txtTelefonoModal.Text = null;
            MostrarTelefono();
        }
        protected void btnModalCorreoGuardar_Click(object sender, EventArgs e)
        {
            listaCorreosModal.Add(txtCorreoModal.Text);
            txtCorreoModal.Text = null;
            MostrarCorreoElectronico();
        }
    }
}