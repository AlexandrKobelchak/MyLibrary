using MyLibrary.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MyLibrary.Repositories
{
    public class DbRepository<T> : IDbRepository<T>
        where T : class, IDbEntity
    {
        DbContext _context;

        public DbRepository(DbContext context)
        {
            _context = context;
        }

        public IQueryable<T> AllItems => _context.Set<T>();

        public DbContext Context => _context;

        public async Task<int> AddItemAsync(T item)
        {
            await _context.Set<T>().AddAsync(item);
            return await SaveChangesAsync();
        }

        public async Task<int> AddItemsAsync(IEnumerable<T> items)
        {
            await _context.Set<T>().AddRangeAsync(items);
            return await SaveChangesAsync();
        }

        public async Task<bool> ChangeItemAsync(T item)
        {
            T chenged = await GetItemAsync(item.Id);
            if (chenged == null) return false;
            chenged = item;
            return await SaveChangesAsync() > 0;
        }

        public async Task<bool> DeleteItemAsync(Guid id)
        {
            T item = await _context.Set<T>().FindAsync(id);
            if (item == null) return false;
            _context.Set<T>().Remove(item);
            return await SaveChangesAsync() > 0;
        }

        public async Task<T> GetItemAsync(Guid id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public async Task<int> SaveChangesAsync()
        {
            try
            {
                return await _context.SaveChangesAsync();
            }

#pragma warning disable CS0168 // Variable is declared but never used
            catch (Exception e)
#pragma warning restore CS0168 // Variable is declared but never used
            {
                return -1;
            }
        }

        public async Task<List<T>> ToListAsync()
        {
            return await _context.Set<T>().ToListAsync<T>();
        }

        public async Task<bool> UpdateItemAsync(T item)
        {
            _context.Set<T>().Update(item);
            return await SaveChangesAsync() > 0;
        }
    }
}
