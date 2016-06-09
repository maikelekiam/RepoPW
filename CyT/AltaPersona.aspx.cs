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
        IList<Telefono> listaTelefonos = new List<Telefono>();
        IList<CorreoElectronico> listaCorreoElectronicos = new List<CorreoElectronico>();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;

            MostrarLocalidad(); //SIRVE PARA EL DROP DOWN LIST
            MostrarPersona(); //SIRVE PARA LA GRILLA
            LimpiarPantalla();
            //listaTelefonosModal.Clear();
            listaCorreosModal.Clear();
        }

        //Los muestro en la GRILLA
        private void MostrarPersona()
        {
            dgvPersona.DataSource = personaNego.MostrarPersona().ToList();
            dgvPersona.DataBind();
        }

        protected void btnGuardarPersona_Click(object sender, EventArgs e)
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
            persona.Activo = true;

            foreach (GridViewRow row in dgvTelefonoFormulario.Rows)
            {
                Telefono tel = new Telefono();
                tel.Telefono1 = row.Cells[0].Text;
                tel.Activo = true;
                listaTelefonos.Add(tel);
            }

            foreach (GridViewRow row in dgvCorreoFormulario.Rows)
            {
                CorreoElectronico correoe = new CorreoElectronico();
                correoe.CorreoElectronico1 = row.Cells[0].Text;
                correoe.Activo = true;
                listaCorreoElectronicos.Add(correoe);
            }
            
            personaNego.GuardarPersona(persona, listaTelefonos, listaCorreoElectronicos);
            //Int32 idTemporal = personaNego.MostrarUltimoIdPersona();
            //personaNego.GuardarTelefonos(listaTelefonosModal, idTemporal);
            MostrarPersona();
            LimpiarPantalla();
        }

        private void MostrarTelefono()
        {
            dgvTelefonoModal.DataSource = listaTelefonosModal;
            dgvTelefonoModal.DataBind();
            dgvTelefonoModal.HeaderRow.Cells[0].Text = "Telefono";
            dgvTelefonoFormulario.DataSource = listaTelefonosModal;
            dgvTelefonoFormulario.DataBind();
            //dgvTelefonoFormulario.HeaderRow.Cells[0].Text = "Telefono";
        }

        private void MostrarCorreoElectronico()
        {
            dgvCorreoModal.DataSource = listaCorreosModal;
            dgvCorreoModal.DataBind();
            dgvCorreoFormulario.DataSource = listaCorreosModal;
            dgvCorreoFormulario.DataBind();
        }
        //protected void dgvTelefonoFormulario_RowDataBound(object sender, GridViewRowEventArgs e)
        //{
        //    if (e.Row.RowType == DataControlRowType.Header)
        //    {
        //        e.Row.Cells[0].Text = "Lista de Telefonos:";
        //    }
        //}

        protected void dgvCorreoFormulario_RowDataBound(object sender, GridViewRowEventArgs e)
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
        }
    }
}