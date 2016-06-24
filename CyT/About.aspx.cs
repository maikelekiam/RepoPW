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
    public partial class About : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        [WebMethod]
        public static string Login(string login, string senha)
        {
            string resposta;

            if (login == senha)
            {
                resposta = "CORRECTO";
            }
            else
            {
                resposta = "INTENTE DE NUEVO";
            }

            return resposta;
        }
    }
}