using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SAMHS.DATA;

namespace SAMHS.DAL.Interfaces
{
    public interface IUsuario
    {
        List<Estudiante> ListaEstudiantes();
        List<Administrador> ListaAdministradores();
        List<Profesor> ListaProfesores();

        void AgregarEstudiante (Estudiante estudiante);
        void AgregarAdministrador (Administrador administrador);
        void AgregarProfesor (Profesor profesor);

    }
}
