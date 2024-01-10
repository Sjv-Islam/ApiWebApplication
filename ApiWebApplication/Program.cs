
using System.Text.Json.Serialization;
using ApiWebApplication.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiWebApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers()
                .AddJsonOptions(x =>
                {
                    x.JsonSerializerOptions.ReferenceHandler =
                    ReferenceHandler.IgnoreCycles;
                });
            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            
            string sqlConn = builder.Configuration.GetConnectionString("dataConn");
            builder.Services.AddDbContext<EmpDb>(opt =>
            {
                opt.UseSqlServer(sqlConn);
            });

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
