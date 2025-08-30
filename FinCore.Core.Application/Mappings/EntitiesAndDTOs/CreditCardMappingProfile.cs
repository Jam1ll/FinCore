using AutoMapper;
using FinCore.Core.Application.DTOs.CreditCard;
using FinCore.Core.Domain.Entities;

namespace FinCore.Core.Application.Mappings.EntitiesAndDTOs
{
    public class CreditCardMappingProfile : Profile
    {
        public CreditCardMappingProfile()
        {
            CreateMap<CreditCard, CreditCardDTO>().ReverseMap();
        }
    }
}
