using CargoHub.Api.Data;
using CargoHub.Api.Repositories;
using CargoHub.Api.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("Default")));


builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));


builder.Services.AddScoped<IWarehouseService, WarehouseService>();
builder.Services.AddScoped<IInventoryService, InventoryService>();
builder.Services.AddScoped<IShipmentService, ShipmentService>();
builder.Services.AddScoped<IShipmentService, ShipmentService>();


builder.Services.AddControllers();

var app = builder.Build();


await SeedData.InitializeAsync(app);


app.MapControllers();

app.Run();