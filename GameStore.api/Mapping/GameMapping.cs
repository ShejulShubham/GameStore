using System;
using GameStore.api.DTOs;
using GameStore.api.Entities;

namespace GameStore.api.Mapping;

public static class GameMapping
{
    public static Game ToEntity(this CreateGameDTO game)
    {
        return new Game()
        {
            Name = game.Name,
            GenreId = game.GenreId,
            Price = game.Price,
            ReleaseDate = game.ReleaseDate
        };
    }

    public static GameSummaryDTO ToGameSummaryDTO(this Game game)
    {
        return new GameSummaryDTO(
                game.Id,
                game.Name,
                game.Genre!.Name,
                game.Price,
                game.ReleaseDate
            );
    }

    public static GameDetailsDTO ToGameDetailsDTO(this Game game)
    {
        return new GameDetailsDTO(
                game.Id,
                game.Name,
                game.GenreId,
                game.Price,
                game.ReleaseDate
        );
    }

    public static Game ToEntity(this UpdateGameDTO game, int id)
    {
        return new Game()
        {
            Id = id,
            Name = game.Name,
            GenreId = game.GenreId,
            Price = game.Price,
            ReleaseDate = game.ReleaseDate
        };

    }
}
