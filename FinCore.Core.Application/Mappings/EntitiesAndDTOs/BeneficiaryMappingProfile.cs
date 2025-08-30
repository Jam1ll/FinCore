using AutoMapper;
using FinCore.Core.Application.DTOs.Beneficiary;
using FinCore.Core.Domain.Entities;

namespace FinCore.Core.Application.Mappings.EntitiesAndDTOs
{
    public class BeneficiaryMappingProfile : Profile
    {
        public BeneficiaryMappingProfile()
        {
            CreateMap<Beneficiary, BeneficiaryDTO>().ReverseMap();
        }
    }
}