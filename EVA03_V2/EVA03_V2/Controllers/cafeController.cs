using EVA03_V2.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EVA03_V2.Controllers
{
    public class cafeController : Controller
    {
        // GET: cafe
        public ActionResult Index()
        {
            return View();
        }

        private Boleta[] cafe;

        public cafeController()
        {
            cafe = new Boleta[]
            {
                new Boleta {IdProducto = "001", NombreCafe = "Ice Coffee", TipoCafe = "Cafe Helado", Precio = 6990, ClaseVenta = new Venta {IdVendedor = "69420", NombreVendedor = "Nuke", CantidadProducto = 2, FechaVenta = "29-05-2023"}},
                new Boleta {IdProducto = "002", NombreCafe = "Special Coffee", TipoCafe = "Cafe Especial", Precio = 12990, ClaseVenta = new Venta {IdVendedor = "6969", NombreVendedor = "Cosme Fulanito", CantidadProducto = 6, FechaVenta = "28-05-2023"}},
            };
        }

        public string ObtenerCafeJson()
        {
            return JsonConvert.SerializeObject(cafe);
        }
    }
}