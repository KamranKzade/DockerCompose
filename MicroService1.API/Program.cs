using MicroService1.API.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<AppDbContext>(opt =>
{
    opt.UseSqlServer(builder.Configuration.GetConnectionString("SqlServer"));
});

var app = builder.Build();

// Configure the HTTP request pipeline. Ve ancaq development ortamda olmasi ucundu,
// production ortamda swagger gorunmur

// if (app.Environment.IsDevelopment() )
// {
//     app.UseSwagger();
//     app.UseSwaggerUI();
// }

//// Productionda da gorunmeyin isteyirikse swaggerin bele yazmaliyiq
app.UseSwagger();
app.UseSwaggerUI();


app.UseAuthorization();

app.MapControllers();

app.Run();
