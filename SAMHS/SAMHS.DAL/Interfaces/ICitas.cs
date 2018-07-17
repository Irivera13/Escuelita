using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SAMHS.DATA;

namespace SAMHS.DAL.Interfaces
{
    public interface ICitas
    {
        List<Citas> ListaCitas();
        void AgregarCitas(Citas citas);
        Citas BuscarCitas(int idCitas);
        void ActualizarCitas(Citas citas);
        void EliminarCitas(int idCitas);
    }
}
