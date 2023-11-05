using System.Transactions;
using ECM.Aplicacao.Servicos;
using ECM.Dominio.Interfaces.Repositorios;
using ECM.Dominio.Interfaces.Servicos;
using ECM.infraestrutura.Dados.Repositorios;
using ECM.WebApi.AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAutoMapper(typeof(DomainToPresentention),typeof(PresententionToDomain));
builder.Services.AddAutoMapper(typeof(PresententionToDomain),typeof(DomainToPresentention));

builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IUserRepository, UserRepository>();

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
