using BusinessLayer.Interfaces;
using DataLayer.Interfaces;
using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Implementations
{
    public class AlbumUpdateService : IAlbumUpdateService
    {
        private readonly IARepo _albumRepo;
        public AlbumUpdateService(IARepo albumRepo)
        {
            _albumRepo = albumRepo;
        }
        public Album UpdateItem(int id, Album album)
        {
            return _albumRepo.Update(id, album);
        }
    }
}
