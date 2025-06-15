using API_Clean_Solution.Application.Interfaces;
using API_Clean_Solution.Application.Services;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using project_product_orders.application.Interfaces;
using project_product_orders.Application.Services;
using project_product_orders.domain.Interfaces;
using project_product_orders.Infrastructure.Context;
using project_product_orders.Infrastructure.Repositories;
using Project_Product_Orders.infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Definir nome da política CORS
var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

// Add services to the container
builder.Services.AddControllers();

// Configurar CORS para liberar localhost:4200
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
        policy =>
        {
            policy.WithOrigins("http://localhost:4200")
                  .AllowAnyHeader()
                  .AllowAnyMethod();
        });
});

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "API Produtos", Version = "v1" });
});

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

// Configurar EF Core com DbContext
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(connectionString));

// Registrar repositórios e serviços
builder.Services.AddScoped<IProdutoRepository, ProdutoRepository>();
builder.Services.AddScoped<IProdutoService, ProdutoService>();

builder.Services.AddScoped<IPedidoRepository, PedidoRepository>();
builder.Services.AddScoped<IPedidoService, PedidoService>();

// AutoMapper
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

var app = builder.Build();

// Usar CORS
app.UseCors(MyAllowSpecificOrigins);

// Middleware Swagger para ambiente de desenvolvimento
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
