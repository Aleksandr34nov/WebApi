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

        public int DeleteItem(int id)
        {
            return _songRepo.Delete(id);
        }

        public IEnumerable<Song> GetAllItems()
        { 
            return _songRepo.GetAll();
        }

        public Song GetItemById(int id)
        {
            return _songRepo.GetById(id);
        }

        public IEnumerable<Song> GetItemsByAlbum(string alName)
        {
            return _songRepo.GetByAlbum(alName);
        }

        public Song UpdateItem(int id, Song song)
        {
            return _songRepo.Update(id, song);
        }
    }
}
