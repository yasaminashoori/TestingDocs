
using Microsoft.EntityFrameworkCore;
using ProductShop.Domain;
using ProductShop.Repository;

namespace ProductShop
{
    public class Program
    {



        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            //connection string 
            builder.Services.AddDbContext<ShopDbContext>(option => option.UseSqlServer("Data Source =. ; Initial Catalog = validationDb; TrustServerCertificate=true; Trusted_Connection=True"));
            // Add services to the container.

            builder.Services.AddScoped<IProductRepository, ProductRepository>();
            builder.Services.AddScoped<IProductCategoryRepository, ProductCategoryRepository>();

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

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
        }
    }
}
