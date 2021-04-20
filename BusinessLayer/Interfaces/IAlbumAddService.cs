using System;
using System.Collections.Generic;
using System.Text;
using Domain;

namespace BusinessLayer.Interfaces
{
    public interface IAlbumAddService
    {
        public int AddItem(Album item);
    }
}
