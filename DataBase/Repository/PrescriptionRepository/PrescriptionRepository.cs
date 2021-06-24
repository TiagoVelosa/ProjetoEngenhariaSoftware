using System.Collections.Generic;
using System.Linq;
using DataBase.Modules;
using Microsoft.EntityFrameworkCore;

namespace ClassLibraryEngSoft.Repository
{
    public class PrescriptionRepository : Repository<Prescription>, IPrescriptionRepository
    {

        public PrescriptionRepository(PrescriptionContext context) : base(context)
        {
        }
        public IEnumerable<Prescription> GetPrescriptionsByName(Client client)
        {
            return PrescriptionContext.Prescricoes.Where(e => e.Client == client).ToList();
        }

        public IEnumerable<Prescription> GetPrescriptionsByClientName(string name)
        {
            return PrescriptionContext.Prescricoes.Where(e => e.Client.name == name).ToList();
        }

        public Prescription GetPrescriptionByTitleWithDoctor(string title)
        {
            return PrescriptionContext.Prescricoes.Include(e => e.Items).Include(e => e.Doctor).FirstOrDefault(e => e.title == title);
        }

        public IEnumerable<Prescription> GetPrescriptionsByDoctor(Doctor doctor)
        {
            return PrescriptionContext.Prescricoes.Where(e => e.Doctor == doctor).ToList();
        }
        public IEnumerable<Prescription> GetPrescriptionsExceptDoctor(Doctor doctor)
        {
            return PrescriptionContext.Prescricoes.Where(e => e.Doctor != doctor).Include(e=>e.Client).ToList();
        }

        public Prescription GetPrescriptionByTitle(string title)
        {
            return PrescriptionContext.Prescricoes.Include(e=>e.Items).FirstOrDefault(e => e.title == title);
        }


        public PrescriptionContext PrescriptionContext
        {
            get { return Context as PrescriptionContext; }
        }

    }
}