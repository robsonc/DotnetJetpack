namespace DotnetJetpack.Core.Contracts.Infrastructure;

public interface IUnitOfWork
{
    Task<int> SaveChangesAsync();
    Task BeginTransactionAsync();
    Task CommitAsync();
    Task RollbackAsync();
}