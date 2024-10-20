using Exo.WebApi.Contexts;
using Exo.WebApi.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

// Configuração dos serviços
builder.Services.AddScoped<ProjetoRepository>();
builder.Services.AddDbContext<ExoContext>();

builder.Services.AddControllers();

var app = builder.Build();

app.UseHttpsRedirection();
app.UseAuthorization();

app.MapControllers();

app.Run();
