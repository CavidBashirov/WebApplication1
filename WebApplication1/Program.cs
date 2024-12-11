﻿var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
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


var port = Environment.GetEnvironmentVariable("PORT") ?? "3000"; // Railway portunu istifadə et
app.Urls.Add($"http://0.0.0.0:{port}");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
