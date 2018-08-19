using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SAMHS.DATA;

namespace SAMHS.DAL.Interfaces
{
    public interface ICalendario
    {
        List<Calendario> ListaCalendario();
    }
}
