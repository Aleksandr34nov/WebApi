using BuissnesLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuissnesLayer
{
    public class DataManager
    {
        private IAlbumRepository _albumRepository;
        private ISongRepository _songRepository;
        public DataManager(IAlbumRepository albumRepository, ISongRepository songRepository)
        {
            _albumRepository = albumRepository;
            _songRepository = songRepository;
        }

        public IAlbumRepository Albums { get { return _albumRepository; } }
        public ISongRepository Songs { get { return _songRepository; } }
    }
}
