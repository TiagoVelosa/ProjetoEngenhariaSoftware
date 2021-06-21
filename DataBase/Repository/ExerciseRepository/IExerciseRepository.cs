using System.Collections.Generic;
using DataBase.Modules;

namespace ClassLibraryEngSoft.Repository
{
    public interface IExerciseRepository : IRepository<Exercise>
    {
        IEnumerable<Exercise> GetExercisesByPrescription(int id);

        IEnumerable<Exercise> GetPrivateExercises(int ID);

        Exercise GetExerciseByName(string name, string title);
    }
}