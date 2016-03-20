using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Http;

namespace App00
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app)
        {
            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello Shaun and Anthony!");
            });
        }
    }
}
