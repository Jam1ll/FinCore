using AutoMapper;
using FinCore.Core.Application.DTOs.Transfer;
using FinCore.Core.Application.ViewModels.Transfer;

namespace FinCore.Core.Application.Mappings.DTOsAndViewModels
{
    public class TransferDTOMappingProfile : Profile
    {
        public TransferDTOMappingProfile()
        {
            CreateMap<TransferViewModel, TransferDTO>().ReverseMap();
        }
    }
}
