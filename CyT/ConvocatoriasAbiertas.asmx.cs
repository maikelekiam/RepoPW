using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Xml.Serialization;
using CapaDominio;
using CapaNegocio;


namespace CyT
{
    /// <summary>
    /// Summary description for ConvocatoriasAbiertas
    /// </summary>
    [WebService(Namespace = "http://cyt.com/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class ConvocatoriasAbiertas : System.Web.Services.WebService
    {
        ConvocatoriaNego convocatoriaNego = new ConvocatoriaNego();
        ModalidadNego modalidadNego = new ModalidadNego();


        [WebMethod]
        public List<Convocatorium> MostrarConvocatoriasAbiertas()
        {
            return convocatoriaNego.MostrarConvocatoriasAbiertas().ToList();
                        
        }

        [WebMethod]
        public List<Convocatorium> MostrarConvocatoriasPorModalidad(String modalidad)
        {
            
            return convocatoriaNego.MostrarConvocatoriasPorModalidad(modalidadNego.ObtenerModalidadPorNombre(modalidad)).ToList();

        }


        //[WebMethod]
        //public string HelloWorld()
        //{
        //    return "Hello World";
        //}
                
    }
}
