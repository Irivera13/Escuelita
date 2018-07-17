using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SAMHS.DATA;

namespace SAMHS.DAL.Interfaces
{
    public interface IUniformes
    {
        List<Uniformes> ListaUniformes();
        void AgregarUniformes (Uniformes uniformes);
        Uniformes BuscarUniformes(int idUniformes);
        void ActualizarUniformes(Uniformes uniformes);
        void EliminarUniformes (int idUniformes);
    }
}
