using BuissnesLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using DataLayer;
using DataLayer.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Domain;

namespace BuissnesLayer.Implementations
{
    public class EFAlbumsRepository : IAlbumRepository
    {
        private readonly IARepo _albumRepo;
        public EFAlbumsRepository(IARepo albumRepo)
        {
            _albumRepo = albumRepo;
        }
        public int AddItem(Album item)
        {
            return _albumRepo.Add(item);
        }

        public int DeleteItem(Album item)
        {
            return _albumRepo.Delete(item);
        }

        public Album GetItemById(int id)
        {
            return _albumRepo.GetById(id);
        }

        public IEnumerable<Album> GetAllItems()
        {
            return _albumRepo.GetAll();
        }

        public Album UpdateItem(int id, string albumTitle, string artist)
        {
            return _albumRepo.Update(id, albumTitle, artist);
        }
    }
}
