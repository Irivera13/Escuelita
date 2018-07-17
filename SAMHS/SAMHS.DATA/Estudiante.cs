using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAMHS.DATA
{
    public class Estudiante
    {
        public int IdCarnet { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public int? Edad { get; set; }

        public string Curso { get; set; }

        public string Padre { get; set; }

        public string Madre { get; set; }

        public bool? Red { get; set; }

        public string Contraseña { get; set; }

    }
}
