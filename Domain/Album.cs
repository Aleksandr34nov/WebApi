using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Album
    {
        public int AlbumId { get; set; }
        public List<Song> SongList { get; set; }
        public string Title { get; set; }
        public string Artist { get; set; }

        public Album() { }
    }
}
