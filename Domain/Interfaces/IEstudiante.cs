using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IEstudiante : IRepository<Estudiante>
    {


        int CalculoPromedio(int id);
        Estudiante FindById(int id);

    }
}
