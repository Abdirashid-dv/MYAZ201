using Entities.Models;
using Microsoft.AspNetCore.Diagnostics;
using Repositories.Services.Exceptions;

namespace RestaurantApi.Services;


public static class ExceptionMiddlewareHandler
{

    public static void ConfigureExceptionHandler(this IApplicationBuilder app)
    {
        app.UseExceptionHandler(appError =>
        {
            appError.Run(async context =>
            {
                context.Response.ContentType = "application/json";
                var contextFeature = context.Features.Get<IExceptionHandlerFeature>();

                if (contextFeature != null) // hata var demektir
                {
                    context.Response.StatusCode = contextFeature.Error switch
                    {
                        BadRequestException => StatusCodes.Status400BadRequest,
                        NotFoundException => StatusCodes.Status404NotFound,
                        InternalServerException => StatusCodes.Status500InternalServerError,
                    };

                    await context.Response.WriteAsync(new ErrorDetails
                    {
                        StatusCode = context.Response.StatusCode,
                        Message = contextFeature.Error.Message
                    }.ToString());

                }
            });
        });
    }

}