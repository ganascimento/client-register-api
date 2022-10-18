using Client.Register.Domain.Entity;

namespace Client.Register.Domain.Repository;

public interface IRepository<T> where T : BaseEntity
{
    Task<T?> SelectAsync(int id);
    Task<IEnumerable<T>> SelectAsync();
    Task<T> InsertAsync(T item);
    Task<T?> UpdateAsync(T item);
    Task<bool> DeleteAsync(int id);
}