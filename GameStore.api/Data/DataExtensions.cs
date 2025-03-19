using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace GameStore.api.Data;

public static class DataExtensions
{
    public static async Task MigrateDbkAsync(this WebApplication app)
    {
        using var scope = app.Services.CreateScope();
        var dbContext = scope.ServiceProvider.GetRequiredService<GameStoreContext>();
        await dbContext.Database.MigrateAsync();
    }
}
