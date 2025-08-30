using FinCore.Core.Domain.Entities;

namespace FinCore.Core.Domain.Interfaces
{
    public interface ILoanRepository : IGenericRepository<Loan>
    {
        Task<Loan?> GetLoanByIdentifierAsync(string loanIdentifier);
        Task<Loan?> GetLoanByIdAsync(int loanId);
    }
}
