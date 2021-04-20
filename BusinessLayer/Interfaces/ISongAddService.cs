using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Interfaces
{
    public interface ISongAddService
    {
        public int AddItem(Song item);
    }
}
