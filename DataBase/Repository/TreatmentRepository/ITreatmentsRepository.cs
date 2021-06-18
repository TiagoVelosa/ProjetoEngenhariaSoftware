using System.Collections.Generic;
using DataBase.Modules;

namespace ClassLibraryEngSoft.Repository
{
    public interface ITreatmentsRepository : IRepository<Treatment>
    {
        IEnumerable<Treatment> GetTreatmentsByPrescription(int id);
    }
}