using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SAMHS.UI.Models
{
    public class Uniformes
    {
        public int Id { get; set; }

        public string Tipo { get; set; }

        public string Talla { get; set; }

        public int? Cantidad { get; set; }

        public string Comentarios { get; set; }
    }
}