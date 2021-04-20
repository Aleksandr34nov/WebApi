using System;
using System.Collections.Generic;
using System.Text;
using Domain;

namespace BusinessLayer.Interfaces
{
    public interface IAlbumGetByIdService
    {
        public Album GetItemById(int id);
    }
}
