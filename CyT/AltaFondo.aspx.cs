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
        static int idFondoActual;


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                LlenarListaOrigenes();
                LlenarGrillaFondos();
            }
        }


        private void LlenarListaOrigenes()
        {
            ddlOrigen.DataSource = origenNego.MostrarOrigenes().ToList();
            ddlOrigen.DataValueField = "idOrigen";
            ddlOrigen.DataBind();
        }

        private void LlenarGrillaFondos()
        {

            btnActualizarFondo.Visible = false;
            btnGuardarFondo.Visible = true;

            dgvFondo.Columns[0].Visible = true;
            dgvFondo.Columns[1].Visible = true;
            dgvFondo.Columns[2].Visible = true;
            dgvFondo.Columns[3].Visible = true;
            dgvFondo.Columns[4].Visible = true;

            dgvFondo.DataSource = fondoNego.MostrarFondos().ToList();
            dgvFondo.DataBind();

            dgvFondo.Columns[0].Visible = false;
            dgvFondo.Columns[4].Visible = false;


        }
        protected void btnGuardarFondo_Click(object sender, EventArgs e)
        {
            GuardarFondo();
            LlenarGrillaFondos();
        }

        private void GuardarFondo()
        {
            Fondo fondo = new Fondo();

            fondo.Nombre = txtNombre.Text;
            fondo.Descripcion = txtDecripcion.Text;
            //fondo.IdOrigen = Int32.Parse(ddlOrigen.SelectedValue);
            fondo.IdOrigen = origenNego.TraerOrigenIdSegunItem(ddlOrigen.SelectedItem.ToString());
            fondo.Activo = true;

            if ((fondo.Nombre != "") && (fondo.Descripcion != ""))
            {
                fondoNego.GuardarFondo(fondo);
            }

            //fondoNego.GuardarFondo(fondo);

            LlenarGrillaFondos();
        }


        protected void dgvFondo_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            btnActualizarFondo.Visible = true;
            btnGuardarFondo.Visible = false;

            GridViewRow row = dgvFondo.Rows[e.NewSelectedIndex];

            idFondoActual = Convert.ToInt32(row.Cells[0].Text);

            Fondo fondoNuevo = fondoNego.ObtenerFondo(idFondoActual);

            txtNombre.Text = fondoNuevo.Nombre;
            txtDecripcion.Text = fondoNuevo.Descripcion;
            ddlOrigen.SelectedValue = fondoNuevo.IdOrigen.ToString();

        }
        private string TraerOrigenSegunIdFondo(int id)
        {
            return origenNego.TraerOrigenSegunIdFondo(id);
        }

        protected void dgvFondo_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            btnGuardarFondo.Visible = false;
            btnActualizarFondo.Visible = false;

            idFondoActual = Convert.ToInt32(dgvFondo.Rows[e.RowIndex].Cells[0].Text);

            Fondo fondo = fondoNego.ObtenerFondo(idFondoActual);


            //if (fondo.Convocatoria != null)
            //{
            //    string script = "alert(\"No se puede eliminar Fondo.\");";
            //    ScriptManager.RegisterStartupScript(this, GetType(),
            //                          "ServerControlScript", script, true);
            //}
            //else
            //{
            EliminarFondo(idFondoActual);
            //}
        }

        private void EliminarFondo(int id)
        {
            fondoNego.EliminarFondo(id);
            Response.Redirect("AltaFondo.aspx");
            LlenarGrillaFondos();
        }


        protected void btnActualizarFondo_Click(object sender, EventArgs e)
        {
            ActualizarFondo();
        }

        private void ActualizarFondo()
        {
            Fondo fondo = new Fondo();

            fondo.Nombre = txtNombre.Text;
            fondo.Descripcion = txtDecripcion.Text;
            //fondo.IdOrigen = Int32.Parse(ddlOrigen.SelectedValue);
            fondo.IdOrigen = origenNego.TraerOrigenIdSegunItem(ddlOrigen.SelectedItem.ToString());
            fondo.Activo = true;

            fondo.IdFondo = idFondoActual;

            fondoNego.ActualizarFondo(fondo);

            Response.Redirect("AltaFondo.aspx");
            //LlenarGrillaFondos();

            btnActualizarFondo.Visible = false;
            btnGuardarFondo.Visible = true;

        }
    }
}