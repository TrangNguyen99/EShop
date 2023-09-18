using ErrorOr;
using EShop.Api.Controllers;
using EShop.Api.Mappings;

namespace EShop.Api;

public static class DependencyInjection
{
    public static IServiceCollection AddPresentation(this IServiceCollection services)
    {
        services.AddProblemDetails(options =>
        {
            options.CustomizeProblemDetails = context =>
            {
                context.ProblemDetails.Extensions.Remove("exception");

                var error = context.HttpContext.Items[ApiController.HTTP_CONTEXT_ITEMS_ERROR] as Error?;
                if (error is not null)
                {
                    context.ProblemDetails.Extensions.Add("errorCode", error.Value.Code);
                }
            };
        });

        services.AddControllers();

        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();

        services.AddMappings();

        return services;
    }
}
