using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuissnesLayer.Interfaces
{
    public interface ISongRepository
    {
        public IEnumerable<Song> GetAllItems();
        public Song GetItemById(int directoryId);
        public int AddItem(Song item);
        public int DeleteItem(Song item);
        public IEnumerable<Song> GetItemsByAlbum(int aId);
        public Song UpdateItem(int id, string songTitle, int albumId);
    }
}
