using Basboosify.OrdersMicroservice.BusinessLogicLayer.Mappers;
using Basboosify.OrdersMicroservice.BusinessLogicLayer.Validators;
using FluentValidation;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Basboosify.OrdersMicroservice.BusinessLogicLayer;

public static class DependencyInjection
{
    public static IServiceCollection AddBusinessLogicLayer(this IServiceCollection services, IConfiguration configuration)
    {
        //TODO: Add data access layer services into the IoC container
        services.AddValidatorsFromAssemblyContaining<OrderAddRequestValidator>();

        services.AddAutoMapper(typeof(OrderAddRequestToOrderMappingProfile).Assembly);

        return services;
    }
}