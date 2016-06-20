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
    public partial class AltaProyecto : System.Web.UI.Page
    {
        EstadoNego estadoNego = new EstadoNego();
        AreaProductivaNego areaProductivaNego = new AreaProductivaNego();
        UvtNego uvtNego = new UvtNego();
        ConvocatoriaNego convocatoriaNego = new ConvocatoriaNego();
        ProyectoNego proyectoNego = new ProyectoNego();
        static int idProyectoActual;



        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;
            
            MostrarEstado();
            MostrarAreaProductiva();
            MostrarUvt();
            MostrarConvocatoria();
            MostrarProyecto();

            btnActualizarProyecto.Visible = false;
        }

        private void MostrarEstado()
        {
            ddlEstado.DataSource = estadoNego.MostrarEstado();
            ddlEstado.DataValueField = "nombre";
            ddlEstado.DataBind();
        }

        private void MostrarAreaProductiva()
        {
            ddlAreaProductiva.DataSource = areaProductivaNego.MostrarAreaProductiva();
            ddlAreaProductiva.DataValueField = "nombre";
            ddlAreaProductiva.DataBind();
        }

        private void MostrarUvt()
        {
            ddlUvt.DataSource = uvtNego.MostrarUvt();
            ddlUvt.DataValueField = "nombreUvt";
            ddlUvt.DataBind();
        }

        private void MostrarConvocatoria()
        {
            ddlConvocatoria.DataSource = convocatoriaNego.MostrarConvocatorias();
            ddlConvocatoria.DataValueField = "nombre";
            ddlConvocatoria.DataBind();
        }

        //Muestra la lista de proyectos en una grilla
        private void MostrarProyecto()
        {
            btnActualizarProyecto.Visible = false;
            btnGuardarProyecto.Visible = true;

            dgvProyecto.Columns[0].Visible = true;
            dgvProyecto.Columns[2].Visible = true;
            dgvProyecto.Columns[3].Visible = true;
            dgvProyecto.Columns[4].Visible = true;
            dgvProyecto.Columns[5].Visible = true;
            dgvProyecto.Columns[7].Visible = true;
            dgvProyecto.Columns[8].Visible = true;
            dgvProyecto.Columns[9].Visible = true;
            
            dgvProyecto.DataSource = proyectoNego.MostrarProyecto().ToList();
            dgvProyecto.DataBind();

            dgvProyecto.Columns[0].Visible = false;
            dgvProyecto.Columns[2].Visible = false;
            dgvProyecto.Columns[3].Visible = false;
            dgvProyecto.Columns[4].Visible = false;
            dgvProyecto.Columns[5].Visible = false;
            dgvProyecto.Columns[7].Visible = false;
            dgvProyecto.Columns[8].Visible = false;
            dgvProyecto.Columns[9].Visible = false;
        }

        protected void btnGuardarProyecto_Click(object sender, EventArgs e)
        {
            GuardarProyecto();
        }

        private void GuardarProyecto(){

            Proyecto proyecto = new Proyecto();

            proyecto.Nombre = txtNombre.Text;
            proyecto.NumeroExp = txtNumeroExp.Text;
            proyecto.IdConvocatoria = Convert.ToInt32(ddlConvocatoria.SelectedIndex.ToString());
            proyecto.IdUvt = Convert.ToInt32(ddlUvt.SelectedIndex.ToString());
            proyecto.IdAreaProductiva = Convert.ToInt32(ddlAreaProductiva.SelectedIndex.ToString());
            proyecto.IdEstado = Convert.ToInt32(ddlEstado.SelectedIndex.ToString());
            proyecto.MontoSolicitado = Convert.ToDecimal(txtMontoSolicitado.Text);
            proyecto.MontoContraparte = Convert.ToDecimal(txtMontoContraparte.Text);
            proyecto.Activo = true;

            proyectoNego.GuardarProyecto(proyecto);

            Response.Redirect("AltaProyecto.aspx");

        }

        protected void btnModalEstadoGuardar_Click(object sender, EventArgs e)
        {

        }

        protected void btnModalAreaProductivaGuardar_Click(object sender, EventArgs e)
        {

        }

        protected void dgvProyecto_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            GridViewRow row = dgvProyecto.Rows[e.NewSelectedIndex];
            
            lblMontoSolicitado.Text = row.Cells[1].Text;

            idProyectoActual = Convert.ToInt32(dgvProyecto.Rows[e.NewSelectedIndex].Cells[1].Text);

            txtNombre.Text = dgvProyecto.Rows[e.NewSelectedIndex].Cells[2].Text;
            txtNumeroExp.Text = dgvProyecto.Rows[e.NewSelectedIndex].Cells[3].Text;
            ddlConvocatoria.Text = convocatoriaNego.ObtenerConvocatoria(Convert.ToInt32(dgvProyecto.Rows[e.NewSelectedIndex].Cells[4].Text)).Nombre;
            ddlUvt.Text = uvtNego.TraerUvt(Convert.ToInt32(dgvProyecto.Rows[e.NewSelectedIndex].Cells[5].Text));
            ddlAreaProductiva.Text = areaProductivaNego.TraerAreaProductiva(Convert.ToInt32(dgvProyecto.Rows[e.NewSelectedIndex].Cells[6].Text));
            ddlEstado.Text = estadoNego.TraerEstado(Convert.ToInt32(dgvProyecto.Rows[e.NewSelectedIndex].Cells[7].Text));
            txtMontoSolicitado.Text = Convert.ToString(dgvProyecto.Rows[e.NewSelectedIndex].Cells[8].Text);
            txtMontoContraparte.Text = Convert.ToString(dgvProyecto.Rows[e.NewSelectedIndex].Cells[9].Text);

            btnGuardarProyecto.Visible = false;
            btnActualizarProyecto.Visible = true;
        }

        protected void btnActualizarProyecto_Click(object sender, EventArgs e)
        {
            ActualizarProyecto();
        }

        private void ActualizarProyecto()
        {
            Proyecto proyecto = new Proyecto();

            proyecto.Nombre = txtNombre.Text;
            proyecto.NumeroExp = txtNumeroExp.Text;
            proyecto.IdConvocatoria = Convert.ToInt32(ddlConvocatoria.SelectedIndex.ToString());
            proyecto.IdUvt = Convert.ToInt32(ddlUvt.SelectedIndex.ToString());
            proyecto.IdAreaProductiva = Convert.ToInt32(ddlAreaProductiva.SelectedIndex.ToString());
            proyecto.IdEstado = Convert.ToInt32(ddlEstado.SelectedIndex.ToString());
            proyecto.MontoSolicitado = Convert.ToDecimal(txtMontoSolicitado.Text);
            proyecto.MontoContraparte = Convert.ToDecimal(txtMontoContraparte.Text);
            proyecto.Activo = true;

            proyecto.IdProyecto = idProyectoActual;

            proyectoNego.ActualizarProyecto(proyecto);

            //LimpiarPantalla();
            //MostrarProyecto();

            btnActualizarProyecto.Visible = false;
        }
    }
}