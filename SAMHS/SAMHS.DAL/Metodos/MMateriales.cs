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
    public class MMateriales : MBase, IMateriales
    {
        public void ActualizarMateriales(Materiales materiales)
        {
            _db.Update(materiales);
        }

        public void AgregarMateriales(Materiales materiales)
        {
            try
            {
                _db.Insert(materiales);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public Materiales BuscarMateriales(int idMateriales)
        {
            return _db.Select<Materiales>(x => x.Id == idMateriales).FirstOrDefault();
        }

        public void EliminarMateriales(int idMateriales)
        {
            _db.Delete<Materiales>(x => x.Id == idMateriales);
        }

        public List<Materiales> ListaMateriales()
        {
            return _db.Select<Materiales>();
        }
    }
}
