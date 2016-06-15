﻿using System;
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

            int idPersona=personaNego.GuardarPersona(persona);

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
            LimpiarPantalla();
            MostrarTelefono();
            MostrarCorreoElectronico();
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
            dgvTelefonoModal.HeaderRow.Cells[0].Text = "Telefono";

            dgvTelefonoFormulario.DataSource = listaTelefonosModal;
            dgvTelefonoFormulario.DataBind();
            //dgvTelefonoFormulario.HeaderRow.Cells[0].Text = "Telefonooooooooo";
        }

        private void MostrarCorreoElectronico()
        {
            dgvCorreoModal.DataSource = listaCorreosModal;
            dgvCorreoModal.DataBind();
            dgvCorreoModal.HeaderRow.Cells[0].Text = "Correo Electronico";

            dgvCorreoFormulario.DataSource = listaCorreosModal;
            dgvCorreoFormulario.DataBind();
        }

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
            listaCorreoElectronicos.Clear();
            listaTelefonos.Clear();
        }

        protected void btnEliminarTelefonoModal_Click(object sender, EventArgs e)
        {

        }

        protected void dgvTelefonoFormulario_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }

        protected void btnEliminarCorreoModal_Click(object sender, EventArgs e)
        {

        }
    }
}