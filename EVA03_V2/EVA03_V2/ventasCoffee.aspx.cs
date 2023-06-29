using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EVA03_V2
{
    public partial class ventasCoffee : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            string NombreVendedor = txtNombreV.Text;
            String NombreCafe = txtNombreC.Text;
            String TipoCafe = TipoDDL.SelectedItem.Value;
            int Cantidad = Convert.ToInt32(txtCant.Text);
            int Precio = Convert.ToInt32(txtPrecio.Text);
            String Fecha = txtFecha.Text;

            int total = Cantidad * Precio;
            double totalIVA = total * 0.19;

            lblResultado.Text =
                                $"Nombre Vendedor: {NombreVendedor} <br />" +
                                $"Nombre Juego: {NombreCafe} <br />" +
                                $"Tipo de Juego: {TipoCafe} <br />" +
                                $"Cantidad de productos: {Cantidad} <br />" +
                                $"Precio del Juego: {Precio} <br />" +
                                $"Fecha de compra: {Fecha} <br /> <br />" +
                                $"Precio Total: ${total}  <br />" +
                                $"Precio con IVA: ${totalIVA}  <br />";
        }
    }
}