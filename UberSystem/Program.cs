
using Microsoft.EntityFrameworkCore;
using UberSystem.Data;
using UberSystem.IUnitOfWork.Implementation;
using UberSystem.Repo.GenericRepo.Contract;
using UberSystem.Repo.GenericRepo.Implementaion;

namespace UberSystem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddDbContext<App_Database_Context>(opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("Con")));
            builder.Services.AddScoped(typeof(IGenericRepo<>),typeof(GenericRepo<>));
            builder.Services.AddScoped<IUnitOfWork.Contract.IUnitOfWork, UnitOfWork>();

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
