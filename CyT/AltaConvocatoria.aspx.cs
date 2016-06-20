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
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                LlenarListaFondos();
                LlenarListaModalidad();
                LlenarListaModalidad();
                LlenarListaTipofinanciamiento();
                LlenarGrillaConvocatorias();
            }
        }

        protected void btnGuardarConvocatoria_Click(object sender, EventArgs e)
        {
            GuardarConvocatoria();
            LlenarGrillaConvocatorias();
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
            //convocatoria.IsAbierta = chkIsAbierta.Checked);
            convocatoria.MontoProyecto = Convert.ToDecimal(txtMontoProyecto.Text);
            convocatoria.MontoTotal = Convert.ToDecimal(txtMontoTotal.Text);            
            convocatoriaNego.GuardarConvocatoria(convocatoria);
        }
    }
}