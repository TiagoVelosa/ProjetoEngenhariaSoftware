using System.Collections.Generic;
using System.Linq;
using DataBase.Modules;

namespace ClassLibraryEngSoft.Repository.ItemsRepository
{
    public class ItemsRepository : Repository<Item>, IItemsRepository
    {
        public ItemsRepository(PrescriptionContext context) : base(context)
        {

        }


        public IEnumerable<Item> GetItensByPrescription(int id)
        {
            return PrescriptionContext.Items.Where(e => e.Prescription.ID == id).ToList();
        }

        public PrescriptionContext PrescriptionContext
        {
            get { return Context as PrescriptionContext; }
        }
    }
}