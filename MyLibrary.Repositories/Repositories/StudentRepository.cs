using MyLibrary.Entities;
using Microsoft.EntityFrameworkCore;

namespace MyLibrary.Repositories
{
    public class StudentRepository : DbRepository<Student>, IStudentRepository
    {
        public StudentRepository(DbContext context) : base(context)
        {
        }
    }
}
