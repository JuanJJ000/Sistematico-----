using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class EstudianteRepository : IEstudiante
    {
        IPepitoSchoolContext pepitoSchoolContext;

        public EstudianteRepository(IPepitoSchoolContext pepitoSchoolContext)
        {
            this.pepitoSchoolContext = pepitoSchoolContext;
        }

        public int CalculoPromedio(int id)
        {
            try
            {

                Estudiante estudiante = FindById(id);


                if (estudiante == null)
                {
                    throw new ArgumentNullException("El objeto Estudiante no puede ser null.");
                }
                int promedio = (estudiante.Matematica + estudiante.Contabilidad + estudiante.Programación + estudiante.Estadistica) / 4;             
                return promedio;

            }
            catch (Exception)
            {

                return 0;         
                    
            }
        }

        public void Create(Estudiante t)
        {
            try
            {
                ValidateEstudiante(t);
                pepitoSchoolContext.Estudiantes.Add(t);
                pepitoSchoolContext.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        public bool Delete(Estudiante t)
        {
            try
            {
                if (t == null)
                {
                    throw new ArgumentNullException("El objeto Estudiante no puede ser null.");                  
                }

                Estudiante estudiante = FindById(t.Id);
                if (estudiante == null)
                {
                    throw new Exception($"El objeto con estudiante no existe.");
                }

                pepitoSchoolContext.Estudiantes.Remove(estudiante);
                int result = pepitoSchoolContext.SaveChanges();

                return result > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public Estudiante FindById(int id)
        {
            try
            {
                if (id <= 0)
                {
                    throw new Exception($"El id {id} no puede ser menor o igual a cero.");
                }

                return pepitoSchoolContext.Estudiantes.FirstOrDefault(x => x.Id == id);
            }
            catch
            {
                throw;
            }
        }

        public List<Estudiante> GetAll()
        {
            return pepitoSchoolContext.Estudiantes.ToList();
        }

        public int Update(Estudiante t)
        {
            try
            {
                if (t == null)
                {
                    throw new ArgumentNullException("El objeto asset no puede ser null.");
                }

                Estudiante estudiante = FindById(t.Id);
                if (estudiante == null)
                {
                    throw new Exception($"El objeto asset con id {t.Id} no existe.");
                }

                estudiante.Nombres = t.Nombres;
                estudiante.Apellidos = t.Apellidos;
                estudiante.Phone = t.Phone;        
                estudiante.Direccion = t.Direccion;
                estudiante.Correo = t.Correo;
                estudiante.Matematica = t.Matematica;
                estudiante.Contabilidad = t.Contabilidad;
                estudiante.Programación = t.Programación;
                estudiante.Estadistica = t.Estadistica;

                pepitoSchoolContext.Estudiantes.Update(estudiante);
                return pepitoSchoolContext.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        private void ValidateEstudiante(Estudiante estudiante)
        {
            if (estudiante == null)
            {
                throw new ArgumentNullException("El objeto estudiante no puede ser null.");
            }

           
          
        }


    }
}
