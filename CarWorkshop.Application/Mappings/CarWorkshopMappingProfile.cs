using AutoMapper;
using CarWorkshop.Application.CarWorkshop;
using CarWorkshop.Application.CarWorkshop.Commands.EditCarWorkshop;
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

        CreateMap<Domain.Entities.CarWorkshop, CarWorkshopDto>()
            .ForMember(dto => dto.Street, config => config.MapFrom(c => c.ContactDetails.Street))
            .ForMember(dto => dto.City, config => config.MapFrom(c => c.ContactDetails.City))
            .ForMember(dto => dto.PostalCode, config => config.MapFrom(c => c.ContactDetails.PostalCode))
            .ForMember(dto => dto.PhoneNumber, config => config.MapFrom(c => c.ContactDetails.PhoneNumber));

        CreateMap<CarWorkshopDto, EditCarWorkshopCommand>();
    }
}