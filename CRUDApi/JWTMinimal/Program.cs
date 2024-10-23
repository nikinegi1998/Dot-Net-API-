using JWTMinimal.Models;
using JWTMinimal.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSingleton<IMovieService, MovieService>();
builder.Services.AddSingleton<IIUserServicce, UserService>();
var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapPost("/create", (Movie movie, IMovieService service) => Create(movie, service));
app.MapGet("/get", (int id, IMovieService service) => get(id, service));
app.MapGet("/getall", (IMovieService service) => GetAll(service));
app.MapPut("/update", (Movie movie, IMovieService service) => Update(movie, service));
app.MapDelete("/delete", (int id, IMovieService service) => Delete(id, service));

app.Run();
