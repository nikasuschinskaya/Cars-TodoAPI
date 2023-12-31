﻿namespace Cars.WebAPI.Repositories.Base
{
    public interface IRepository<T>
    {
        void Create(T entity);
        void Update(T entity);
        void Delete(int id);
        T GetById(int id);
        IEnumerable<T> GetAll();
    }
}
