using AutoMapper;
using FinCore.Core.Domain.Entities;
using FinCore.Core.Application.DTOs.SavingsAccount;

namespace FinCore.Core.Application.Mappings.DTOsAndViewModels
{
    public class SavingsAccountEntityToDTOMappingProfile : Profile
    {
        public SavingsAccountEntityToDTOMappingProfile()
        {
            CreateMap<SavingsAccount, SavingsAccountDTO>().ReverseMap();
        }
    }
}