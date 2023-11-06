using Biblioteca.Application;
using Biblioteca.Core;
using Biblioteca.Domain.Interface;
using Biblioteca.Domain.Model;
using Biblioteca.Infrastructure.Data;
using Biblioteca.Infrastructure.Repository;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Injeção de dependencia
builder.Services.AddScoped<ILivroRepository, LivroRepository>();
builder.Services.AddScoped<ILivro, Biblioteca.Application.Livro>();
builder.Services.AddScoped<ILivroService, LivroService>();
builder.Services.AddScoped<IConexaoDB, ConexaoDB>();


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
