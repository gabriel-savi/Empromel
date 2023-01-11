using Empromel.API.Data.Context;
using Empromel.API.Repositories;
using Empromel.API.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<DataContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("SqlServer"));
}, ServiceLifetime.Transient);

builder.Services.AddTransient<CustomersService>();
builder.Services.AddTransient<ProductsService>();
builder.Services.AddTransient<ExpensesService>();
builder.Services.AddTransient<CustomersRepository>();
builder.Services.AddTransient<ProductsRepository>();
builder.Services.AddTransient<ExpensesRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
