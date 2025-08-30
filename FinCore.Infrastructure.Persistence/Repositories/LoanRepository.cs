using FinCore.Core.Domain.Entities;
using FinCore.Core.Domain.Interfaces;
using FinCore.Infrastructure.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;

namespace FinCore.Infrastructure.Persistence.Repositories
{
    public class LoanRepository : GenericRepository<Loan>, ILoanRepository
    {
        public LoanRepository(FinCoreContext context) : base(context)
        {
        }

        public async Task<Loan?> GetLoanByIdentifierAsync(string loanIdentifier)
        {
            return await _context.Loans
                .FirstOrDefaultAsync(l => l.LoanIdentifier == loanIdentifier);  // Busca el préstamo por su identificador
        }

        public async Task<Loan?> GetLoanByIdAsync(int loanId)
        {
            return await _context.Loans
                .FirstOrDefaultAsync(l => l.Id == loanId);  // Busca el préstamo por su ID
        }
    }
}
