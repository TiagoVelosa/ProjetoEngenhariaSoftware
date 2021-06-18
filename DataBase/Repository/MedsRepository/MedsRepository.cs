using System.Collections.Generic;
using System.Linq;
using DataBase.Modules;

namespace ClassLibraryEngSoft.Repository
{
    public class MedsRepository : Repository<Medicamento> , IMedsInterface
    {
        public MedsRepository(DBContext context) : base(context)
        {

        }

        public IEnumerable<Medicamento> GetMedsByPrescription(int ID)
        {
            return Context.Meds.Where(e => e.Prescription.ID == ID).ToList();
        }
    }
}