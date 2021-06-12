using System.Collections.Generic;
using System.Linq;
using DataBase.Modules;
using Microsoft.EntityFrameworkCore;

namespace ClassLibraryEngSoft
{
    public class DBQuerys
    {
        private DBContext _DbContext;

        public DBQuerys()
        {
            _DbContext = new DBContext();
        }

        public List<string> GetPhoneNumbers()
        {
            return _DbContext.Persons.Select(e => e.telefone).ToList();
        }

        public List<Person> GetPersons()
        {
            return _DbContext.Persons.ToList();
        }

        public void InsertClient(Client person)
        {
            _DbContext.Clients.Add(person);
            _DbContext.SaveChanges();
        }

        public List<Exercise> GetExercises(int PrescicaoID)
        {
            return _DbContext.Exercises.Where(e=>e.Prescription.ID == PrescicaoID).ToList();
            /*List<Exercise> retorno = new List<Exercise>();
            foreach (var exercise in exercicios)
            {
                if (exercise.PrescriptionID == PrescicaoID)
                {
                    retorno.Add(exercise);
                }
            }
            return retorno;*/
        }

        public List<Treatment> GetTreatments(int PrescricaoID)
        {
            return _DbContext.Treatments.Where(e => e.Prescription.ID == PrescricaoID).ToList();
        }

        public List<Medicamento> GetMeds(int PrescricaoID)
        {
            return _DbContext.Meds.Where(e => e.Prescription.ID == PrescricaoID).ToList();
        }

        public List<Prescription> GetPrescriptionsById(int ID)
        {
            return _DbContext.Prescricoes.Where(e => e.Client.ID == ID).ToList();
        }
    }
}