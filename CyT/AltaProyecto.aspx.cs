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
        private IntegranteNego integranteNego = new IntegranteNego();
        
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
            ddlEstado.DataValueField = "idEstado";
            ddlEstado.DataBind();
        }

        private void MostrarAreaProductiva()
        {
            ddlAreaProductiva.DataSource = areaProductivaNego.MostrarAreaProductiva();
            ddlAreaProductiva.DataValueField = "idAreaProductiva";
            ddlAreaProductiva.DataBind();
        }

        private void MostrarUvt()
        {
            ddlUvt.DataSource = uvtNego.MostrarUvt();
            ddlUvt.DataValueField = "idUvt";
            ddlUvt.DataBind();
        }

        private void MostrarConvocatoria()
        {
            ddlConvocatoria.DataSource = convocatoriaNego.MostrarConvocatorias();
            ddlConvocatoria.DataValueField = "idConvocatoria";
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
            proyecto.IdUvt = Convert.ToInt32(ddlUvt.SelectedValue.ToString());
            proyecto.IdAreaProductiva = Convert.ToInt32(ddlAreaProductiva.SelectedValue.ToString());
            proyecto.IdEstado = Convert.ToInt32(ddlEstado.SelectedValue.ToString());
            proyecto.MontoSolicitado = Convert.ToDecimal(txtMontoSolicitado.Text);
            proyecto.MontoContraparte = Convert.ToDecimal(txtMontoContraparte.Text);
            proyecto.Activo = true;

            int idProyecto=proyectoNego.GuardarProyecto(proyecto);
            foreach (Persona p in beneficiarios)
            {
                Integrante integrante = new Integrante();
                integrante.IdProyecto = idProyecto;
                integrante.IdPersona = p.IdPersona;
                integranteNego.GuardarIntegrante(integrante);
            }

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
            Proyecto proyecto = proyectoNego.ObtenerProyecto(idProyectoActual);
            txtNombre.Text = proyecto.Nombre;
            txtNumeroExp.Text = proyecto.NumeroExp;
            ddlConvocatoria.SelectedValue = proyecto.IdConvocatoria.ToString();
            ddlUvt.SelectedValue = proyecto.IdUvt.ToString();
            //ddlUvt.Text = uvtNego.TraerUvt(Convert.ToInt32(dgvProyecto.Rows[e.NewSelectedIndex].Cells[5].Text));
            ddlAreaProductiva.SelectedValue = proyecto.IdAreaProductiva.ToString();
            //ddlAreaProductiva.Text = areaProductivaNego.TraerAreaProductiva(Convert.ToInt32(dgvProyecto.Rows[e.NewSelectedIndex].Cells[6].Text));
            ddlEstado.SelectedValue = proyecto.IdEstado.ToString();
            //ddlEstado.Text = estadoNego.TraerEstado(Convert.ToInt32(dgvProyecto.Rows[e.NewSelectedIndex].Cells[7].Text));
            txtMontoSolicitado.Text = proyecto.MontoSolicitado.ToString();
            txtMontoContraparte.Text = proyecto.MontoContraparte.ToString();
            beneficiarios.Clear();
            foreach (Integrante i in proyecto.Integrantes)
            {
                beneficiarios.Add(i.Persona);
            }
            MostrarBeneficiarios();

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
            proyecto.IdConvocatoria = Convert.ToInt32(ddlConvocatoria.SelectedValue.ToString());
            proyecto.IdUvt = Convert.ToInt32(ddlUvt.SelectedValue.ToString());
            proyecto.IdAreaProductiva = Convert.ToInt32(ddlAreaProductiva.SelectedValue.ToString());
            proyecto.IdEstado = Convert.ToInt32(ddlEstado.SelectedValue.ToString());
            proyecto.MontoSolicitado = Convert.ToDecimal(txtMontoSolicitado.Text);
            proyecto.MontoContraparte = Convert.ToDecimal(txtMontoContraparte.Text);
            proyecto.Activo = true;

            proyecto.IdProyecto = idProyectoActual;

            proyectoNego.ActualizarProyecto(proyecto);
            integranteNego.BorrarIntegrantesPorProyecto(idProyectoActual);
            foreach (Persona p in beneficiarios)
            {
                Integrante integrante = new Integrante();
                integrante.IdProyecto = idProyectoActual;
                integrante.IdPersona = p.IdPersona;
                integranteNego.GuardarIntegrante(integrante);
            }
            
            //LimpiarPantalla();
            //MostrarProyecto();

            btnActualizarProyecto.Visible = false;
            btnGuardarProyecto.Visible = true;

            Response.Redirect("AltaProyecto.aspx");
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
            int index = Convert.ToInt32(e.CommandArgument.ToString());

            for (int i = 0; i < beneficiarios.Count; i++)
            {
                if (i == index)
                {
                    beneficiarios.RemoveAt(i);
                }
            }
            MostrarBeneficiarios();
        }
    }
}