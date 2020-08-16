using MyLibrary.Domain;
using MyLibrary.Entities;

namespace MyLibrary.Repositories
{
    public interface IStudentRepository : IDbRepository<Student>
    {
    }
}
