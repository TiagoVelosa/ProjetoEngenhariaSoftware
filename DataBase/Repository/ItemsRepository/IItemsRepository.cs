using System.Collections.Generic;
using DataBase.Modules;

namespace ClassLibraryEngSoft.Repository.ItemsRepository
{
    public interface IItemsRepository : IRepository<Item>
    {
        IEnumerable<Item> GetItensByPrescription(int id);
    }
}