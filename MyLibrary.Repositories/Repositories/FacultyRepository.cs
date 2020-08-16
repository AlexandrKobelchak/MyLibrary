using MyLibrary.Entities;
using Microsoft.EntityFrameworkCore;

namespace MyLibrary.Repositories
{
    public class FacultyRepository : DbRepository<Faculty>, IFacultyRepository
    {
        public FacultyRepository(DbContext context) : base(context)
        {
        }
    }
}
