using System.Collections.Generic;
using System.Linq;
using DataBase.Modules;

namespace ClassLibraryEngSoft.Repository
{
    public class TreatmentsRepository : Repository<Treatment>, ITreatmentsRepository
    {
        public TreatmentsRepository(DBContext context) : base(context)
        {

        }


        public IEnumerable<Treatment> GetTreatmentsByPrescription(int id)
        {
            return Context.Treatments.Where(e => e.Prescription.ID == id).ToList();
        }
    }
}