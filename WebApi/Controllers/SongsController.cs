using BuissnesLayer;
using DataLayer;
using Domain;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SongsController : ControllerBase
    {
        private ASContext _context;
        private DataManager _datamanager;

        public SongsController(DataManager dataManager)
        {
            _datamanager = dataManager;
        }

        // GET: api/<SongsController>
        [HttpGet]
        public IEnumerable<Song> Get()
        {
            List<Song> _sngs = _datamanager.Songs.GetAllItems().ToList();
            return _sngs;
        }

        // GET api/<SongsController>/5
        [HttpGet("{id}")]
        public Song Get(int id)
        {
            Song _sngs = _datamanager.Songs.GetItemById(id);
            return _sngs;
        }
        
        // POST api/<SongsController>
        [HttpPost]
        public ActionResult Post([FromBody] Song song)
        {
            if (_datamanager.Songs.GetItemById(song.SongId) != null)
            {
                return this.StatusCode((int)HttpStatusCode.Conflict);
            }

            _datamanager.Songs.AddItem(song);
            return this.Ok();
        }

        // PUT api/<SongsController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Song song)
        {
            if (_datamanager.Songs.GetItemById(id) == null)
            {
                return this.StatusCode((int)HttpStatusCode.NotFound);
            }
            _datamanager.Songs.UpdateItem(id, song);
            return this.Ok();
        }

        // DELETE api/<SongsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _datamanager.Songs.DeleteItem(id);
        }
    }
}
