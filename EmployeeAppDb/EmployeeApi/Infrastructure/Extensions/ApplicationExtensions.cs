using Entities.Exceptions;
using Microsoft.AspNetCore.Diagnostics;

namespace EmployeeApi.Infrastructure.Extensions;


public static class ApplicationExtensions
{
    public static void ConfigureExceptionHandler(this IApplicationBuilder app)
    {
        app.UseExceptionHandler(appError =>
        {
            appError.Run(async context =>
            {
                context.Response.ContentType = "application/json";

                var contextFeature =
                    context.Features.Get<IExceptionHandlerFeature>();

                if (contextFeature is not null)
                {
                    // Hata var contextFeature referans aldi ve null degil
                    context.Response.StatusCode = StatusCodes.Status500InternalServerError;
                    await context.Response.WriteAsync(new ErrorDetails()
                    {
                        StatusCode = context.Response.StatusCode,
                        Message = "Bir seyler ters gitti, üzgünüm;"
                    }.ToString());
                }
            });
        });
    }
}