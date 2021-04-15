using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Interfaces
{
    public interface IARepo
    {
        public IEnumerable<Album> GetAll();
        public Album GetById(int directoryId);
        public int Add(Album item);
        public int Delete(int id);
        public Album Update(int id, Album album);
    }
}
