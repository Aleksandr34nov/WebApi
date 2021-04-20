using NUnit.Framework;
using DataLayer.Implementations;
using System;
using System.Collections.Generic;
using System.Text;
using DataLayer;
using DataLayer.Interfaces;
using Domain;
using Microsoft.EntityFrameworkCore;
using Moq;
using BusinessLayer.Implementations;

namespace BuissnessLayerTests
{
    [TestFixture]
    class SongTests
    {
        [Test]
        public void GetItemByIdTest()
        {
            Song _song = new Song();
            _song.SongTitle = "In The End";
            _song.AlbumId = 0;
            var sRepo = new Mock<ISRepo>();
            sRepo.Setup(x => x.GetById(1)).Returns(_song);
            var songGetByIdService = new SongGetByIdService(sRepo.Object);
            Assert.AreEqual(songGetByIdService.GetItemById(1), _song);
        }

        [Test]
        public void AddItemTest()
        {
            Song _song = new Song();
            _song.SongId = 0;
            _song.AlbumId = 0;
            _song.SongTitle = "In The End";
            var sRepo = new Mock<ISRepo>();
            sRepo.Setup(x => x.Add(_song)).Returns(_song.SongId);
            var songAddService = new SongAddService(sRepo.Object);
            Assert.AreEqual(songAddService.AddItem(_song), _song.SongId);
        }

        [Test]
        public void DeleteItemTest()
        {
            Song _song = new Song();
            _song.SongId = 0;
            _song.AlbumId = 0;
            _song.SongTitle = "In The End";
            var sRepo = new Mock<ISRepo>();
            sRepo.Setup(x => x.Delete(_song.SongId)).Returns(_song.SongId);
            var songDeleteService = new SongDeleteService(sRepo.Object);
            Assert.AreEqual(songDeleteService.DeleteItem(_song.SongId), _song.SongId);
        }

        [Test]
        public void GetAllItemsTest()
        {
            List<Song> _songList = new List<Song>();
            Song _song1 = new Song();
            Song _song2 = new Song();
            Song _song3 = new Song();
            _songList.Add(_song1);
            _songList.Add(_song2);
            _songList.Add(_song3);
            var sRepo = new Mock<ISRepo>();
            sRepo.Setup(x => x.GetAll()).Returns(_songList);
            var songGetAllService = new SongGetAllService(sRepo.Object);
            Assert.AreEqual(songGetAllService.GetAllItems(), _songList);
        }

        [Test]
        public void UpdateItemTest()
        {
            Song _song = new Song();
            _song.SongId = 0;
            _song.AlbumId = 0;
            _song.SongTitle = "In The End";
            var sRepo = new Mock<ISRepo>();
            sRepo.Setup(x => x.Update(0, _song)).Returns(_song);
            var songUpdateService = new SongUpdateService(sRepo.Object);
            Assert.AreEqual(songUpdateService.UpdateItem(0, _song), _song);
        }
    }
}
