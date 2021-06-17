using System.Collections.Generic;
using System.Linq;
using DataBase.Modules;

namespace ClassLibraryEngSoft.Repository
{
    public class ItemRepository : Repository<Item> , IItemRepository
    {
        public ItemRepository(DBContext context) : base(context)
        {

        }

        public IEnumerable<Item> GetItemsByPrescription(Prescription prescription)
        {
            return Context.Items.Where(e => e.Prescription.ID == prescription.ID).ToList();
        }
    }
}