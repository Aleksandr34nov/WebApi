using System;
using System.Collections.Generic;
using System.Text;
using Domain;

namespace BusinessLayer.Implementations
{
    public interface ISongGetByIdService
    {
        public Song GetItemById(int id);
    }
}
