using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Domain
{
    public class Song
    {
        public int SongId { get; set; }
        public string SongTitle { get; set; }
        public int AlbumId { get; set; }
        [JsonIgnore]
        public Album Album { get; set; }
        public Song() { }
    }
}
