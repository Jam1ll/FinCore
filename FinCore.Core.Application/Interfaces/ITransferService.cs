using FinCore.Core.Application.DTOs.Transfer;
using FinCore.Core.Application.ViewModels.Transfer;

namespace FinCore.Core.Application.Interfaces
{
    public interface ITransferService
    {
        Task<TransferViewModel> ProcessTransferAsync(TransferDTO dto);
    }
}