using BusinessLayer.Interfaces;
using DataLayer.Interfaces;
using Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Implementations
{
    public class SongGetAllService : ISongGetAllService
    {
        private readonly ISRepo _songRepo;
        public SongGetAllService(ISRepo songRepo)
        {
            _songRepo = songRepo;
        }
        public IEnumerable<Song> GetAllItems()
        {
            return _songRepo.GetAll();
        }
    }
}
