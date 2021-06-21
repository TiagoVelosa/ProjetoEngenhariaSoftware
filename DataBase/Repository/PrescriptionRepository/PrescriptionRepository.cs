using System.Collections.Generic;
using System.Linq;
using DataBase.Modules;
using Microsoft.EntityFrameworkCore;

namespace ClassLibraryEngSoft.Repository
{
    public class PrescriptionRepository : Repository<Prescription>, IPrescriptionRepository
    {

        public PrescriptionRepository(DBContext context) : base(context)
        {
        }
        public IEnumerable<Prescription> GetPrescriptionsByName(Client client)
        {
            return Context.Prescricoes.Where(e => e.Client == client).ToList();
        }

        public IEnumerable<Prescription> GetPrescriptionsByClientName(string name)
        {
            return Context.Prescricoes.Where(e => e.Client.name == name).ToList();
        }

        public Prescription GetPrescriptionByTitleWithDoctor(string title)
        {
            return Context.Prescricoes.Include(e => e.Items).Include(e => e.Doctor).FirstOrDefault(e => e.title == title);
        }


        public Prescription GetPrescriptionByID(int id)
        {
            return Context.Prescricoes.FirstOrDefault(e => e.ID == id);
        }

        public IEnumerable<Prescription> GetPrescriptionsByDoctor(Doctor doctor)
        {
            return Context.Prescricoes.Where(e => e.Doctor == doctor).ToList();
        }

        public Prescription GetPrescriptionByTitle(string title)
        {
            return Context.Prescricoes.Include(e=>e.Items).FirstOrDefault(e => e.title == title);
        }


        /*public IEnumerable<Item> GetPrescriptionItems(Prescription prescription)
        {
            return Context.Prescricoes.Where(e => e.ID == prescription.ID).Include(e => e.Items).ToList();
        }*/

        
    }
}