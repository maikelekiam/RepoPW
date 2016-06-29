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
    public partial class ListarBeneficiarios : System.Web.UI.Page
    {
        PersonaNego personaNego = new PersonaNego();
        public static int idPersonaSeleccionada;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;

            MostrarListaBeneficiarios();
        }

        private void MostrarListaBeneficiarios()
        {
            dgvPersona.Columns[0].Visible = true;
            dgvPersona.Columns[5].Visible = true;
            dgvPersona.Columns[6].Visible = true;
            dgvPersona.Columns[7].Visible = true;
            dgvPersona.Columns[8].Visible = true;
            dgvPersona.Columns[9].Visible = true;
            dgvPersona.Columns[10].Visible = true;
            dgvPersona.Columns[11].Visible = true;
            dgvPersona.Columns[12].Visible = true;

            dgvPersona.DataSource = personaNego.MostrarListaBeneficiarios().ToList();
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


        private void MostrarPersona()
        {
            Response.Redirect("MostrarBeneficiario.aspx");
        }

        protected void dgvPersona_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            
            //Obtengo el indice de la fila seleccionada con el boton MOSTRAR
            GridViewRow row = (GridViewRow)(((Button)e.CommandSource).NamingContainer);
            int rIndex = row.RowIndex;

            //Obtengo el id de la persona seleccionada
            idPersonaSeleccionada = Convert.ToInt32(dgvPersona.Rows[rIndex].Cells[0].Text);

            MostrarPersona();
        }
    }
}