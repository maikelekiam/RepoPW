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
    public partial class AltaFondo : System.Web.UI.Page
    {
        private FondoNego fondoNego = new FondoNego();
        private OrigenNego origenNego = new OrigenNego();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                LlenarListaOrigenes();
                LlenarGrillaFondos();
            }
        }

        protected void dgvFondo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LlenarListaOrigenes()
        {
            ddlOrigen.DataSource = origenNego.MostrarOrigenes().ToList();
            ddlOrigen.DataValueField = "idOrigen";
            ddlOrigen.DataBind();
        }

        private void LlenarGrillaFondos()
        {
            
            dgvFondo.DataSource = fondoNego.MostrarFondos().ToList();
            dgvFondo.DataBind();
            
        }

        private void GuardarFondo()
        {
            //FondoNego fondoNego2 = new FondoNego();
            Fondo fondo=new Fondo();
            fondo.Nombre = txtNombre.Text;
            fondo.Descripcion = txtDecripcion.Text;
            fondo.IdOrigen = Int32.Parse(ddlOrigen.SelectedValue);
            fondo.Activo = true;
            fondoNego.GuardarFondo(fondo);
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarFondo();
            LlenarGrillaFondos();
        }
    }
}