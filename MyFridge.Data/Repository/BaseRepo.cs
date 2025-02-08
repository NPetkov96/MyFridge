using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using MyFridge.Data.Repository.Interfaces;

namespace MyFridge.Data.Repository
{
    public class BaseRepo<TType, TId> : IRepository<TType, TId> where TType : class
    {
        private readonly ApplicationDbContext dbContext;
        private readonly DbSet<TType> dbSet;

        public BaseRepo(ApplicationDbContext context)
        {
            this.dbContext = context;
            this.dbSet = this.dbContext.Set<TType>();
        }

        public async Task AddAsync(TType item)
        {
            await this.dbSet.AddAsync(item);
            await this.dbContext.SaveChangesAsync();
        }

        public async Task<bool> DeleteAsync(TType entity)
        {
            this.dbSet.Remove(entity);
            await this.dbContext.SaveChangesAsync();

            return true;
        }

        public async Task<TType> FirstOrDefaultAsync(Expression<Func<TType, bool>> predicate)
        {
            TType? entity = await this.dbSet.FirstOrDefaultAsync(predicate);

            return entity!;
        }

        public async Task<IEnumerable<TType>> GetAllAsync()
        {
            return await this.dbSet.ToListAsync();

        }

        public IQueryable<TType> GetAllAttached()
        {
            return this.dbSet.AsQueryable();
        }

        public async Task<TType> GetByIdAsync(TId id)
        {

            TType? entity = await this.dbSet.FindAsync(id);

            return entity!;
        }

        public async Task<bool> UpdateAsync(TType item)
        {
            try
            {
                if (dbContext.Entry(item).State == EntityState.Detached)
                {
                    dbSet.Attach(item);
                }
                dbContext.Entry(item).State = EntityState.Modified;
                await dbContext.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error updating entity: {ex.Message}");
            }
        }
    }
}
