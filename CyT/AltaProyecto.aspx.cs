using System;
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
    public partial class AltaProyecto : System.Web.UI.Page
    {
        EstadoNego estadoNego = new EstadoNego();
        AreaProductivaNego areaProductivaNego = new AreaProductivaNego();
        UvtNego uvtNego = new UvtNego();
        ConvocatoriaNego convocatoriaNego = new ConvocatoriaNego();
        ProyectoNego proyectoNego = new ProyectoNego();
        PersonaNego personaNego = new PersonaNego();
        static List<Persona> beneficiarios = new List<Persona>();
        private Integrante integranteNego = new Integrante();
        static int idProyectoActual;



        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;

            MostrarEstado();
            MostrarAreaProductiva();
            MostrarUvt();
            MostrarConvocatoria();
            MostrarProyecto();
            llenarListaBeneficiarios();

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

        private void GuardarProyecto()
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

            proyectoNego.GuardarProyecto(proyecto);

            Response.Redirect("AltaProyecto.aspx");

        }

        protected void btnModalEstadoGuardar_Click(object sender, EventArgs e)
        {
            Estado estado = new Estado();

            estado.Nombre = txtEstadoModal.Text;

            estadoNego.GuardarEstado(estado);

            ddlEstado.Items.Clear();
            MostrarEstado();
        }

        protected void btnModalAreaProductivaGuardar_Click(object sender, EventArgs e)
        {
            AreaProductiva areaProductiva = new AreaProductiva();

            areaProductiva.Nombre = txtAreaProductivaModal.Text;

            areaProductivaNego.GuardarAreaProductiva(areaProductiva);

            ddlAreaProductiva.Items.Clear();
            MostrarAreaProductiva();
        }

        protected void dgvProyecto_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            GridViewRow row = dgvProyecto.Rows[e.NewSelectedIndex];

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

        [WebMethod]
        public static string Savedata(string txt01, string txt02)
        {
            string respuesta;

            decimal a1, a2, a3;

            if (txt01 != null) { a1 = Convert.ToDecimal(txt01); } else { a1 = 0; }
            if (txt02 != null) { a2 = Convert.ToDecimal(txt02); } else { a2 = 0; }

            a3 = a1 / a2 * 100;

            

            respuesta = Convert.ToString(Math.Round(a3,2));

            //if (HttpContext.Current != null)
            //{
            //    Page page = (Page)HttpContext.Current.Handler;

            //    TextBox tb01 = (TextBox)page.FindControl("txt01");

            //    TextBox tb02 = (TextBox)page.FindControl("txt02");
            //}

            return respuesta;

        }

        protected void btnModalBeneficiarioGuardar_Click(object sender, EventArgs e)
        {
            Persona item = personaNego.ObtenerPersona(Int32.Parse(ddlBeneficiario.SelectedValue));
            beneficiarios.Add(item);
            MostrarBeneficiarios();
        }

        private void llenarListaBeneficiarios()
        {            
            List<Persona> datos = personaNego.MostrarListaInteresados().ToList();
            var productQuery = datos.Select(p => new { idPersona = p.IdPersona, DisplayText = p.Apellido + ", " + p.Nombre + "  " + p.Documento });
            ddlBeneficiario.DataSource = productQuery;            
            ddlBeneficiario.DataValueField = "idPersona";
            ddlBeneficiario.DataTextField = "DisplayText";
            ddlBeneficiario.DataBind();
        }

        private void MostrarBeneficiarios()
        {
            dgvBeneficiarios.DataSource = beneficiarios;
            dgvBeneficiarios.DataBind();
            dgvBeneficiarios.Columns[0].Visible = false;
        }

        protected void btnEliminarBeneficiario_Command(object sender, CommandEventArgs e)
        {

        }
    }
}