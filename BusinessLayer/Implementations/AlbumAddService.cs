using System;
using System.Collections.Generic;
using System.Text;
using BusinessLayer.Interfaces;
using DataLayer.Interfaces;
using Domain;

namespace BusinessLayer.Implementations
{
    public class AlbumAddService : IAlbumAddService
    {
        private readonly IARepo _albumRepo;
        public AlbumAddService(IARepo albumRepo)
        {
            _albumRepo = albumRepo;
        }
        public int AddItem(Album item)
        {
            return _albumRepo.Add(item);
        }
    }
}
