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



        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;
            
            MostrarEstado();
            MostrarAreaProductiva();
            MostrarUvt();
            MostrarConvocatoria();
            MostrarProyecto();

            //btnActualizarProyecto.Visible = false;
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

        private void MostrarProyecto()
        {
            //btnActualizarPersona.Visible = false;
            btnGuardarProyecto.Visible = true;
            dgvProyecto.DataSource = proyectoNego.MostrarProyecto().ToList();
            dgvProyecto.DataBind();


        }

        protected void btnGuardarProyecto_Click(object sender, EventArgs e)
        {
            GuardarProyecto();
        }

        private void GuardarProyecto(){

            Proyecto proyecto = new Proyecto();





            proyectoNego.GuardarProyecto(proyecto);
        }

        protected void btnModalEstadoGuardar_Click(object sender, EventArgs e)
        {

        }

        protected void btnModalAreaProductivaGuardar_Click(object sender, EventArgs e)
        {

        }

        protected void dgvProyecto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}