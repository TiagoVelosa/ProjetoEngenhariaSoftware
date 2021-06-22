using System.Collections.Generic;
using System.Linq;
using DataBase.Modules;

namespace ClassLibraryEngSoft.Repository
{
    public class MedsRepository : Repository<Medicamento> , IMedsInterface
    {
        public MedsRepository(PrescriptionContext context) : base(context)
        {

        }

        public IEnumerable<Medicamento> GetMedsByPrescription(int ID)
        {
            return PrescriptionContext.Meds.Where(e => e.Prescription.ID == ID).ToList();
        }

        public IEnumerable<Medicamento> GetPrivateMeds(int ID)
        {
            return PrescriptionContext.Meds.Where(e => e.Prescription.ID == ID && e.IsVisible == false).ToList();
        }

        public Medicamento GetMedByName(string name, string title)
        {
            return PrescriptionContext.Meds.FirstOrDefault(e => e.Name == name && e.Prescription.title == title);
        }

        public PrescriptionContext PrescriptionContext
        {
            get { return Context as PrescriptionContext; }
        }
    }
}