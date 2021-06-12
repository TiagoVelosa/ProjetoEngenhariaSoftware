using System.Collections.Generic;
using System.Linq;
using DataBase.Modules;

namespace ClassLibraryEngSoft.Repository
{
    public class Repository<Entity> : IRepository<Entity> where Entity : class
    {
        protected readonly DBContext Context;

        public Repository(DBContext context)
        {
            Context = context;
        }
        public IEnumerable<Entity> GetAll()
        {
            return Context.Set<Entity>().ToList();
        }

        public Entity Get(int id)
        {
            return Context.Set<Entity>().Find(id);
        }

        public void Add(Entity entity)
        {
            Context.Set<Entity>().Add(entity);
        }

        public void Remove(Entity entity)
        {
            Context.Set<Entity>().Remove(entity);
        }


    }
}