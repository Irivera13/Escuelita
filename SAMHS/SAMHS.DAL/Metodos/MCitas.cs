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
    public class MCitas : MBase, ICitas
    {
        public void ActualizarCitas(Citas citas)
        {
            _db.Update(citas);
        }

        public void AgregarCitas(Citas citas)
        {
            try
            {
                _db.Insert(citas);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public Citas BuscarCitas(int idCitas)
        {
            return _db.Select<Citas>(x => x.Id == idCitas).FirstOrDefault();
        }

        public void EliminarCitas(int idCitas)
        {
            _db.Delete<Citas>(x => x.Id == idCitas);
        }

        public List<Citas> ListaCitas()
        {
            return _db.Select<Citas>();
        }
    }
}
