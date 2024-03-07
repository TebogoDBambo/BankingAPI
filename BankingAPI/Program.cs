using Banking.Application;
using Banking.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

//Register configuration
ConfigurationManager configurationManager = builder.Configuration;
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Add database service
builder.Services.AddDbContext<BankingDbContext>(opt => opt.UseSqlServer(configurationManager.GetConnectionString("DefaultConnection"),
    b => b.MigrationsAssembly("BankingAPI")));
builder.Services.AddScoped<IBankingService, BankingService>();
builder.Services.AddScoped<IBankingRepository, BankingRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
