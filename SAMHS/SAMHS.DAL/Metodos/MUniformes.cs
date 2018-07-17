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
    public class MUniformes : MBase, IUniformes
    {
        public void ActualizarUniformes(Uniformes uniformes)
        {
            _db.Update(uniformes);
        }

        public void AgregarUniformes(Uniformes uniformes)
        {
            try
            {
                _db.Insert(uniformes);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public Uniformes BuscarUniformes(int idUniformes)
        {
            return _db.Select<Uniformes>(x => x.Id == idUniformes).FirstOrDefault();
        }

        public void EliminarUniformes(int idUniformes)
        {
            _db.Delete<Uniformes>(x => x.Id == idUniformes);
        }

        public List<Uniformes> ListaUniformes()
        {
            return _db.Select<Uniformes>();
        }
    }
}
