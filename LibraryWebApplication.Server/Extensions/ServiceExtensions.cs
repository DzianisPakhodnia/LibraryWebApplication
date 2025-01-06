using LibraryWebApplication.Application.Interfaces;
using LibraryWebApplication.Application.Services;
using LibraryWebApplication.Core.Interfaces.Services;
using LibraryWebApplication.Core.Repositories;
using LibraryWebApplication.Infrastructure.Data;
using LibraryWebApplication.Infrastructure.Mapper;
using LibraryWebApplication.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

public static class ServiceExtensions
{
    public static void ConfigureServices(this IServiceCollection services, IConfiguration configuration)
    {

        services.AddControllers();
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();

        // Database configuration
        services.AddDbContext<ApplicationDbContext>(o =>
            o.UseNpgsql(configuration.GetConnectionString("DefaultConnection")));

        // Dependency Injection
        services.AddScoped<IUnitOfWork, UnitOfWork>();
        services.AddScoped<IUserService, UserService>();
        services.AddScoped<IAuthorService, AuthorService>();
        services.AddScoped<IBookService, BookService>();
        services.AddScoped<IMapperClass, Mapper>();

        // AutoMapper profiles
        services.AddAutoMapper(
            typeof(UserMappingProfile),
            typeof(AuthorMappingProfile),
            typeof(BookMappingProfile)
        );

    }
}
