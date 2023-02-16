﻿using System.Collections.Generic;

namespace Cache_api.Models.Repository
{
    public interface IDataRepository<T>
    {
        IEnumerable<T> GetAll();
        T Get(long id);
        void Add(T entity);
        void Update(T dbEntity, T entity);
        void Delete(T entity);
    }
}
