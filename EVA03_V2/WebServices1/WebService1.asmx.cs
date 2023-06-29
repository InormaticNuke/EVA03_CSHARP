using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using EVA03_V2.Models;
using EVA03_V2.Controllers;

namespace WebServices1
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]

        public string ObtenerCafeJson()
        {
            cafeController cafeController = new cafeController();

            var BoletaJson = cafeController.ObtenerCafeJson();

            var Boleta =    JArray.Parse(BoletaJson);

            var BoletasOrdenadas = Boleta.OrderBy(p  => (string)p["NombreCafe"]).ToList();

            var BoletasOrdenadasJson = JsonConvert.SerializeObject(BoletasOrdenadas);

            return BoletasOrdenadasJson;


        }
    }
}
