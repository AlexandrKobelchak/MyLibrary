using MyLibrary.Entities;
using Microsoft.EntityFrameworkCore;

namespace MyLibrary.Repositories
{
    public class BookRepository : DbRepository<Book>, IBookRepository
    {
        public BookRepository(DbContext context) : base(context)
        {
        }
    }
}
