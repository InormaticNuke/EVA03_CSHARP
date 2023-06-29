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
                new Boleta {IdProducto = "001", NombreCafe = "Ice Coffee", TipoCafe = "Ice Coffee", Precio = 6990, ClaseVenta = new Venta {IdVendedor = "69420", NombreVendedor = "Nuke", CantidadProducto = 2, FechaVenta = "29-05-2023"}},
                new Boleta {IdProducto = "002", NombreCafe = "Special Coffee", TipoCafe = "Cafe Especial", Precio = 12990, ClaseVenta = new Venta {IdVendedor = "6969", NombreVendedor = "Cosme Fulanito", CantidadProducto = 6, FechaVenta = "28-05-2023"}},
                new Boleta {IdProducto = "003", NombreCafe = "Cafe Caramelo Latte", TipoCafe = "Latte", Precio = 8000, ClaseVenta = new Venta {IdVendedor = "00001", NombreVendedor = "Pedro Aguilera", CantidadProducto = 3, FechaVenta = "15-06-2023"}},
                new Boleta {IdProducto = "004", NombreCafe = "Cafe Cappuccino Clasico", TipoCafe = "Cappuccino", Precio = 8500, ClaseVenta = new Venta {IdVendedor = "00002", NombreVendedor = "Jose Prieto", CantidadProducto = 5, FechaVenta = "16-06-2023"}},
                new Boleta {IdProducto = "005", NombreCafe = "Cafe Cappuccino Vainilla", TipoCafe = "Cappuccino", Precio = 6000, ClaseVenta = new Venta {IdVendedor = "00003", NombreVendedor = "Manuel Rodriguez", CantidadProducto = 1, FechaVenta = "17-06-2023"}},
                new Boleta {IdProducto = "006", NombreCafe = "Cafe Moccaccino", TipoCafe = "Moccaccino", Precio = 7500, ClaseVenta = new Venta {IdVendedor = "00004", NombreVendedor = "Pedro Aguilera", CantidadProducto = 2, FechaVenta = "18-06-2023"}},
            };
        }

        public string ObtenerCafeJson()
        {
            return JsonConvert.SerializeObject(cafe);
        }
    }
}