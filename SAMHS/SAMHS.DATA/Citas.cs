using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack.DataAnnotations;

namespace SAMHS.DATA
{
    public class Citas
    {
        [AutoIncrement]
        public int Id { get; set; }

        public string Encargado { get; set; }

        public DateTime Fecha { get; set; }

        public string Asunto { get; set; }

    }

}
