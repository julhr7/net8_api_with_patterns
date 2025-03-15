using Microsoft.EntityFrameworkCore;

using Infrastructure.Data;
using Infrastructure.Factories;
using Domain.Entities;
using Domain.Repositories;
using Observers;
using Strategies;
using Domain.Interfaces;
using Application.Services;
using Infrastructure.Repositories;
using Infrastructure.UnitOfWork;
using Presentacion.Subjects;
using Application.Queries;

namespace Presentacion
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.



            builder.Services.AddControllers();
            builder.Services.AddDbContext<AppDbContext>(options =>
            options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
                   .UseLazyLoadingProxies()
                   .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking)
                   .UseLazyLoadingProxies()
                   .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking)
                   .UseSqlServer(b => b.MigrationsAssembly("Infrastructure")));




            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle


            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddScoped<IRepository<Product>, ProductRepository>();
            builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
            builder.Services.AddScoped<IProductService, ProductService>();
            builder.Services.AddScoped<IProductFactory, ProductFactory>();
            builder.Services.AddScoped<IDiscountStrategy, NoDiscountStrategy>();
            builder.Services.AddScoped<DiscountContext>();
            builder.Services.AddScoped<ProductSubject>();
            builder.Services.AddScoped<IProductObserver, ProductNotifier>();

            //builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(Program).Assembly));
            builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(GetAllProductsQueryHandler).Assembly));

            var app = builder.Build();

            // Configure the HTTP request pipeline.


            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();

                app.UseDeveloperExceptionPage(); // Developer exception page


            }

            app.UseHttpsRedirection(); // HTTPS redirection


            app.UseAuthorization(); // Authorization


            app.MapControllers(); // Map controllers



            app.Run();
        }
    }
}

// Package to installer
// dotnet add package Microsoft.EntityFrameworkCore
// dotnet add package MediatR
// dotnet add package Microsoft.Extensions.DependencyInjection
// dotnet add package Microsoft.EntityFrameworkCore.SqlServer

// dotnet tool install --global dotnet-ef
// dotnet ef migrations add InitialCreate
// dotnet ef database update
