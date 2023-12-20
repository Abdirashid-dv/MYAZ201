using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Repositories;
using Repositories.Services;
using RestaurantApi.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Enable Swagger/OpenAPI documentation generation.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Add services to the container.
builder.Services.AddScoped<UserRepository>();
builder.Services.AddScoped<ItemRepository>();

// builder.Services.AddSingleton<List<User>>();
// builder.Services.AddSingleton<List<Items>>();

builder.Services.AddDbContext<RepositoryDbContext>(options =>
{
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection"),
           prj => prj.MigrationsAssembly("RestaurantApi"));
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    // Enable Swagger UI for testing and exploring the API endpoints.
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.ConfigureExceptionHandler();

app.UseHttpsRedirection();

app.UseAuthorization();

// Map the API controllers to the request pipeline.
app.MapControllers();

app.Run();
