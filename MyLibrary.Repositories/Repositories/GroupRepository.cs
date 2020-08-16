using MyLibrary.Entities;
using Microsoft.EntityFrameworkCore;

namespace MyLibrary.Repositories
{
    public class GroupRepository : DbRepository<Group>, IGroupRepository
    {
        public GroupRepository(DbContext context) : base(context)
        {
        }
    }
}
