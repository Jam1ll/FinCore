using FinCore.Core.Application.Interfaces;
using FinCore.Infrastructure.Persistence.Contexts;
using Microsoft.EntityFrameworkCore.Storage;

namespace FinCore.Infrastructure.Persistence
{

    public class UnitOfWork : IUnitOfWork
    {
        private readonly FinCoreContext _dbContext;
        private IDbContextTransaction _currentTransaction;

        public UnitOfWork(FinCoreContext dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }

        public IDisposable BeginTransaction()
        {
            if (_currentTransaction != null)
            {
                throw new InvalidOperationException("Ya hay una transacción en progreso.");
            }
            _currentTransaction = _dbContext.Database.BeginTransaction();
            return _currentTransaction;
        }

        public async Task CommitAsync()
        {
            if (_currentTransaction == null)
            {
                throw new InvalidOperationException("No hay una transacción en progreso para confirmar.");
            }

            try
            {
                await _dbContext.SaveChangesAsync();
                _currentTransaction.Commit();
            }
            catch
            {
                _currentTransaction.Rollback();
                throw;
            }
            finally
            {
                _currentTransaction.Dispose();
                _currentTransaction = null;
            }
        }

        public async Task RollbackAsync()
        {
            if (_currentTransaction == null)
            {
                throw new InvalidOperationException("No hay una transacción en progreso para revertir.");
            }

            try
            {
                _currentTransaction.Rollback();
            }
            finally
            {
                _currentTransaction.Dispose();
                _currentTransaction = null;
            }
        }

        public async Task<int> SaveChangesAsync()
        {
            return await _dbContext.SaveChangesAsync();
        }

        public void Dispose()
        {
            _dbContext.Dispose();
        }
    }
}