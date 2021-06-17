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
        public IEnumerable<Prescription> GetPrescriptionsByName(string name)
        {
            if (Context.Prescricoes != null)
            {
                if (Context.Prescricoes.Include(e => e.Client).Where(e => e.Client.name == name) != null)
                {
                    return Context.Prescricoes.Include(e => e.Client).Where(e => e.Client.name == name).ToList();
                }

            }
            return null;
        }

        /*public IEnumerable<Item> GetPrescriptionItems(Prescription prescription)
        {
            return Context.Prescricoes.Where(e => e.ID == prescription.ID).Include(e => e.Items).ToList();
        }*/
    }
}