using DataLayer;
using Domain;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using BusinessLayer.Implementations;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlbumsController : ControllerBase
    {
        private ASContext _context;
        //private DataManager _datamanager;
        private AlbumGetAllService _albumGetAllService;
        private AlbumGetByIdService _albumGetByIdService;
        private AlbumAddService _albumAddService;
        private AlbumDeleteService _albumDeleteService;
        private AlbumUpdateService _albumUpdateService;

        public AlbumsController(AlbumGetAllService albumGetAllService, AlbumGetByIdService albumGetByIdService, AlbumAddService albumAddService, AlbumDeleteService albumDeleteService, AlbumUpdateService albumUpdateService)
        {
            _albumGetAllService = albumGetAllService;
            _albumGetByIdService = albumGetByIdService;
            _albumAddService = albumAddService;
            _albumDeleteService = albumDeleteService;
            _albumUpdateService = albumUpdateService;
        }
        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<Album> Get()
        {
            List<Album> _albms = _albumGetAllService.GetAllItems().ToList();
            return _albms;
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public Album Get(int id)
        {
            Album albm = _albumGetByIdService.GetItemById(id);
            return albm;
        }

        // POST api/<ValuesController>
        [HttpPost]
        public ActionResult Post([FromBody] Album album)
        {
            if (_albumGetByIdService.GetItemById(album.AlbumId) != null)
            {
                return this.StatusCode((int)HttpStatusCode.Conflict);
            }
            _albumAddService.AddItem(album);
            return this.Ok();
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Album album)
        {
            if (_albumGetByIdService.GetItemById(id) == null)
            {
                return this.StatusCode((int)HttpStatusCode.NotFound);
            }
            _albumUpdateService.UpdateItem(id, album);
            return this.Ok();
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _albumDeleteService.DeleteItem(id);
        }
    }
}
