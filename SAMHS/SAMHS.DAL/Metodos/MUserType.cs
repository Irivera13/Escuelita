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
    public class MUserType : MBase, IUserType
    {
        public List<UserTypes> ListUserTypes()
        {
            try
            {
                return _db.Select<UserTypes>();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
