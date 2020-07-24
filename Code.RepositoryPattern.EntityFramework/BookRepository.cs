using Employee.RepositoryPattern.Model;
using Employee.RepositoryPattern.Repository;
using Employee.RepositoryPattern.EntityFramework.Abstract;
using Employee.RepositoryPattern.EntityFramework.Context;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Employee.RepositoryPattern.EntityFramework
{
    public class BookRepository : Repository<Book>,IBookRepository
    {
        public ApplicationDatabaseContext ApplicationDatabaseContext
        { 
            get { return DatabaseContext as ApplicationDatabaseContext; }
        }

        public BookRepository(ApplicationDatabaseContext context) :base(context) { }

        public IEnumerable<Book> GetBooks()
        {
            return ApplicationDatabaseContext.Books.ToList();
        }

        public IEnumerable<Book> GetBooksByCurrentYear()
        {
            return ApplicationDatabaseContext.Books.Where(b=>b.Date.Year>=DateTime.Now.Year).ToList();
        }
    }
}
