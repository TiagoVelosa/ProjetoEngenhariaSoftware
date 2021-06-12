using System.Collections.Generic;

namespace ClassLibraryEngSoft.Repository
{
    public interface IRepository<Entity> where Entity : class
    {

        IEnumerable<Entity> GetAll();
        Entity Get(int id);

        void Add(Entity entity);

        void Remove(Entity entity);


    }
}