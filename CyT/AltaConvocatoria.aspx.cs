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
    public partial class AltaConvocatoria : System.Web.UI.Page
    {
        private ConvocatoriaNego convocatoriaNego = new ConvocatoriaNego();
        private FondoNego fondoNego = new FondoNego();
        private ModalidadNego modalidadNego = new ModalidadNego();
        private TipoFinanciamientoNego tipoFinanciamientoNego = new TipoFinanciamientoNego();
        private TipoDestinatarioNego tipoDestinatarioNego = new TipoDestinatarioNego();
        static List<TipoDestinatario> tiposDestinatarios = new List<TipoDestinatario>();
        private ListaTipoDestinatarioNego listaTipoDestinatarioNego = new ListaTipoDestinatarioNego();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                
                LlenarListaFondos();
                LlenarListaModalidad();
                LlenarListaModalidad();
                LlenarListaTipofinanciamiento();
                LlenarListaTipoDestinatario();
                LlenarGrillaConvocatorias();
                LimpiarFormulario();
            }
        }

        protected void btnGuardarConvocatoria_Click(object sender, EventArgs e)
        {
            GuardarConvocatoria();
            LlenarGrillaConvocatorias();
            LimpiarFormulario();
        }

        protected void dgvConvocatoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LlenarListaFondos()
        {
            ddlFondo.DataSource = fondoNego.MostrarFondos().ToList();
            ddlFondo.DataValueField = "idFondo";
            ddlFondo.DataBind();
        }

        private void LlenarListaModalidad()
        {
            ddlModalidad.DataSource = modalidadNego.MostrarModalidades().ToList();
            ddlModalidad.DataValueField = "idModalidad";
            ddlModalidad.DataBind();
        }

        private void LlenarListaTipofinanciamiento()
        {
            ddlTipoFinanciamiento.DataSource = tipoFinanciamientoNego.MostrarTipoFinanciamientoes().ToList();
            ddlTipoFinanciamiento.DataValueField = "idTipoFinanciamiento";
            ddlTipoFinanciamiento.DataBind();
        }

        private void LlenarListaTipoDestinatario()
        {
            ddlTipoDestinatario.DataSource = tipoDestinatarioNego.MostrarTipoDestinatarios().ToList();
            ddlTipoDestinatario.DataValueField = "idTipoDestinatario";
            ddlTipoDestinatario.DataBind();
            
        }


        private void LlenarGrillaConvocatorias()
        {
            dgvConvocatoria.DataSource = convocatoriaNego.MostrarConvocatorias().ToList();
            dgvConvocatoria.DataBind();
        }

        private void GuardarConvocatoria()
        {
            Convocatorium convocatoria=new Convocatorium();
            FondoNego fondoNego = new FondoNego();
            
            convocatoria.Nombre=txtNombre.Text;
            convocatoria.Descripcion=txtDescripcion.Text;
            convocatoria.Objetivo=txtObjetivo.Text;
            convocatoria.Anio = Int32.Parse(txtAnio.Text);
            convocatoria.IdFondo = Int32.Parse(ddlFondo.SelectedValue);
            convocatoria.IdModalidad = Int32.Parse(ddlModalidad.SelectedValue);
            convocatoria.IdTipoFinanciamiento = Int32.Parse(ddlTipoFinanciamiento.SelectedValue);
            convocatoria.FechaCierre = Convert.ToDateTime(txtFechaCierre.Text);
            convocatoria.FechaInicio = Convert.ToDateTime(txtFechaInicio.Text);
            if (chkIsAbierta.Checked)
            {
                convocatoria.IsAbierta = 1;
            }
            else
            {
                convocatoria.IsAbierta = 0;
            }            
            convocatoria.MontoProyecto = Convert.ToDecimal(txtMontoProyecto.Text);
            convocatoria.MontoTotal = Convert.ToDecimal(txtMontoTotal.Text);            
            int idConvocatoria=convocatoriaNego.GuardarConvocatoria(convocatoria);
            foreach (TipoDestinatario t in tiposDestinatarios)
            {
                ListaTipoDestinatario listaTipoDestinatario = new ListaTipoDestinatario();
                listaTipoDestinatario.IdConvocatoria = idConvocatoria;
                listaTipoDestinatario.IdTipoDestinatario = t.IdTipoDestinatario;
                listaTipoDestinatarioNego.GuardarListaTipoDestinatario(listaTipoDestinatario);
            }
        }

        private void LimpiarFormulario()
        {
            txtNombre.Text=null;
            txtDescripcion.Text=null;
            txtObjetivo.Text=null;
            txtAnio.Text=null;
            ddlFondo.SelectedIndex=0;
            ddlModalidad.SelectedIndex=0;
            ddlTipoFinanciamiento.SelectedIndex = 0;
            txtFechaInicio.Text = null;
            txtFechaCierre.Text = null;
            chkIsAbierta.Checked = false;
            txtMontoProyecto.Text = null;
            txtMontoTotal.Text = null;
            tiposDestinatarios.Clear();
            dgvTipoDestinatarios.DataSource = tiposDestinatarios;
            dgvTipoDestinatarios.DataBind();
            dgvTipoDestinatarios.Columns[0].Visible = false;
        }

        protected void btnModalTipoDestinatarioGuardar_Click(object sender, EventArgs e)
        {
            
            TipoDestinatario item=tipoDestinatarioNego.ObtenerTipoDestinatario(Int32.Parse(ddlTipoDestinatario.SelectedValue));
            tiposDestinatarios.Add(item);
            dgvTipoDestinatarios.DataSource = tiposDestinatarios;
            dgvTipoDestinatarios.DataBind();
            dgvTipoDestinatarios.Columns[0].Visible = false;
        }

        protected void btnEliminarTipoDestinatario_Command(object sender, CommandEventArgs e)
        {

        }
    }
}