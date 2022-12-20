using CodePatternApi.Data.Context;
using CodePatternApi.Factories;
using CodePatternApi.Handlers;
using CodePatternApi.Interfaces.Factories;
using CodePatternApi.Interfaces.Handlers;
using Microsoft.EntityFrameworkCore;
using System;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();


builder.Services.AddDbContext<SqlContext>(x => x.UseSqlServer(builder.Configuration.GetConnectionString("Sql")));
builder.Services.AddScoped<IProductHandler, ProductHandler>();
builder.Services.AddSingleton<IProductFactory, ProductFactory>();
builder.Services.AddSingleton<IGenericFactory, GenericFactory>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors(x => x.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin());
app.UseAuthorization();

app.MapControllers();

app.Run();
