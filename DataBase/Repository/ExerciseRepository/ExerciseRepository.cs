using System.Collections.Generic;
using System.Linq;
using DataBase.Modules;

namespace ClassLibraryEngSoft.Repository
{
    public class ExerciseRepository : Repository<Exercise>, IExerciseRepository
    {
        public ExerciseRepository(DBContext context) : base(context)
        {
        }

        public IEnumerable<Exercise> GetExercisesByPrescription(int id)
        {
            return Context.Exercises.Where(e => e.Prescription.ID == id).ToList();
        }

        public IEnumerable<Exercise> GetPrivateExercises(int ID)
        {
            return Context.Exercises.Where(e => e.Prescription.ID == ID && e.IsVisible == false).ToList();
        }
    }
}