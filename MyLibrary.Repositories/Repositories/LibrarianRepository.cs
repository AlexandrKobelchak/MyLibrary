using MyLibrary.Entities;
using Microsoft.EntityFrameworkCore;

namespace MyLibrary.Repositories
{
    public class LibrarianRepository : DbRepository<Librarian>, ILibrarianRepository
    {
        public LibrarianRepository(DbContext context) : base(context)
        {
        }
    }
}
