using KatalogApp.Domain.Commond;

namespace KatalogApp.Application.Common.Abstractions.Repositories
{
    public interface IWriteRepository<T> where T : BaseEntity, new()
    {
        Task<T> AddAsync(T entity, CancellationToken cancellationToken = default);
        Task AddRangeAsync(List<T> entities);
        void UpdateRange(List<T> entities, CancellationToken cancellationToken = default);
        Task<T> UpdateAsync(T entity, CancellationToken cancellationToken = default);
        Task<T> DeleteAsync(T entity);
        Task HardDeleteRangeAsync(IList<T> entity);
    }
}



