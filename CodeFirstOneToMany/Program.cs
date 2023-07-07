using CodeFirstOneToMany.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using System.Reflection.Emit;
//using Microsoft.EntityFrameworkCore.Tools;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Connection

//builder.Services.AddDbContext<HotelContext>(op=>op.UseSqlServer(builder.Configuration.GetConnectionString("OneToManyConnection")));
builder.Services.AddDbContext<HotelContext>(op => op.UseSqlServer("data source=LAPTOP-KR3SF32I\\SQLEXPRESS;database=DBAPI;integrated security=true;trustservercertificate=true;"));
//modelBuilder.Ignore<Type>();
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
