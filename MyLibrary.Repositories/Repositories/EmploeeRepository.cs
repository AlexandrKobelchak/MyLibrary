using MyLibrary.Entities;
using Microsoft.EntityFrameworkCore;

namespace MyLibrary.Repositories
{
    public class EmploeeRepository : DbRepository<Employee>, IEmployeeRepository
    {
        public EmploeeRepository(DbContext context) : base(context)
        {
        }
    }
}
