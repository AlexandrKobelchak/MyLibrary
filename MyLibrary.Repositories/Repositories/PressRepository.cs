using MyLibrary.Entities;
using Microsoft.EntityFrameworkCore;

namespace MyLibrary.Repositories
{
    public class PressRepository : DbRepository<Press>, IPressRepository
    {
        public PressRepository(DbContext context) : base(context)
        {
        }
    }
}
