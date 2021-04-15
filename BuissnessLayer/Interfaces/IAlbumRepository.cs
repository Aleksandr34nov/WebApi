using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuissnesLayer.Interfaces
{
    public interface IAlbumRepository
    {
        public IEnumerable<Album> GetAllItems();
        public Album GetItemById(int directoryId);
        public int AddItem(Album item);
        public int DeleteItem(Album item);
        public Album UpdateItem(int id, string albumTitle, string artist);
    }
}
