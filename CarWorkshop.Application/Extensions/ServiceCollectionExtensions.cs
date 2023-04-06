using CarWorkshop.Application.Mappings;
using Microsoft.Extensions.DependencyInjection;
using FluentValidation.AspNetCore;
using FluentValidation;
using CarWorkshop.Application.CarWorkshop.Commands.CreateCarWorkshop;
using MediatR;

namespace CarWorkshop.Application.Extensions;

public static class ServiceCollectionExtensions
{
    public static void AddApplication(this IServiceCollection services)
    {
        services.AddMediatR(typeof(CreateCarWorkshopCommand));

        services.AddAutoMapper(typeof(CarWorkshopMappingProfile));

        services.AddValidatorsFromAssemblyContaining<CreateCarWorkshopCommandValidator>()
               .AddFluentValidationAutoValidation()
               .AddFluentValidationClientsideAdapters();
    }
}