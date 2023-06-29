using EVA03_V2.Controllers;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebServices1
{
    public partial class Form : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                cafeController cafeController = new cafeController();

                var BoletaJson = cafeController.ObtenerCafeJson();

                var Boleta = JArray.Parse(BoletaJson);

                var BoletasOrdenadas = Boleta.OrderBy(p => (string)p["NombreProducto"]).ToList();

                Gridview1.DataSource = BoletasOrdenadas;
                Gridview1.DataBind();

            }
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {

            string IdBoleta = txtBuscarId.Text;

            cafeController cafeController = new cafeController();

            var BoletaJson = cafeController.ObtenerCafeJson();

            var Boleta = JArray.Parse(BoletaJson);

            var BoletaFitrada = Boleta.Where(p => (string)p["IdBoleta"] == IdBoleta).ToList;

            Gridview1.DataSource = BoletaFitrada;
            Gridview1.DataBind();

        }
    }
}