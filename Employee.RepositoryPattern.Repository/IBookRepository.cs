using Employee.RepositoryPattern.Model;
using System.Collections.Generic;
using Employee.RepositoryPattern.Repository.Base;

namespace Employee.RepositoryPattern.Repository
{
    public interface IBookRepository : IRepository<Book>
    {
        IEnumerable<Book> GetBooks();
        IEnumerable<Book> GetBooksByCurrentYear();
    }
}