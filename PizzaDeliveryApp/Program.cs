using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using PizzaDeliveryApp.CustomExceptionMiddleware;
using PizzaDeliveryDB;
using PizzaDeliveryServices.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "GYMApp", Version = "v1" });

});
builder.Services.AddDbContext<ContextDB>(options => options.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=PizzaDeliveryDB;Trusted_Connection=true"));

builder.Services.AddTransient<IIngredientService, IngredientService>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseMiddleware<ExceptionMiddleware>();

app.UseAuthorization();

app.MapControllers();

app.Run();