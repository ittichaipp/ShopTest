using Microsoft.EntityFrameworkCore;
using ShopTest1.Repository.IRepository;
using System.Linq.Expressions;

namespace ShopTest1.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private ProductContext context;

        public Repository(ProductContext context)
        {
            this.context = context;
        }

        public async Task CreateAsync(T entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            await context.AddAsync(entity);
            await SaveAsync();

        }
        public T CreateAndReadAsync(T entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            //var t = await context.AddAsync(entity);
            context.Add(entity);
            //context.Entry(entity).GetDatabaseValues();
            context.SaveChanges();
            return entity;

        }
        public async Task CreateRangeAsync(List<T> entitys)
        {
            if (entitys == null && (entitys != null && entitys.Count() > 0))
                throw new ArgumentNullException(nameof(entitys));

            await context.AddRangeAsync(entitys);

        }

        public async Task<List<T>> ReadAllAsync()
        {
            return await context.Set<T>().ToListAsync();
        }

        public async Task<List<T>> ReadAllAsync(Expression<Func<T, bool>> filter)
        {
            return await context.Set<T>().Where(filter).ToListAsync();
        }

        public async Task<(List<T>, int)> ReadAllFilterAsync(int skip, int take)
        {
            var all = context.Set<T>();
            var relevant = await all.Skip(skip).Take(take).ToListAsync();
            var total = all.Count();

            (List<T>, int) result = (relevant, total);

            return result;
        }

        public async Task<T> ReadAsync(int id)
        {
            return await context.Set<T>().FindAsync(id);
        }

        public async Task UpdateAsync(T entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            context.Set<T>().Update(entity);
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await context.Set<T>().FindAsync(id);
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            context.Set<T>().Remove(entity);
        }

        public async Task SaveChangeAsync()
        {
            try
            {
                await context.SaveChangesAsync();
                context.Dispose();
            }
            catch (Exception)
            {
                context.Dispose();
            }
        }
        public async Task SaveAsync()
        {
            try
            {
                await context.SaveChangesAsync();
                context.Dispose();
            }
            catch (Exception)
            {
                context.Dispose();
            }
        }
    }
}
