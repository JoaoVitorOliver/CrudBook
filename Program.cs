using Livros.livros.Domain.Repositories;
using Livros.livros.Application.Handlers;
using Livros.livros.Domain.Interfaces;

var builder = WebApplication.CreateBuilder(args);
 
// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddHttpClient();
builder.Services.AddControllers();

builder.Services.AddScoped<BookHandler>();
builder.Services.AddScoped<IBookInterface ,BookRepository>();
 
var app = builder.Build();
 
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
 
app.UseHttpsRedirection();
app.MapControllers()
   .WithOpenApi();
 
app.Run();