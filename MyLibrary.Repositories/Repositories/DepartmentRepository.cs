using MyLibrary.Entities;
using Microsoft.EntityFrameworkCore;

namespace MyLibrary.Repositories
{
    public class DepartmentRepository : DbRepository<Department>, IDepartmentRepository
    {
        public DepartmentRepository(DbContext context) : base(context)
        {
        }
    }
}
