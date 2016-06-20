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
        static int idActuacionActual;
        static int idPersonaActual;

        protected void Page_Load(object sender, EventArgs e)
        {
            {
                if (IsPostBack) return;

                MostrarViaComunicacion(); //SIRVE PARA CARGAR DATOS EN EL DROPDOWNLIST
                MostrarTematica(); //SIRVE PARA CARGAR DATOS EN EL DROPDOWNLIST
                MostrarPersona(); //SIRVE PARA CARGAR DATOS EN LA GRILLA
                //LimpiarPantalla();
                btnGuardarActuacion.Visible = false;
                btnActualizarActuacion.Visible = false;
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
        protected void btnGuardarActuacion_Click(object sender, EventArgs e)
        {
            GuardarActuacion();
        }
        private void GuardarActuacion()
        {
            Actuacion actuacion = new Actuacion();

            actuacion.IdPersona = idPersonaActual;
            actuacion.IdTematica = Convert.ToInt32(ddlTematica.SelectedIndex.ToString());
            actuacion.IdViaComunicacion = Convert.ToInt32(ddlViaComunicacion.SelectedIndex.ToString());
            actuacion.Fecha = Convert.ToDateTime(txtFechaActuacion.Text);
            actuacion.Detalle = txtDetalle.Text;
            actuacion.Activo = true;

            idActuacionActual = actuacionNego.GuardarActuacion(actuacion);

            MostrarActuacionSegunPersona(idPersonaActual);
            //LimpiarPantalla();

            btnGuardarActuacion.Visible = false;
            btnActualizarActuacion.Visible = false;
        }


        private void MostrarActuacionSegunPersona(int id)
        {
            dgvActuacion.Columns[0].Visible = true;
            dgvActuacion.Columns[3].Visible = true;
            dgvActuacion.Columns[4].Visible = true;
            dgvActuacion.Columns[5].Visible = true;
            dgvActuacion.Columns[6].Visible = true;
            dgvActuacion.DataSource = actuacionNego.MostrarActuacionSegunPersona(id);
            dgvActuacion.DataBind();
            dgvActuacion.Columns[0].Visible = false;
            dgvActuacion.Columns[3].Visible = false;
            dgvActuacion.Columns[4].Visible = false;
            dgvActuacion.Columns[5].Visible = false;
            dgvActuacion.Columns[6].Visible = false;

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

        protected void dgvActuacion_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            btnGuardarActuacion.Visible = false;
            btnActualizarActuacion.Visible = false;
            
            idActuacionActual = Convert.ToInt32(dgvActuacion.Rows[e.RowIndex].Cells[0].Text);

            EliminarActuacion(idActuacionActual);

            LimpiarPantalla();

            MostrarActuacionSegunPersona(idPersonaActual);
        }

        private void EliminarActuacion(int id)
        {
            actuacionNego.EliminarActuacion(id);
        }

        private string TraerViaComunicacion(int id)
        {
            return viaComunicacionNego.TraerViaComunicacion(id);
        }

        private string TraerTematica(int id)
        {
            return tematicaNego.TraerTematica(id);
        }

        protected void dgvPersona_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnGuardarActuacion.Visible = true;
            btnActualizarActuacion.Visible = false;

            GridViewRow row = dgvPersona.SelectedRow;

            idPersonaActual = Convert.ToInt32(row.Cells[1].Text);

            lblPersonaSeleccionadaDeLaGrilla.Text = row.Cells[2].Text + " " + row.Cells[3].Text;

            LimpiarPantalla();

            MostrarActuacionSegunPersona(idPersonaActual);
        }

        protected void dgvActuacion_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            btnGuardarActuacion.Visible = false;
            btnActualizarActuacion.Visible = true;
            
            GridViewRow row = dgvActuacion.Rows[e.NewSelectedIndex];

            idActuacionActual = Convert.ToInt32(row.Cells[0].Text);

            txtFechaActuacion.Text = row.Cells[1].Text;
            ddlViaComunicacion.Text = TraerViaComunicacion(Convert.ToInt32(row.Cells[3].Text));
            ddlTematica.Text = TraerTematica(Convert.ToInt32(row.Cells[4].Text));
            txtDetalle.Text = row.Cells[2].Text;
        }

        protected void btnActualizarActuacion_Click(object sender, EventArgs e)
        {
            ActualizarActuacion();

        }

        private void ActualizarActuacion()
        {
            Actuacion actuacion = new Actuacion();

            actuacion.IdPersona = idPersonaActual;
            actuacion.IdTematica = Convert.ToInt32(ddlTematica.SelectedIndex.ToString());
            actuacion.IdViaComunicacion = Convert.ToInt32(ddlViaComunicacion.SelectedIndex.ToString());
            actuacion.Fecha = Convert.ToDateTime(txtFechaActuacion.Text);
            actuacion.Detalle = txtDetalle.Text;
            actuacion.Activo = true;

            actuacion.IdActuacion = idActuacionActual;

            actuacionNego.ActualizarActuacion(actuacion);

            LimpiarPantalla();

            MostrarActuacionSegunPersona(idPersonaActual);

            btnActualizarActuacion.Visible = false;
        }
    }
}