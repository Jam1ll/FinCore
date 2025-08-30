using FinCore.Core.Domain.Entities;
using FinCore.Core.Domain.Interfaces;
using FinCore.Infrastructure.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;

namespace FinCore.Infrastructure.Persistence.Repositories
{
    public class SavingsAccountRepository : GenericRepository<SavingsAccount>, ISavingsAccountRepository
    {
        private readonly FinCoreContext _context;
        public SavingsAccountRepository(FinCoreContext context) : base(context)
        {
            _context = context;
        }
        public async Task<SavingsAccount?> GetByAccountNumberAsync(string accountNumber)
        {
            return await _context.SavingsAccount
                .FirstOrDefaultAsync(sa => sa.AccountNumber == accountNumber);
        }

        public async Task<IEnumerable<SavingsAccount>> GetAccountsByClientIdAsync(string clientId)
        {
            return await _context.SavingsAccount
                .Where(account => account.ClientId == clientId)
                .ToListAsync();
        }
    }
}