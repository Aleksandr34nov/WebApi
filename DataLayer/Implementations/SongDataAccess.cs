using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataLayer.Interfaces;
using System.Threading.Tasks;

namespace DataLayer.Implementations
{
    public class SongDataAccess : ISRepo
    {
        private static ASContext _context;
        public SongDataAccess(ASContext context)
        {
            _context = context;
        }
        public int Add(Song item)
        {
            if (item.SongId == 0)
                _context.Songs.Add(item);
            else
                _context.Entry(item).State = EntityState.Modified;
            _context.SaveChanges();
            return item.SongId;
        }

        public int Delete(int id)
        {
            var song = _context.Songs.Where(c => c.SongId == id).FirstOrDefault();
            if (song != null)
            {
                _context.Songs.Remove(song);
                _context.SaveChanges();
                return song.AlbumId;
            }

            return -1;
        }

        public IEnumerable<Song> GetAll()
        {
            return _context.Songs.ToList();
        }

        public Song GetById(int Id)
        {
            return _context.Songs.FirstOrDefault(x => x.SongId == Id);
        }

        public IEnumerable<Song> GetByAlbum(string alName)
        {
            return _context.Songs.Where(c => c.AlbumId == _context.Albums.FirstOrDefault(x => x.Title == alName).AlbumId).ToList();
        }

        public Song Update(int id, Song song)
        {
            var tsong = _context.Songs.Where(c => c.SongId == id).FirstOrDefault();
            //_context.Songs.Where(c => c.SongId == id).FirstOrDefault().SongTitle = songTitle;
            //_context.Songs.Where(c => c.SongId == id).FirstOrDefault().AlbumId = albumId;
            tsong.SongTitle = song.SongTitle;
            tsong.AlbumId = song.AlbumId;
            _context.SaveChanges();
            return tsong;
        }
    }
}
