using System.Linq.Expressions;

namespace ShopTest1.Repository.IRepository
{
    public interface IRepository<T> where T : class
    {
        Task CreateAsync(T entity);
        T CreateAndReadAsync(T entity);
        Task CreateRangeAsync(List<T> entity);
        Task<List<T>> ReadAllAsync();
        Task<List<T>> ReadAllAsync(Expression<Func<T, bool>> filter);
        Task<(List<T>, int)> ReadAllFilterAsync(int skip, int take);
        Task<T> ReadAsync(int id);
        Task DeleteAsync(int id);
        Task UpdateAsync(T entity);
        Task SaveChangeAsync();
    }
}
