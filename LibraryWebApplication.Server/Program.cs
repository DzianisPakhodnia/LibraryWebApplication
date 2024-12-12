using LibraryWebApplication.Application.Interfaces;
using LibraryWebApplication.Application.Services;
using LibraryWebApplication.Core.Interfaces.Services;
using LibraryWebApplication.Core.Repositories;
using LibraryWebApplication.Infrastructure.Data;
using LibraryWebApplication.Infrastructure.Mapper;
using LibraryWebApplication.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


//db connect
builder.Services.AddDbContext<ApplicationDbContext>(
                o => o.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));


builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IAuthorService, AuthorService>();
builder.Services.AddScoped<IBookService, BookService>();



builder.Services.AddScoped<IMapperClass, Mapper>();
builder.Services.AddAutoMapper(typeof(UserMappingProfile));
builder.Services.AddAutoMapper(typeof(AuthorMappingProfile));
builder.Services.AddAutoMapper(typeof(BookMappingProfile));

var app = builder.Build();

app.UseDefaultFiles();
app.UseStaticFiles();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MapFallbackToFile("/index.html");

app.Run();
