using Leduca.API.DbModels;
using Leduca.API.Services;
using Mapster;
using Microsoft.EntityFrameworkCore;

namespace Leduca.API.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static WebApplicationBuilder AddRequiredServices(this WebApplicationBuilder builder)
        {
            // add defaults do Mapster
            TypeAdapterConfig.GlobalSettings.Default.PreserveReference(true);

            builder.Services.AddScoped<IBookService, BookService>();


            builder.Services.AddDbContext<LeducaContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("Leduca")));

            return builder;
        }
    }
}
