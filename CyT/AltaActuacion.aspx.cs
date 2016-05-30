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
    public partial class AltaActuacion : System.Web.UI.Page
    {
        ActuacionNego actuacionNego = new ActuacionNego();

        protected void Page_Load(object sender, EventArgs e)
        {
            {
                if (IsPostBack) return;

                MostrarViaComunicacion(); //SIRVE PARA CARGAR DATOS EN EL DROPDOWNLIST
                MostrarTematica(); //SIRVE PARA CARGAR DATOS EN EL DROPDOWNLIST
                MostrarPersona(); //SIRVE PARA CARGAR DATOS EN LA GRILLA
                LimpiarPantalla();
            }
        }

        //Muestro en el DROPDOWNLIST las VIAS DE COMUNICACION
        private void MostrarViaComunicacion()
        {
            ddlViaComunicacion.DataSource = actuacionNego.MostrarViaComunicacion().ToList();
            ddlViaComunicacion.DataValueField = "nombre";
            ddlViaComunicacion.DataBind();
        }

        //Muestro en el DROPDOWNLIST las TEMATICAS
        private void MostrarTematica()
        {
            ddlTematica.DataSource = actuacionNego.MostrarTematica().ToList();
            ddlTematica.DataValueField = "nombre";
            ddlTematica.DataBind();
        }
        private void MostrarPersona() //SIRVE PARA CARGAR DATOS EN LA GRILLA
        {
            dgvPersona.DataSource = actuacionNego.MostrarPersona().ToList();
            dgvPersona.DataBind();
        }
        protected void btnGuardarActuacion_Click(object sender, EventArgs e)
        {
            GuardarActuacion();
        }
        private void GuardarActuacion()
        {
            Actuacion actuacion = new Actuacion();

            actuacion.IdPersona = MostrarIdPersonaSegunDocumento();

            actuacion.IdTematica = Convert.ToInt32(ddlTematica.SelectedIndex.ToString());
            actuacion.IdViaComunicacion = Convert.ToInt32(ddlViaComunicacion.SelectedIndex.ToString());
            actuacion.Fecha = Convert.ToDateTime(txtFechaActuacion.Text);
            actuacion.Detalle = txtDetalle.Text;

            actuacionNego.GuardarActuacion(actuacion);

            MostrarActuacionSegunPersona();
            LimpiarPantalla();
        }

        protected void dgvPersona_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblPersonaSeleccionadaDeLaGrilla.Text = dgvPersona.SelectedRow.Cells[1].Text + " " + dgvPersona.SelectedRow.Cells[2].Text +
                ", " + dgvPersona.SelectedRow.Cells[3].Text + ": " + dgvPersona.SelectedRow.Cells[4].Text;
            MostrarActuacionSegunPersona();
        }

        protected void dgvActuacion_SelectedIndexChanged(object sender, EventArgs e)
        {

            //agregar qué hacer cuando se selecciona una actuacion (editar, etc...)
        }

        // busco en la tabla ACTUACION todas las actuaciones segun el DOCUMENTO ingresado
        private void MostrarActuacionSegunPersona()
        {
            dgvActuacion.DataSource = actuacionNego.MostrarActuacionSegunPersona(dgvPersona.SelectedRow.Cells[4].Text).ToList();
            dgvActuacion.DataBind();
        }


        // Busco en la table PERSONA el idPersona segun el DOCUMENTO ingresado
        private Int32 MostrarIdPersonaSegunDocumento()
        {
            return actuacionNego.MostrarIdPersonaSegunDocumento(dgvPersona.SelectedRow.Cells[4].Text);
        }

        private void LimpiarPantalla()
        {
            ddlTematica.SelectedIndex = 0;
            ddlViaComunicacion.SelectedIndex = 0;
            txtFechaActuacion.Text = null;
            txtDetalle.Text = null;
        }

        protected void btnModalViaComunicacionGuardar_Click(object sender, EventArgs e)
        {
            //AGREGAR FUNCIONALIDAD
        }
        protected void btnModalTematicaGuardar_Click(object sender, EventArgs e)
        {
            //AGREGAR FUNCIONALIDA
        }
    }
}