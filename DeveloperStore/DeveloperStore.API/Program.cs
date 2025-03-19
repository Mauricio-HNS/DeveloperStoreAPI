using DeveloperStore.API.Configurations;
using DeveloperStore.API.Data;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Adicionando as configura��es personalizadas
builder.Services.Configure<AppSettings>(builder.Configuration.GetSection("AppSettings"));
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyMethod()
              .AllowAnyHeader();
    });
});

// Configura��o do Swagger
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "DeveloperStore API", Version = "v1" });
});

// Configura��o do banco de dados (Aqui voc� pode configurar o Entity Framework ou outro ORM)
builder.Services.AddDbContext<DeveloperStoreDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Configura��o da autentica��o JWT
var jwtSecret = builder.Configuration["AppSettings:JwtSecret"];
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = false,
            ValidateAudience = false,
            ValidateLifetime = true,
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtSecret))
        };
    });

// Adicionando Controllers
builder.Services.AddControllers();

var app = builder.Build();

// Habilitar CORS
app.UseCors("AllowAll");

// Habilitar autentica��o e autoriza��o
app.UseAuthentication();
app.UseAuthorization();

// Configura��o de Middleware
app.MapControllers();

// Habilitar Swagger
app.UseSwagger();
app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "DeveloperStore API v1"));

app.Run();
