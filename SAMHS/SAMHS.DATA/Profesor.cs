using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAMHS.DATA
{
    public class Profesor
    {
        public int IdCedula { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string MateriaImpartida { get; set; }

        public int? Edad { get; set; }

        public string Contraseña { get; set; }

    }

}
