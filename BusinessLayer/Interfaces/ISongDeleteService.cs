using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Interfaces
{
    public interface ISongDeleteService
    {
        public int DeleteItem(int id);
    }
}
