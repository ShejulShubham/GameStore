using GameStore.api.Data;
using GameStore.api.DTOs;
using GameStore.api.Endpoints;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("GameStore");
builder.Services.AddSqlite<GameStoreContext>(connectionString);


var app = builder.Build();

app.MapGamesEndpoints();
app.MapGenresEndpoints();

await app.MigrateDbkAsync();

app.Run();
