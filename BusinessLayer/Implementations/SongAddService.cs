using BusinessLayer.Interfaces;
using DataLayer.Interfaces;
using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Implementations
{
    public class SongAddService : ISongAddService
    {
        private readonly ISRepo _songRepo;
        public SongAddService(ISRepo songRepo)
        {
            _songRepo = songRepo;
        }
        public int AddItem(Song item)
        {
            return _songRepo.Add(item);
        }
    }
}
