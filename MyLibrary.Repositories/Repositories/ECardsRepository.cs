using MyLibrary.Entities;
using Microsoft.EntityFrameworkCore;

namespace MyLibrary.Repositories
{
    public class ECardsRepository : DbRepository<ECard>, IECardRepository
    {
        public ECardsRepository(DbContext context) : base(context)
        {
        }
    }
}
