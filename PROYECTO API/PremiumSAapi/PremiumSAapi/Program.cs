using Microsoft.EntityFrameworkCore;
using PremiumSAapi.Data;
using PremiumSAapi.Services;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//DBContext
builder.Services.AddDbContext<InventarioContext>(options =>
    options.UseMySql(builder.Configuration.GetConnectionString("DefaultConnection"),
    new MySqlServerVersion(new Version(8, 0, 35)))
    );


//CORS (es para ajustar or�genes a donde ejecutar�s tus formularios (ej. Live Server)
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowFrontend", policy =>
    {
        policy.WithOrigins(
                  "http://127.0.0.1:5500",
                  "http://localhost:5500",
                  "http://127.0.0.1:8080",
                  "http://localhost:8080"
              ) // Orígenes permitidos para servir formularios estáticos
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

//DI
builder.Services.AddScoped<AuthService>();


//builder.Services.AddControllers();
//// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
//builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors("AllowFrontend");

app.UseAuthorization();

app.MapControllers();

app.Run();
