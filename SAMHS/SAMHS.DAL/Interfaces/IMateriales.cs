using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SAMHS.DATA;

namespace SAMHS.DAL.Interfaces
{
    public interface IMateriales
    {
        List<Materiales> ListaMateriales();
        void AgregarMateriales(Materiales materiales);
        Materiales BuscarMateriales(int idMateriales);
        void ActualizarMateriales(Materiales materiales);
        void EliminarMateriales(int idMateriales);
    }
}
