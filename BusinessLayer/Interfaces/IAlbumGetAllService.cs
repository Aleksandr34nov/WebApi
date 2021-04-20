using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Interfaces
{
    public interface IAlbumGetAllService
    {
        public IEnumerable<Album> GetAllItems();
    }
}
