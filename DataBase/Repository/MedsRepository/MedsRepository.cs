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

        public IEnumerable<Medicamento> GetPrivateMeds(int ID)
        {
            return Context.Meds.Where(e => e.Prescription.ID == ID && e.IsVisible == false).ToList();
        }

        public Medicamento GetMedByName(string name, string title)
        {
            return Context.Meds.FirstOrDefault(e => e.Name == name && e.Prescription.title == title);
        }
    }
}