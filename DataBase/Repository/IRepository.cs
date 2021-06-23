﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace ClassLibraryEngSoft.Repository
{
    public interface IRepository<Entity> where Entity : class
    {

        IEnumerable<Entity> GetAll();
        Entity Get(int id);

        void Add(Entity entity);

        void Remove(Entity entity);

        void Update(Entity entity);


    }
}