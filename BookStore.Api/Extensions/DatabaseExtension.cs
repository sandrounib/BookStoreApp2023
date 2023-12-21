using BookStore.Domain.Interfaces;
using BookStore.Infraestructure.Data;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Api.Extensions
{
    public static class DatabaseExtension
    {
        public static void AddDatabase(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<DataContext>(opt =>
            {
                opt.UseInMemoryDatabase(configuration.GetConnectionString("ConnectionString"));

            });

            services.AddScoped<IBooksRepository, BooksRepository>();
        }
    }
}
