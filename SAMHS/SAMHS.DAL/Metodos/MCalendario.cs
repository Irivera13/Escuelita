using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SAMHS.DATA;
using SAMHS.DAL.Interfaces;
using ServiceStack.OrmLite;

namespace SAMHS.DAL.Metodos
{
    public class MCalendario : MBase, ICalendario
    {
        public List<Calendario> ListaCalendario()
        {
            return _db.Select<Calendario>();
        }
    }
}
