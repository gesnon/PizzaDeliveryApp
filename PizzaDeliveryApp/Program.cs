using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using PizzaDeliveryApp.CustomExceptionMiddleware;
using PizzaDeliveryDB;
using PizzaDeliveryServices.AppSetting;
using PizzaDeliveryServices.Authorization;
using PizzaDeliveryServices.Services;
using System.Text.Json.Serialization;


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
builder.Services.AddCors();
builder.Services.AddControllers().AddJsonOptions(x =>
{
    // serialize enums as strings in api responses (e.g. Role)
    x.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
});
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.Configure<AppSettings>(builder.Configuration.GetSection("AppSettings"));
builder.Services.AddScoped<IJwtUtils, JwtUtils>();
builder.Services.AddScoped<IAccountService, AccountService>();
builder.Services.AddAuthentication();

builder.Services.AddTransient<IIngredientService, IngredientService>();
builder.Services.AddTransient<IAccountService, AccountService>();
builder.Services.AddTransient<IPizzaBaseService, PizzaBaseService>();
builder.Services.AddTransient<IPizzaCharacteristicService, PizzaCharacteristicService>();
builder.Services.AddTransient<IPizzaService, PizzaService>();
builder.Services.AddTransient<IPizzaIngredientService, PizzaIngredientService>();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var dataContext = scope.ServiceProvider.GetRequiredService<ContextDB>();
    dataContext.Database.Migrate();
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors(x => x
        .SetIsOriginAllowed(origin => true)
        .AllowAnyMethod()
        .AllowAnyHeader()
        .AllowCredentials());

app.UseMiddleware<ExceptionMiddleware>();

//app.UseMiddleware<JwtMiddleware>();

//app.UseAuthorization();

app.MapControllers();

app.Run();
