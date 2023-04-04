using AutoMapper;
using CarWorkshop.Application.CarWorkshop;
using CarWorkshop.Domain.Entities;

namespace CarWorkshop.Application.Mappings;

public class CarWorkshopMappingProfile : Profile
{
    public CarWorkshopMappingProfile()
    {
        CreateMap<CarWorkshopDto, Domain.Entities.CarWorkshop>()
            .ForMember(c => c.ContactDetails, config => config.MapFrom(dto => new CarWorkshopContactDetails()
            {
                City = dto.City,
                PhoneNumber = dto.PhoneNumber,
                PostalCode = dto.PostalCode,
                Street = dto.Street
            }));
    }
}