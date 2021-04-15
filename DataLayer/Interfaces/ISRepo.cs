using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Interfaces
{
    public interface ISRepo
    {
        public IEnumerable<Song> GetAll();
        public Song GetById(int directoryId);
        public int Add(Song item);
        public int Delete(int id);
        public IEnumerable<Song> GetByAlbum(string alName);
        public Song Update(int id, Song song);
    }
}
