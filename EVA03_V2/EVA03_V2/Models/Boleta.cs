using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EVA03_V2.Models
{
    public class Boleta : ProductoCafeteria
    {
        public Venta ClaseVenta { get; set; }
        public string IdBoleta { get; set; }


    }
}