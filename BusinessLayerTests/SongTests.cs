using NUnit.Framework;
using BuissnesLayer.Implementations;
using DataLayer.Implementations;
using System;
using System.Collections.Generic;
using System.Text;
using BuissnesLayer.Interfaces;
using DataLayer;
using DataLayer.Interfaces;
using Domain;
using Microsoft.EntityFrameworkCore;
using Moq;

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
            var employeeGetService = new EFSongsRepository(sRepo.Object);
            Assert.AreEqual(employeeGetService.GetItemById(1), _song);
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
            var employeeGetService = new EFSongsRepository(sRepo.Object);
            Assert.AreEqual(employeeGetService.AddItem(_song), _song.SongId);
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
            var employeeGetService = new EFSongsRepository(sRepo.Object);
            Assert.AreEqual(employeeGetService.DeleteItem(_song.SongId), _song.SongId);
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
            var employeeGetService = new EFSongsRepository(sRepo.Object);
            Assert.AreEqual(employeeGetService.GetAllItems(), _songList);
        }

        [Test]
        public void GetItemsByAlbumTest()
        {
            List<Song> _songList = new List<Song>();
            Song _song1 = new Song();
            Song _song2 = new Song();
            Song _song3 = new Song();
            _songList.Add(_song1);
            _songList.Add(_song2);
            _songList.Add(_song3);
            var sRepo = new Mock<ISRepo>();
            sRepo.Setup(x => x.GetByAlbum("Meteora")).Returns(_songList);
            var employeeGetService = new EFSongsRepository(sRepo.Object);
            Assert.AreEqual(employeeGetService.GetItemsByAlbum("Meteora"), _songList);
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
            var employeeGetService = new EFSongsRepository(sRepo.Object);
            Assert.AreEqual(employeeGetService.UpdateItem(0, _song), _song);
        }
    }
}
