using FinCore.Core.Application.DTOs.Beneficiary;
using FinCore.Core.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FinCore.Core.Application.Interfaces
{
    public interface IBeneficiaryService : IGenericService<BeneficiaryDTO>
    {
        Task<List<BeneficiaryDTO>> GetBeneficiariesByUserIdAsync(string userId);

        Task<List<BeneficiaryDTO>> GetAllByClientIdAsync(string clientId);
        Task<IEnumerable<Beneficiary>> GetAvailableBeneficiariesAsync(string clientId);
    }
}