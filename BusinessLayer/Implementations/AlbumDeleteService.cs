using System;
using System.Collections.Generic;
using System.Text;
using BusinessLayer.Interfaces;
using DataLayer.Interfaces;
using Domain;

namespace BusinessLayer.Implementations
{
    public class AlbumDeleteService : IAlbumDeleteService
    {
        private readonly IARepo _albumRepo;
        public AlbumDeleteService(IARepo albumRepo)
        {
            _albumRepo = albumRepo;
        }
        public int DeleteItem(int id)
        {
            return _albumRepo.Delete(id);
        }
    }
}
