using System;
using System.Collections.Generic;
using System.Text;
using Domain;

namespace BusinessLayer.Interfaces
{
    public interface IAlbumUpdateService
    {
        public Album UpdateItem(int id, Album album);
    }
}
