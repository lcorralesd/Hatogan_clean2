using Hatogan.FD.UI.WebAPI.Middlewares;
using Microsoft.AspNetCore.Builder;

namespace Hatogan.FD.UI.WebAPI.Extensions
{
    public static class AppExtension
    {
        public static IApplicationBuilder UseExceptionHandlerMiddleware(this IApplicationBuilder app)
        {
            app.UseMiddleware<ErrorHandlerMiddleware>();

            return app;
        }
    }
}
