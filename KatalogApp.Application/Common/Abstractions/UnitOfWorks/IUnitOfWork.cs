using KatalogApp.Application.Common.Abstractions.Repositories;
using KatalogApp.Domain.Commond;

namespace KatalogApp.Application.Common.Abstractions.UnitOfWorks
{
    public interface IUnitOfWork : IAsyncDisposable
    {
        IReadRepository<T> GetReadRepository<T>() where T : BaseEntity, new();
        IWriteRepository<T> GetWriteRepository<T>() where T : BaseEntity, new();
        Task OpenTransactionAsync(CancellationToken cancellationToken);
        Task<int> SaveAsync(CancellationToken cancellationToken = default);
        Task CommitAsync(CancellationToken cancellationToken = default);
        Task RollBackAsync(CancellationToken cancellationToken = default);
    }
}



