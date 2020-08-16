using MyLibrary.Entities;
using Microsoft.EntityFrameworkCore;

namespace MyLibrary.Repositories
{
    public class ThemeRepository : DbRepository<Theme>, IThemeRepository
    {
        public ThemeRepository(DbContext context) : base(context)
        {
        }
    }
}
