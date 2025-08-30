using FinCore.Core.Application.DTOs.HermesPay;
using System.Security.Claims;

namespace FinCore.Core.Application.Interfaces
{
    public interface IFinCorePayService
    {
        Task<HermesPayResponse> ProccesFinCorePay(HermesPayRequest request, ClaimsPrincipal user);

    }
}