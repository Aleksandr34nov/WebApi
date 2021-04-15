using BuissnesLayer.Interfaces;
using DataLayer.Interfaces;
using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuissnesLayer.Implementations
{
    public class EFSongsRepository : ISongRepository
    {
        private readonly ISRepo _songRepo;
        public EFSongsRepository(ISRepo songRepo)
        {
            _songRepo = songRepo;
        }
        public int AddItem(Song item)
        {
           return  _songRepo.Add(item);
        }

        public int DeleteItem(Song item)
        {
            return _songRepo.Delete(item);
        }

        public IEnumerable<Song> GetAllItems()
        { 
            return _songRepo.GetAll();
        }

        public Song GetItemById(int id)
        {
            return _songRepo.GetById(id);
        }

        public IEnumerable<Song> GetItemsByAlbum(int aId)
        {
            return _songRepo.GetByAlbum(aId);
        }

        public Song UpdateItem(int id, string songTitle, int albumId)
        {
            return _songRepo.Update(id, songTitle, albumId);
        }
    }
}
