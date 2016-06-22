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
    public partial class ListarBeneficiarios : System.Web.UI.Page
    {
        PersonaNego personaNego = new PersonaNego();
        int idPersona;

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


        //private void MostrarPersona(int idPersona)
        //{

        //}

        protected void dgvPersona_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            idPersona = Convert.ToInt32(dgvPersona.Rows[e.NewSelectedIndex].Cells[0].Text);


        }
    }
}