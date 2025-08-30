using FinCore.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore.Storage;
using System.Linq.Expressions;

namespace FinCore.Core.Domain.Interfaces
{
    public interface ITransactionRepository : IGenericRepository<Transaction>
    {
        Task<Transaction> GetByIdAsync(int transactionId);
        Task<IEnumerable<Transaction>> GetAllAsync();
        Task<IEnumerable<Transaction>> GetByConditionAsync(Expression<Func<Transaction, bool>> expression);
        Task<IEnumerable<Transaction>> GetByCashierId(string cashierId, DateTime? today);
        Task<IDbContextTransaction> BeginTransactionAsync();
        Task<List<Transaction>> GetByConditionAsyncForFinCorePay(Expression<Func<Transaction, bool>> predicate);

    }
}