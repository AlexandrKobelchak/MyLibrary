using MyLibrary.Entities;
using Microsoft.EntityFrameworkCore;

namespace MyLibrary.Repositories
{
    public class CategoryRepository : DbRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(DbContext context) : base(context)
        {
        }
    }
}
