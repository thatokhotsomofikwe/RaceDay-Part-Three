using Microsoft.EntityFrameworkCore;
using RaceDay.API.Data;
using RaceDay.API.Services;

public partial class Program {
    private static async Task Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Database connection
        builder.Services.AddDbContext<AppDbContext>(options =>
            options.UseSqlServer(
                builder.Configuration.GetConnectionString("DefaultConnection")));

        // Azure Blob Storage service
        builder.Services.AddSingleton<BlobStorageService>();

        // Session management
        builder.Services.AddDistributedMemoryCache();
        builder.Services.AddSession(options =>
        {
            options.IdleTimeout = TimeSpan.FromMinutes(30);
            options.Cookie.HttpOnly = true;
            options.Cookie.IsEssential = true;
        });

        builder.Services.AddControllers()
            .AddJsonOptions(options =>
            {
                options.JsonSerializerOptions.ReferenceHandler =
                    System.Text.Json.Serialization.ReferenceHandler.IgnoreCycles;
            });

        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        builder.Services.AddHttpClient();

        var app = builder.Build();

        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();
        app.UseSession();
        app.UseAuthorization();
        app.MapControllers();

        // Existing RaceDayDB database is being used.
        // Migrations are temporarily disabled to prevent
        // EF Core from recreating existing tables.

        app.Run();
    }
} // For integration testing

public partial class Program { } // For integration testing