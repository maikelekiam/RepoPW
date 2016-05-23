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
                MostrarPersona(); //SIRVE PARA LA GRILLA
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
        private void MostrarPersona()
        {
            dgvPersona.DataSource = actuacionNego.MostrarPersona().ToList();
            dgvPersona.DataBind();
        }
        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarActuacion();
        }
        private void GuardarActuacion()
        {

            Actuacion actuacion = new Actuacion();

            actuacion.IdPersona = Convert.ToInt32(dgvPersona.SelectedRow.Cells[1].Text);
            actuacion.IdTematica = Convert.ToInt32(ddlTematica.SelectedIndex.ToString());
            actuacion.IdViaComunicacion = Convert.ToInt32(ddlViaComunicacion.SelectedIndex.ToString());
            actuacion.Fecha = Convert.ToDateTime(txtFechaActuacion.Text);
            actuacion.Detalle = txtDetalle.Text;

            actuacionNego.GuardarActuacion(actuacion);



        }

        protected void dgvPersona_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblPersonaSeleccionada.Text = dgvPersona.SelectedRow.Cells[2].Text + " " + dgvPersona.SelectedRow.Cells[3].Text;
            lblIdSeleccionado.Text = dgvPersona.SelectedRow.Cells[1].Text;
            MostrarActuacionSegunPersona();
        }

        protected void dgvActuacion_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void MostrarActuacionSegunPersona()
        {
            dgvActuacion.DataSource = actuacionNego.MostrarActuacionSegunPersona(Convert.ToInt32(dgvPersona.SelectedRow.Cells[1].Text)).ToList();
            dgvActuacion.DataBind();
        }
    }
}