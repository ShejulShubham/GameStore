using System;
using GameStore.api.DTOs;
using GameStore.api.Entities;

namespace GameStore.api.Mapping;

public static class GenreMapping
{
    public static GenreDTO ToDTO(this Genre genre)
    {
        return new GenreDTO(genre.Id, genre.Name);
    }

}
