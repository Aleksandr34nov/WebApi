using Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Interfaces
{
    public interface ISongGetAllService
    {
        public IEnumerable<Song> GetAllItems();
    }
}
