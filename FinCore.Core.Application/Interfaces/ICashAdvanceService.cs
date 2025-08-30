using FinCore.Core.Application.DTOs.CashAdvance;
using FinCore.Core.Application.ViewModels.CashAdvance;

namespace FinCore.Core.Application.Interfaces
{
    public interface ICashAdvanceService
    {
        Task<CashAdvanceViewModel> ProcessCashAdvanceAsync(CashAdvanceDTO dto);
    }
}