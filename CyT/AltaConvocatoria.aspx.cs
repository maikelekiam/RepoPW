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
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                LlenarListaFondos();
                LlenarListaModalidad();
                LlenarGrillaConvocatorias();
            }
        }

        protected void btnGuardarConvocatoria_Click(object sender, EventArgs e)
        {

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

        private void LlenarGrillaConvocatorias()
        {
            dgvConvocatoria.DataSource = convocatoriaNego.MostrarConvocatorias().ToList();
            dgvConvocatoria.DataBind();
        }
    }
}