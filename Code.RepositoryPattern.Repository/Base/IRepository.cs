using System.Collections.Generic;

namespace Employee.RepositoryPattern.Repository.Base
{
    public interface IRepository<TModel> where TModel : class
    {
        TModel Get(int id);
        IEnumerable<TModel> GetAll();
        void Add(TModel entity);
        void Remove(TModel entity);
    }   
}