using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack.DataAnnotations;

namespace SAMHS.DATA
{
    public class Uniformes
    {
        [AutoIncrement]
        public int Id { get; set; }

        public string Tipo { get; set; }

        public string Talla { get; set; }

        public int? Cantidad { get; set; }

        public string Comentarios { get; set; }

    }
}
