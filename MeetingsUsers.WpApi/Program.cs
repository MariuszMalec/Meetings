using MeetingsUsers.WpApi.Context;
using MeetingsUsers.WpApi.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

//to musi byc dla core6
ConfigurationManager configuration = builder.Configuration;
IWebHostEnvironment environment = builder.Environment;
var connectionString = configuration.GetConnectionString("Default");
builder.Services.AddDbContext<MeetingContext>(o => o.UseSqlite(connectionString));


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
