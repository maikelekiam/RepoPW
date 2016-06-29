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
    public partial class ListarProyectosEnEjecucion : System.Web.UI.Page
    {
        ProyectoNego proyectoNego = new ProyectoNego();


        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;

            MostrarProyecto();
        }

        private void MostrarProyecto()
        {
            dgvProyecto.Columns[0].Visible = true;
            dgvProyecto.Columns[3].Visible = true;
            dgvProyecto.Columns[4].Visible = true;
            dgvProyecto.Columns[5].Visible = true;
            dgvProyecto.Columns[6].Visible = true;
            dgvProyecto.Columns[7].Visible = true;
            dgvProyecto.Columns[8].Visible = true;
            dgvProyecto.Columns[9].Visible = true;

            dgvProyecto.DataSource = proyectoNego.MostrarProyectosEnEjecucion().ToList();
            dgvProyecto.DataBind();

            dgvProyecto.Columns[0].Visible = false;
            dgvProyecto.Columns[3].Visible = false;
            dgvProyecto.Columns[4].Visible = false;
            dgvProyecto.Columns[5].Visible = false;
            dgvProyecto.Columns[6].Visible = false;
            dgvProyecto.Columns[7].Visible = false;
            dgvProyecto.Columns[8].Visible = false;
            dgvProyecto.Columns[9].Visible = false;
        }
    }
}