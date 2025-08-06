using Microsoft.EntityFrameworkCore;
using TeacherApi.Data;
using Npgsql; 

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

// Configure PostgreSQL connection
var dbHost = Environment.GetEnvironmentVariable("DB_HOST") ?? "localhost";
var dbPort = Environment.GetEnvironmentVariable("DB_PORT") ?? "5432";
var dbUser = Environment.GetEnvironmentVariable("DB_USER") ?? "postgres";
var dbPassword = Environment.GetEnvironmentVariable("DB_PASSWORD") ?? "Passw0rd"; // Default for local testing
var dbName = Environment.GetEnvironmentVariable("DB_NAME") ?? "teacherdb";

var connectionStringBuilder = new NpgsqlConnectionStringBuilder
{
    Host = dbHost,
    Port = int.Parse(dbPort),
    Username = dbUser,
    Password = dbPassword,
    Database = dbName,
    Pooling = true, // Enable connection pooling
    MinPoolSize = 1,
    MaxPoolSize = 100,
    Timeout = 15, // Connection timeout in seconds
    CommandTimeout = 30 // Command timeout in seconds
};

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(connectionStringBuilder.ConnectionString)
           .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking)); // Good for read-only APIs

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    try
    {
        var context = services.GetRequiredService<AppDbContext>();
        context.Database.Migrate(); 
    }
    catch (Exception ex)
    {
        var logger = services.GetRequiredService<ILogger<Program>>();
        logger.LogError(ex, "An error occurred while migrating or seeding the database.");
    }
}


app.UseAuthorization();

app.MapControllers();

app.Run();