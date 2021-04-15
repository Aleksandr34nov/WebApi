using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Domain;

namespace DataLayer
{
    public class SampleData
    {
        public static void InitData(ASContext context)
        {
            if (!context.Albums.Any())
            {
                context.Albums.Add(new Domain.Album() { Title = "Meteora", Artist = "Linkin Park" });
                context.Albums.Add(new Domain.Album() { Title = "Minutes to Midnight", Artist = "Linkin Park" });
                context.SaveChanges();

                context.Songs.Add(new Domain.Song() { SongTitle = "Don't Stay", AlbumId = context.Albums.First().AlbumId });
                context.Songs.Add(new Domain.Song() { SongTitle = "Somewhere I Belong", AlbumId = context.Albums.First().AlbumId });
                context.Songs.Add(new Domain.Song() { SongTitle = "Given Up", AlbumId = context.Albums.Last().AlbumId });
                context.SaveChanges();
            }
        }
    }
}
