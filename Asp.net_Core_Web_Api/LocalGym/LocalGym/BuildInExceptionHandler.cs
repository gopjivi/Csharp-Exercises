
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.Net;
using Microsoft.Extensions.Logging;

namespace LocalGym
{
    public static class BuildInExceptionHandler
    {
        public static void AddErrorHandler(this IApplicationBuilder app)
        {
            app.UseExceptionHandler(appError =>
            {
                appError.Run(async context =>
                {
                    context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                    context.Response.ContentType = "application/json";
                    var contextFeature = context.Features.Get<IExceptionHandlerFeature>();
                    if (contextFeature != null)
                    {
                        await context.Response.WriteAsync(JsonConvert.SerializeObject(new
                        {
                            StatusCode = context.Response.StatusCode,
                            Message = "Something Went Wrong"
                        }));
                    }

                });
            });

        }
    }
}
