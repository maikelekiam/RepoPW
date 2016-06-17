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
        PersonaNego personaNego = new PersonaNego();
        TematicaNego tematicaNego = new TematicaNego();
        ViaComunicacionNego viaComunicacionNego = new ViaComunicacionNego();

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
            ddlViaComunicacion.DataSource = viaComunicacionNego.MostrarViaComunicacion().ToList();
            ddlViaComunicacion.DataValueField = "nombre";
            ddlViaComunicacion.DataBind();
        }

        //Muestro en el DROPDOWNLIST las TEMATICAS
        private void MostrarTematica()
        {
            ddlTematica.DataSource = tematicaNego.MostrarTematica().ToList();
            ddlTematica.DataValueField = "nombre";
            ddlTematica.DataBind();
        }
        private void MostrarPersona() //SIRVE PARA CARGAR DATOS EN LA GRILLA
        {
            dgvPersona.DataSource = personaNego.MostrarPersona().ToList();
            dgvPersona.DataBind();
            dgvPersona.Columns[2].Visible = false;
            dgvPersona.Columns[3].Visible = false;
            dgvPersona.Columns[4].Visible = false;
            dgvPersona.Columns[5].Visible = false;
            dgvPersona.Columns[6].Visible = false;
            dgvPersona.Columns[7].Visible = false;
            dgvPersona.Columns[9].Visible = false;
            dgvPersona.Columns[10].Visible = false;
            dgvPersona.Columns[12].Visible = false;
        }
        protected void btnGuardarActuacion_Click(object sender, EventArgs e)
        {
            GuardarActuacion();
        }
        private void GuardarActuacion()
        {
            Actuacion actuacion = new Actuacion();

            actuacion.IdPersona = Convert.ToInt32(dgvPersona.SelectedRow.Cells[5].Text);
            actuacion.IdTematica = Convert.ToInt32(ddlTematica.SelectedIndex.ToString());
            actuacion.IdViaComunicacion = Convert.ToInt32(ddlViaComunicacion.SelectedIndex.ToString());
            actuacion.Fecha = Convert.ToDateTime(txtFechaActuacion.Text);
            actuacion.Detalle = txtDetalle.Text;
            actuacion.Activo = true;

            actuacionNego.GuardarActuacion(actuacion);

            MostrarActuacionSegunPersona(Convert.ToInt32(dgvPersona.SelectedRow.Cells[5].Text));
            LimpiarPantalla();
        }

        protected void dgvPersona_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblPersonaSeleccionadaDeLaGrilla.Text = dgvPersona.SelectedRow.Cells[1].Text + " " + dgvPersona.SelectedRow.Cells[2].Text +
                ", " + dgvPersona.SelectedRow.Cells[3].Text + ": " + dgvPersona.SelectedRow.Cells[4].Text;
            int index = Convert.ToInt32(dgvPersona.SelectedRow.Cells[5].Text);
            MostrarActuacionSegunPersona(index);
        }

        protected void dgvActuacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            //agregar qué hacer cuando se selecciona una actuacion (editar, etc...)

        }

        private void MostrarActuacionSegunPersona(int id)
        {
            dgvActuacion.DataSource = actuacionNego.MostrarActuacionSegunPersona(id);
            dgvActuacion.DataBind();
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