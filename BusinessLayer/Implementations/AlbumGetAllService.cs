using System;
using System.Collections.Generic;
using System.Text;
using BusinessLayer.Interfaces;
using DataLayer.Interfaces;
using Domain;

namespace BusinessLayer.Implementations
{
    public class AlbumGetAllService : IAlbumGetAllService
    {
        private readonly IARepo _albumRepo;
        public AlbumGetAllService(IARepo albumRepo)
        {
            _albumRepo = albumRepo;
        }
        public IEnumerable<Album> GetAllItems()
        {
            return _albumRepo.GetAll();
        }
    }
}
