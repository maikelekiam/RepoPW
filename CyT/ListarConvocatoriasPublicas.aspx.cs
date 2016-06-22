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
    public partial class ListarConvocatoriasPublicas : System.Web.UI.Page
    {
        ConvocatoriaNego convocatoriaNego = new ConvocatoriaNego();
        protected void Page_Load(object sender, EventArgs e)
        {
            CargarConvocatorias();
        }

        private void CargarConvocatorias()
        {
            ModalidadNego modalidadNego=new ModalidadNego();
            dgvConvocatoria.DataSource = convocatoriaNego.MostrarConvocatoriasPorModalidad(modalidadNego.ObtenerModalidadPorNombre("Publica"));
            dgvConvocatoria.DataBind();
        }

        protected void dgvConvocatoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void dgvConvocatoria_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {

                switch (Convert.ToInt32(e.Row.Cells[6].Text))
                {

                    case 0:
                        e.Row.Cells[6].Text = "CERRADA";
                        break;

                    case 1:
                        e.Row.Cells[6].Text = "ABIERTA";
                        break;

                }

            }
        }
    }
}