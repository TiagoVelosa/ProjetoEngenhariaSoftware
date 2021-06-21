using System.Collections.Generic;
using System.Linq;
using DataBase.Modules;

namespace ClassLibraryEngSoft.Repository.ItemsRepository
{
    public class ItemsRepository : Repository<Item>, IItemsRepository
    {
        public ItemsRepository(DBContext context) : base(context)
        {

        }


        public IEnumerable<Item> GetItensByPrescription(int id)
        {
            return Context.Items.Where(e => e.Prescription.ID == id).ToList();
        }
    }
}