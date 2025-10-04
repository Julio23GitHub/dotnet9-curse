using Curso_dotnet_9.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

//Inicio del area de servicios 

builder.Services.AddControllers();

builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer("name=DefaultConnection"));
//Fin del area de servicios
var app = builder.Build();


// Inicio del area de middlewares

app.MapControllers();

//app.MapGet("/", () => "Hello World!");

// Fin del area de middlewares
app.Run();
