using appointment_service.Configuration;
using appointment_service.Persistence;
using appointment_service.Swagger;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Serilog;
using System.Text;


var builder = WebApplication.CreateBuilder(args);


builder.ConfigureDatabase();
builder.AddApplicationServices();  
builder.AddAuth();                
builder.AddNotifications();         

if (args.Contains("-m"))
{
    try
    {
        var migrationApp = builder.Build();
        using var scope = migrationApp.Services.CreateScope();
        var initialiser = scope.ServiceProvider.GetRequiredService<ApplicationDbContextInitializer>();
        await initialiser.InitialiseAsync();
        Log.Information("Database migrated");
        return;
    }
    catch (Exception e)
    {
        Log.Error(e, "Error migrating database");
        throw;
    }
}


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.ConfigureOptions<ConfigureSwaggerOptions>();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowVite", policy =>
    {
        policy.WithOrigins("http://localhost:5173")  // Vite dev server
              .AllowAnyHeader()
              .AllowAnyMethod()
              .AllowCredentials();
    });
});

var app = builder.Build();

app.UseCors("AllowVite");

app.UseSwagger();                   
app.UseSwaggerUI(c =>                
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Appointment API V1");
    c.RoutePrefix = string.Empty;     
});

app.UseHttpsRedirection();

app.UseAuthentication();   
app.UseAuthorization();

app.MapControllers();

app.Run();
app.Run();
