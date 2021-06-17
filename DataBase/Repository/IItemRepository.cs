using System.Collections.Generic;
using DataBase.Modules;

namespace ClassLibraryEngSoft.Repository
{
    public interface IItemRepository : IRepository<Item>
    {
        IEnumerable<Item> GetItemsByPrescription(Prescription prescription);

    }
}