using System;
using System.Collections.Generic;
using System.Text;
using BusinessLayer.Interfaces;
using DataLayer.Interfaces;
using Domain;

namespace BusinessLayer.Implementations
{
    public class AlbumGetByIdService : IAlbumGetByIdService
    {
        private readonly IARepo _albumRepo;
        public AlbumGetByIdService(IARepo albumRepo)
        {
            _albumRepo = albumRepo;
        }
        public Album GetItemById(int id)
        {
            return _albumRepo.GetById(id);
        }
    }
}
