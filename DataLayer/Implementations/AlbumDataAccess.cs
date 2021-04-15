using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataLayer.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Implementations
{
    public class AlbumDataAccess : IARepo

    {
        private ASContext _context;

        public AlbumDataAccess(ASContext context)
        {
            _context = context;
        }

        public int Add(Album item)
        { 
            if (item.AlbumId == 0)
                _context.Albums.Add(item);
            else
                _context.Entry(item).State = EntityState.Modified;
            _context.SaveChanges();
            return item.AlbumId;
        }

        public int Delete(int id)
        {
            //_context.Albums.RemoveRange(_context.Albums.Where(c => c.AlbumId == id));
            //_context.SaveChanges();
            //return album.AlbumId;
            var album = _context.Albums.Where(c => c.AlbumId == id).FirstOrDefault();
            if (album != null)
            {
                _context.Songs.RemoveRange(_context.Songs.Where(c => c.AlbumId == id).ToList());
                _context.Albums.Remove(album);
                _context.SaveChanges();
                return album.AlbumId;
            }

            return -1;
        }

        public Album GetById(int Id)
        {
            return _context.Albums.Include(x => x.SongList).FirstOrDefault(x => x.AlbumId == Id);
        }

        public IEnumerable<Album> GetAll()
        {
            return _context.Albums.Include(x => x.SongList).ToList();
        }

        public Album Update(int id, Album album)
        {
            var talbum = _context.Albums.Where(c => c.AlbumId == id).FirstOrDefault();
            talbum.Title = album.Title;
            talbum.Artist = album.Artist;
            _context.SaveChanges();
            return talbum;
        }
    }
}
