using MyLibrary.Entities;
using Microsoft.EntityFrameworkCore;

namespace MyLibrary.Repositories
{
    public class SCardsRepository : DbRepository<SCard>, ISCardRepository
    {
        public SCardsRepository(DbContext context) : base(context)
        {
        }
    }
}
