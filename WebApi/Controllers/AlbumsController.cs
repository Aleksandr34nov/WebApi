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
    public class AlbumsController : ControllerBase
    {
        private ASContext _context;
        private DataManager _datamanager;

        public AlbumsController(DataManager dataManager)
        {
            _datamanager = dataManager;
        }
        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<Album> Get()
        {
            List<Album> _albms = _datamanager.Albums.GetAllItems().ToList();
            return _albms;
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public Album Get(int id)
        {
            Album albm = _datamanager.Albums.GetItemById(id);
            return albm;
        }

        // POST api/<ValuesController>
        [HttpPost]
        public ActionResult Post([FromBody] Album album)
        {
            if (_datamanager.Albums.GetItemById(album.AlbumId) != null)
            {
                return this.StatusCode((int)HttpStatusCode.Conflict);
            }
            _datamanager.Albums.AddItem(album);
            return this.Ok();
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Album album)
        {
            if (_datamanager.Albums.GetItemById(id) == null)
            {
                return this.StatusCode((int)HttpStatusCode.NotFound);
            }
            _datamanager.Albums.UpdateItem(id, album);
            return this.Ok();
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _datamanager.Albums.DeleteItem(id);
        }
    }
}
