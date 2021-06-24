using System.Collections.Generic;
using System.Linq;
using DataBase.Modules;

namespace ClassLibraryEngSoft.Repository
{
    public class TreatmentsRepository : Repository<Treatment>, ITreatmentsRepository
    {
        public TreatmentsRepository(PrescriptionContext context) : base(context)
        {

        }


        public IEnumerable<Treatment> GetTreatmentsByPrescription(int id)
        {
            return PrescriptionContext.Treatments.Where(e => e.Prescription.ID == id && e.Done == false).ToList();
        }
        public IEnumerable<Treatment> GetTreatmentsPublicsByPrescription(int id)
        {
            return PrescriptionContext.Treatments.Where(e => e.Prescription.ID == id && e.IsVisible==true).ToList();
        }
        public IEnumerable<Treatment> GetPrivateTreatments(int id)
        {
            return PrescriptionContext.Treatments.Where(e => e.Prescription.ID == id && e.IsVisible == false).ToList();
        }

        public Treatment GetTreatmentByName(string name, string title)
        {
            return PrescriptionContext.Treatments.FirstOrDefault(e => e.Prescription.title == title && e.Name == name);
        }
        public Treatment GetTreatmentsBySessionAndName(TherapySession session, string name)
        {
            return PrescriptionContext.Treatments.FirstOrDefault(e => e.Session == session && e.Name == name);
        }
        public IEnumerable<Treatment> GetTreatmentsNotDoneBySession(TherapySession session)
        {
            return PrescriptionContext.Treatments.Where(e => e.Session == session && e.Done == false).ToList();
        }

        public PrescriptionContext PrescriptionContext
        {
            get { return Context as PrescriptionContext; }
        }
    }
}