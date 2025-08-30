using FinCore.Core.Domain.Entities;

namespace FinCore.Core.Domain.Interfaces
{
    public interface IBeneficiaryRepository : IGenericRepository<Beneficiary>
    {
        Task<List<Beneficiary>> GetBeneficiariesByClientIdAsync(string clientId);
    }
}