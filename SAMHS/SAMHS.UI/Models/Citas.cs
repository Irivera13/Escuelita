using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SAMHS.UI.Models
{
    public class Citas
    {
        public int Id { get; set; }

        public string Encargado { get; set; }

        public DateTime Fecha { get; set; }

        public string Asunto { get; set; }
    }
}