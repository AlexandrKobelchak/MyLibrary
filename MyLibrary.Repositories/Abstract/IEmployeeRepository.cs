using MyLibrary.Domain;
using MyLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary.Repositories
{
    public interface IEmployeeRepository : IDbRepository<Employee>
    {
    }
}
