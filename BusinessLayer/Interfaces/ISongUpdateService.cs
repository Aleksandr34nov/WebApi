using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Interfaces
{
    public interface ISongUpdateService
    {
        public Song UpdateItem(int id, Song song);
    }
}
