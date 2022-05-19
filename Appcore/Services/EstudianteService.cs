using Appcore.Interfaces;
using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appcore.Services
{
    public class EstudianteService : IEstudianteService
    {
        IEstudiante estudiante1;

        public EstudianteService(IEstudiante estudiante1)
        {
            this.estudiante1 = estudiante1;
        }

       

        public void Create(Estudiante t)
        {
            estudiante1.Create(t);
        }

        public bool Delete(Estudiante t)
        {
            return estudiante1.Delete(t);
        }

        public List<Estudiante> GetAll()
        {
            return estudiante1.GetAll();
        }

        public int CalculoPromedio(Estudiante estudiante)
        {
            return estudiante1.CalculoPromedio(estudiante);
        }

        public Estudiante FindById(int id)
        {
            return estudiante1.FindById(id);
        }

        public int Update(Estudiante t)
        {
            return estudiante1.Update(t);
        }
    }
}
