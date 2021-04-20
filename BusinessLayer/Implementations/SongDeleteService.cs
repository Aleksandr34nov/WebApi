using DataLayer.Interfaces;
using Domain;
using System;
using System.Collections.Generic;
using System.Text;
using BusinessLayer.Interfaces;

namespace BusinessLayer.Implementations
{
    public class SongDeleteService : ISongDeleteService
    {
        private readonly ISRepo _songRepo;
        public SongDeleteService(ISRepo songRepo)
        {
            _songRepo = songRepo;
        }
        public int DeleteItem(int id)
        {
            return _songRepo.Delete(id);
        }
    }
}
