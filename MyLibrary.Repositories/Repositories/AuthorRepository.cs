using Microsoft.EntityFrameworkCore;
using MyLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary.Repositories
{
    public class AuthorRepository : DbRepository<Author>, IAuthorRepository
    {
        public AuthorRepository(DbContext context) : base(context)
        {
        }
    }
}
