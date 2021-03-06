﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
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
        LocalidadNego localidadNego = new LocalidadNego();
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
            btnActualizarPersona.Visible = false;
            btnGuardarPersona.Visible = true;

            dgvPersona.DataSource = personaNego.MostrarPersona().ToList();
            dgvPersona.DataBind();

            dgvPersona.Columns[0].Visible = false;
            dgvPersona.Columns[5].Visible = false;
            dgvPersona.Columns[6].Visible = false;
            dgvPersona.Columns[7].Visible = false;
            dgvPersona.Columns[8].Visible = false;
            dgvPersona.Columns[9].Visible = false;
            dgvPersona.Columns[10].Visible = false;
            dgvPersona.Columns[11].Visible = false;
            dgvPersona.Columns[12].Visible = false;
        }

        protected void btnGuardarPersona_Click(object sender, EventArgs e)
        {
            GuardarPersona();
        }

        //Muestra en el DROPDOWNLIST las LOCALIDADES
        private void MostrarLocalidad()
        {
            ddlLocalidad.DataSource = localidadNego.MostrarLocalidades().ToList();
            ddlLocalidad.DataValueField = "IdLocalidad";
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
            persona.IdLocalidad = Convert.ToInt32(ddlLocalidad.SelectedValue.ToString());
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

            Response.Redirect("AltaPersona.aspx");
            LimpiarPantalla();
            MostrarTelefono();
            MostrarCorreoElectronico();
            MostrarPersona();
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
            //listaTelefonosModal.Add(txtTelefonoModal.Text);
            txtTelefonoModal.Text = null;
            MostrarTelefono();
        }

        protected void btnModalCorreoGuardar_Click(object sender, EventArgs e)
        {
            //listaCorreosModal.Add(txtCorreoModal.Text);
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

            for (int i = 0; i < listaCorreosModal.Count; i++)
            {
                if (i == index)
                {
                    listaCorreosModal.RemoveAt(i);
                }
            }
            MostrarCorreoElectronico();
        }

        private void TraerListaTelefonos(int id)
        {
            listaTelefonosModal.Clear();
            listaTelefonos = telefonoNego.TraerListaTelefonos(id);

            foreach (Telefono tel in listaTelefonos)
            {
                string str = tel.Telefono1.ToString();
                listaTelefonosModal.Add(str);
            }
        }
        private void TraerListaCorreoElectronicos(int id)
        {
            listaCorreosModal.Clear();
            listaCorreoElectronicos = correoElectronicoNego.TraerListaCorreoElectronicos(id);

            foreach (CorreoElectronico corr in listaCorreoElectronicos)
            {
                string str = corr.CorreoElectronico1.ToString();
                listaCorreosModal.Add(str);
            }
        }

        private string TraerLocalidadSegunIdPersona(int id)
        {
            return localidadNego.TraerLocalidadSegunIdPersona(id);
        }

        protected void btnActualizarPersona_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona();

            int idPersona = Convert.ToInt32(dgvPersona.SelectedRow.Cells[0].Text);

            persona.Nombre = txtNombre.Text;
            persona.Apellido = txtApellido.Text;
            persona.TipoDocumento = ddlTipoDocumento.SelectedValue.ToString();
            persona.Documento = txtDocumento.Text;
            persona.FechaNacimiento = Convert.ToDateTime(txtFechaNacimiento.Text);
            persona.Cuil = txtCuil.Text;
            persona.Direccion = txtDireccion.Text;
            persona.IdLocalidad = Convert.ToInt32(ddlLocalidad.SelectedValue.ToString());
            persona.Empresa = txtEmpresa.Text;
            persona.IsBeneficiario = chkIsBeneficiario.Checked;
            persona.IsInteresado = chkIsInteresado.Checked;
            persona.Activo = true;
            persona.IdPersona = idPersona;

            personaNego.ActualizarPersona(persona);

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

            ActualizarTelefono(idPersona, listaTelefonos);
            ActualizarCorreoElectronico(idPersona, listaCorreoElectronicos);

            Response.Redirect("AltaPersona.aspx");
            LimpiarPantalla();
            MostrarTelefono();
            MostrarCorreoElectronico();
            MostrarPersona();
        }

        private void ActualizarTelefono(int id, IList<Telefono> listaTelefonos)
        {
            telefonoNego.ActualizarTelefono(id, listaTelefonos);
        }
        private void ActualizarCorreoElectronico(int id, IList<CorreoElectronico> listaCorreoElectronicos)
        {
            correoElectronicoNego.ActualizarCorreoElectronico(id, listaCorreoElectronicos);
        }


        protected void dgvPersona_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            idPersonaActual = Convert.ToInt32(dgvPersona.Rows[e.RowIndex].Cells[0].Text);

            EliminarPersona(idPersonaActual);

            Response.Redirect("AltaPersona.aspx");
            LimpiarPantalla();
            MostrarTelefono();
            MostrarCorreoElectronico();
            MostrarPersona();
        }

        private void EliminarPersona(int id)
        {
            if (Login.nivel == 1)
            {
                personaNego.EliminarPersona(id);
            }
            else
            {
            }
        }

        protected void dgvPersona_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            idPersonaActual = Convert.ToInt32(dgvPersona.Rows[e.NewSelectedIndex].Cells[0].Text);

            txtNombre.Text = dgvPersona.Rows[e.NewSelectedIndex].Cells[1].Text.Replace("&nbsp;", "");
            txtApellido.Text = dgvPersona.Rows[e.NewSelectedIndex].Cells[2].Text.Replace("&nbsp;", "");
            ddlTipoDocumento.Text = dgvPersona.Rows[e.NewSelectedIndex].Cells[3].Text.Replace("&nbsp;", "");
            txtDocumento.Text = dgvPersona.Rows[e.NewSelectedIndex].Cells[4].Text.Replace("&nbsp;", "");
            txtCuil.Text = dgvPersona.Rows[e.NewSelectedIndex].Cells[11].Text.Replace("&nbsp;", "");
            txtFechaNacimiento.Text = dgvPersona.Rows[e.NewSelectedIndex].Cells[8].Text;
            txtDireccion.Text = dgvPersona.Rows[e.NewSelectedIndex].Cells[10].Text.Replace("&nbsp;", "");
            txtEmpresa.Text = dgvPersona.Rows[e.NewSelectedIndex].Cells[9].Text.Replace("&nbsp;", "");
            txtEmpresa.Text = dgvPersona.Rows[e.NewSelectedIndex].Cells[9].Text.Replace("&nbsp;", "");

            if (dgvPersona.Rows[e.NewSelectedIndex].Cells[6].Text == "True") { chkIsInteresado.Checked = true; }
            else { chkIsInteresado.Checked = false; }

            if (dgvPersona.Rows[e.NewSelectedIndex].Cells[7].Text == "True") { chkIsBeneficiario.Checked = true; }
            else { chkIsBeneficiario.Checked = false; }

            TraerListaTelefonos(idPersonaActual);
            MostrarTelefono();

            TraerListaCorreoElectronicos(idPersonaActual);
            MostrarCorreoElectronico();

            //ddlLocalidad.SelectedValue = TraerLocalidadSegunIdPersona(Convert.ToInt32(dgvPersona.Rows[e.NewSelectedIndex].Cells[5].Text));
            ddlLocalidad.SelectedValue = dgvPersona.Rows[e.NewSelectedIndex].Cells[5].Text;

            btnGuardarPersona.Visible = false;
            btnActualizarPersona.Visible = true;
        }

        [WebMethod]
        public static string AgregarTelefono(string tel)
        {
            listaTelefonosModal.Add(tel);

            return tel;
        }

        [WebMethod]
        public static string AgregarCorreoElectronico(string corr)
        {
            listaCorreosModal.Add(corr);

            return corr;
        }
    }
}