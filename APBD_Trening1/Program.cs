using APBD_Trening1.Data;
using Microsoft.EntityFrameworkCore;

namespace APBD_Trening1;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        
        builder.Services.AddOpenApi();
        builder.Services.AddControllers();
        builder.Services.AddDbContext<AppDbContext>(options =>
        {
            options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
        });

        var app = builder.Build();
        
        if (app.Environment.IsDevelopment())
        {
            app.MapOpenApi();
            app.UseSwaggerUI(opt => 
            {
                opt.SwaggerEndpoint("/openapi/v1.json", "CodeFirst");
            });
        }

        app.UseHttpsRedirection();

        app.UseAuthorization();

        app.Run();
    }
}