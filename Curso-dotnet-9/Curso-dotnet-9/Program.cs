var builder = WebApplication.CreateBuilder(args);

//Inicio del area de servicios 

builder.Services.AddControllers();
//Fin del area de servicios
var app = builder.Build();


// Inicio del area de middlewares

app.MapControllers();

//app.MapGet("/", () => "Hello World!");

// Fin del area de middlewares
app.Run();
