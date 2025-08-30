using FinCore.Core.Domain.Entities;

namespace FinCore.Core.Domain.Interfaces
{
    public interface ISavingsAccountRepository : IGenericRepository<SavingsAccount>
    {
        Task<SavingsAccount?> GetByAccountNumberAsync(string accountNumber);
        Task<IEnumerable<SavingsAccount>> GetAccountsByClientIdAsync(string clientId);
    }
}