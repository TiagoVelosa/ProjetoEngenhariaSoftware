using System.Collections.Generic;
using System.Linq;
using DataBase.Modules;
using Microsoft.EntityFrameworkCore;

namespace ClassLibraryEngSoft.Repository
{
    public class Repository<Entity> : IRepository<Entity> where Entity : class
    {
        protected readonly DbContext Context;

        public Repository(DbContext context)
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

        public void Update(Entity entity)
        {

           
            Context.Set<Entity>().Update(entity);

        }


    }
}