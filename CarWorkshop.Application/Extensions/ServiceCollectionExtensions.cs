using CarWorkshop.Application.Mappings;
using Microsoft.Extensions.DependencyInjection;
using FluentValidation.AspNetCore;
using FluentValidation;
using CarWorkshop.Application.CarWorkshop.Commands.CreateCarWorkshop;
using MediatR;
using CarWorkshop.Application.ApplicationUser;

namespace CarWorkshop.Application.Extensions;

public static class ServiceCollectionExtensions
{
    public static void AddApplication(this IServiceCollection services)
    {
        services.AddScoped<IUserContext, UserContext>();

        services.AddMediatR(typeof(CreateCarWorkshopCommand));

        services.AddAutoMapper(typeof(CarWorkshopMappingProfile));

        services.AddValidatorsFromAssemblyContaining<CreateCarWorkshopCommandValidator>()
               .AddFluentValidationAutoValidation()
               .AddFluentValidationClientsideAdapters();
    }
}