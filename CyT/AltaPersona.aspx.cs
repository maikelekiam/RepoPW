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
        TelefonoNego telefonoNego = new TelefonoNego();
        CorreoElectronicoNego correoElectronicoNego = new CorreoElectronicoNego();
        int idPersonaActual;

        static List<string> listaTelefonosModal = new List<string>();
        static List<string> listaCorreosModal = new List<string>();
        IList<Telefono> listaTelefonos = new List<Telefono>();
        IList<CorreoElectronico> listaCorreoElectronicos = new List<CorreoElectronico>();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;

            MostrarLocalidad(); //SIRVE PARA EL DROP DOWN LIST
            MostrarPersona(); //SIRVE PARA LA GRILLA
            LimpiarPantalla();
            listaTelefonosModal.Clear();
            listaCorreosModal.Clear();
            listaCorreoElectronicos.Clear();
            listaTelefonos.Clear();
        }

        //Muestra los datos de las personas en la GRILLA
        private void MostrarPersona()
        {
            dgvPersona.DataSource = personaNego.MostrarPersona().ToList();
            dgvPersona.DataBind();
            dgvPersona.Columns[0].Visible = false;
        }

        protected void btnGuardarPersona_Click(object sender, EventArgs e)
        {
            GuardarPersona();
        }


        //Muestra en el DROPDOWNLIST las LOCALIDADES
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
            persona.Activo = true;

            int idPersona = personaNego.GuardarPersona(persona);

            foreach (String str in listaTelefonosModal)
            {
                Telefono tel = new Telefono();
                tel.Telefono1 = str;
                tel.Activo = true;
                tel.IdPersona = idPersona;
                listaTelefonos.Add(tel);
            }

            foreach (String str in listaCorreosModal)
            {
                CorreoElectronico correoe = new CorreoElectronico();
                correoe.CorreoElectronico1 = str;
                correoe.Activo = true;
                correoe.IdPersona = idPersona;
                listaCorreoElectronicos.Add(correoe);
            }

            GuardarTelefono(listaTelefonos);
            GuardarCorreoElectronico(listaCorreoElectronicos);

            MostrarPersona();
            Response.Redirect("AltaPersona.aspx");

            //LimpiarPantalla();
            //MostrarTelefono();
            //MostrarCorreoElectronico();
        }

        private void GuardarTelefono(IList<Telefono> listaTelefonos)
        {
            telefonoNego.GuardarTelefono(listaTelefonos);
        }

        private void GuardarCorreoElectronico(IList<CorreoElectronico> listaCorreoElectronicos)
        {
            correoElectronicoNego.GuardarCorreoElectronico(listaCorreoElectronicos);
        }

        //Muestra los telefonos tanto en el MODAL como asi tambien en la GRILLA del formulario
        private void MostrarTelefono()
        {
            dgvTelefonoModal.DataSource = listaTelefonosModal;
            dgvTelefonoModal.DataBind();

            dgvTelefonoFormulario.DataSource = listaTelefonosModal;
            dgvTelefonoFormulario.DataBind();
        }

        private void MostrarCorreoElectronico()
        {
            dgvCorreoModal.DataSource = listaCorreosModal;
            dgvCorreoModal.DataBind();

            dgvCorreoFormulario.DataSource = listaCorreosModal;
            dgvCorreoFormulario.DataBind();
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

        private void LimpiarPantalla()
        {
            txtNombre.Text = null;
            txtApellido.Text = null;
            ddlTipoDocumento.SelectedIndex = 0;
            txtDocumento.Text = null;
            txtFechaNacimiento.Text = null;
            txtCuil.Text = null;
            txtDireccion.Text = null;
            ddlLocalidad.SelectedIndex = 0;
            txtEmpresa.Text = null;
            chkIsBeneficiario.Checked = false;
            chkIsInteresado.Checked = false;
            listaTelefonosModal.Clear();
            listaCorreosModal.Clear();
            listaCorreoElectronicos.Clear();
            listaTelefonos.Clear();
        }
        
        protected void dgvTelefonoFormulario_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int index = Convert.ToInt32(e.RowIndex);

            for (int i = 0; i < listaTelefonosModal.Count; i++)
            {
                if (i == index)
                {
                    listaTelefonosModal.RemoveAt(i);
                }
            }

            MostrarTelefono();
        }

        protected void btnEliminarCorreoModal_Command(object sender, CommandEventArgs e)
        {
            int index = Convert.ToInt32(e.CommandArgument.ToString());
            txtApellido.Text = e.CommandArgument.ToString();

            for (int i = 0; i < listaCorreosModal.Count; i++)
            {
                if (i == index)
                {
                    listaCorreosModal.RemoveAt(i);
                }
            }

            MostrarCorreoElectronico();

        }
        protected void dgvPersona_SelectedIndexChanged(object sender, EventArgs e)
        {
            idPersonaActual = Convert.ToInt32(dgvPersona.SelectedRow.Cells[0].Text);
            txtApellido.Text = dgvPersona.SelectedRow.Cells[0].Text;
        }
    }
}