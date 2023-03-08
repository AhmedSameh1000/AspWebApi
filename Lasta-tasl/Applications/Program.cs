using Microsoft.EntityFrameworkCore;

namespace Applications
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddCors();
       
            builder.Services.AddDbContext<ECommerceContext>(option => option.UseSqlServer(builder.Configuration.GetConnectionString("constr")));
            builder.Services.AddControllers();        
            var app = builder.Build();
            app.UseCors(c => c.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin());
            app.MapControllers();
            app.Run();
        }
    }
}