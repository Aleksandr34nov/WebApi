using DataLayer.Interfaces;
using Domain;
using System;
using System.Collections.Generic;
using System.Text;
using BusinessLayer.Interfaces;

namespace BusinessLayer.Implementations
{
    public class SongUpdateService : ISongUpdateService
    {
        private readonly ISRepo _songRepo;
        public SongUpdateService(ISRepo songRepo)
        {
            _songRepo = songRepo;
        }
        public Song UpdateItem(int id, Song song)
        {
            return _songRepo.Update(id, song);
        }
    }
}
