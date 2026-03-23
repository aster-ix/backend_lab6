using backend_lab6.Interfaces;
using backend_lab6.Repos;
using backend_lab6.Services;

namespace backend_lab6
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddSingleton<IQuestRepo, QuestRepository>();
            builder.Services.AddScoped<IQuestService, QuestService>();

            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

  


            var app = builder.Build();

            app.UseSwagger().UseSwaggerUI();
            app.MapControllers();


            app.MapGet("/", () => Results.Content(File.ReadAllText("index.html"), "text/html")).ExcludeFromDescription();
            


            app.Run();
        }
    }
}
