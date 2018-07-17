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
    public class MUsuario : MBase, IUsuario
    {
        public void AgregarAdministrador(Administrador administrador)
        {
            try
            {
                _db.Insert(administrador);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void AgregarEstudiante(Estudiante estudiante)
        {
            try
            {
                _db.Insert(estudiante);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void AgregarProfesor(Profesor profesor)
        {
            try
            {
                _db.Insert(profesor);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<Administrador> ListaAdministradores()
        {
            return _db.Select<Administrador>();
        }

        public List<Estudiante> ListaEstudiantes()
        {
            return _db.Select<Estudiante>();
        }

        public List<Profesor> ListaProfesores()
        {
            return _db.Select<Profesor>();
        }
    }
}
