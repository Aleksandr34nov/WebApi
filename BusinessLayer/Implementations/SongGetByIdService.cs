using DataLayer.Interfaces;
using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Implementations
{
    public class SongGetByIdService : ISongGetByIdService
    {
        private readonly ISRepo _songRepo;
        public SongGetByIdService(ISRepo songRepo)
        {
            _songRepo = songRepo;
        }
        public Song GetItemById(int id)
        {
            return _songRepo.GetById(id);
        }
    }
}
