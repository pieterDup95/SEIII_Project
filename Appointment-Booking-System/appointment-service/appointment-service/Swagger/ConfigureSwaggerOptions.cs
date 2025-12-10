using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using System.Reflection;

namespace appointment_service.Swagger;

public class ConfigureSwaggerOptions : IConfigureOptions<SwaggerGenOptions>
{
    private readonly IConfiguration _configuration;
    private readonly ILogger<ConfigureSwaggerOptions> _logger;

    public ConfigureSwaggerOptions(IConfiguration configuration, ILogger<ConfigureSwaggerOptions> logger)
    {
        _configuration = configuration;
        _logger = logger;
    }

    public void Configure(SwaggerGenOptions options)
    {
        // Swagger document info
        options.SwaggerDoc("v1", new OpenApiInfo
        {
            Title = "Appointment API",
            Version = Assembly.GetExecutingAssembly().GetName().Version?.ToString() ?? "v1",
            Description = "API for managing branches and appointments",
            Contact = new OpenApiContact
            {
                Name = "Your Name",
                Email = "you@example.com"
            }
        });
        options.EnableAnnotations();

        var xmlFile = "appointment-service.xml";
        var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
        if (File.Exists(xmlPath))
        {
            options.IncludeXmlComments(xmlPath, includeControllerXmlComments: true);
        }
        else
        {
            _logger.LogWarning("XML documentation file not found at {XmlPath}", xmlPath);
        }

        // Add JWT Bearer Authentication (this adds the lock button)
        options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
        {
            Name = "Authorization",
            Type = SecuritySchemeType.Http,
            Scheme = "bearer",
            BearerFormat = "JWT",
            In = ParameterLocation.Header,
            Description = """
                Enter your JWT token below (just the token, no 'Bearer ' prefix).
                
                **Example**: `eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.xxxxx.yyyyy`
                """
        });

        options.AddSecurityRequirement(new OpenApiSecurityRequirement
        {
            {
                new OpenApiSecurityScheme
                {
                    Reference = new OpenApiReference
                    {
                        Type = ReferenceType.SecurityScheme,
                        Id = "Bearer"
                    }
                },
                Array.Empty<string>()
            }
        });
    }
}