using NUnit.Framework;
using DataLayer.Implementations;
using System;
using System.Collections.Generic;
using System.Text;
using BusinessLayer.Implementations;
using DataLayer;
using DataLayer.Interfaces;
using Domain;
using Microsoft.EntityFrameworkCore;
using Moq;

namespace BuissnessLayerTests
{
    [TestFixture]
    class AlbumTests
    {
        [Test]
        public void GetItemByIdTest()
        {
            Album _Album = new Album();
            _Album.Title = "Covers";
            _Album.AlbumId = 0;
            var aRepo = new Mock<IARepo>();
            aRepo.Setup(x => x.GetById(1)).Returns(_Album);
            var albumGetByIdService = new AlbumGetByIdService(aRepo.Object);
            Assert.AreEqual(albumGetByIdService.GetItemById(1), _Album);
        }

        [Test]
        public void AddItemTest()
        {
            Album _Album = new Album();
            _Album.AlbumId = 0;
            _Album.Title = "Covers";
            var aRepo = new Mock<IARepo>();
            aRepo.Setup(x => x.Add(_Album)).Returns(_Album.AlbumId);
            var albumAddService = new AlbumAddService(aRepo.Object);
            Assert.AreEqual(albumAddService.AddItem(_Album), _Album.AlbumId);
        }

        [Test]
        public void DeleteItem()
        {
            Album _Album = new Album();
            _Album.AlbumId = 0;
            _Album.Title = "Covers";
            var aRepo = new Mock<IARepo>();
            aRepo.Setup(x => x.Delete(_Album.AlbumId)).Returns(_Album.AlbumId);
            var albumDeleteService = new AlbumDeleteService(aRepo.Object);
            Assert.AreEqual(albumDeleteService.DeleteItem(_Album.AlbumId), _Album.AlbumId);
        }

        [Test]
        public void GetAllItems()
        {
            List<Album> _AlbumList = new List<Album>();
            Album _Album1 = new Album();
            Album _Album2 = new Album();
            Album _Album3 = new Album();
            _AlbumList.Add(_Album1);
            _AlbumList.Add(_Album2);
            _AlbumList.Add(_Album3);
            var sRepo = new Mock<IARepo>();
            sRepo.Setup(x => x.GetAll()).Returns(_AlbumList);
            var albumGetAllService = new AlbumGetAllService(sRepo.Object);
            Assert.AreEqual(albumGetAllService.GetAllItems(), _AlbumList);
        }

        [Test]
        public void UpdateItem()
        {
            Album _Album = new Album();
            _Album.AlbumId = 0;
            _Album.Title = "Meteora";
            var aRepo = new Mock<IARepo>();
            aRepo.Setup(x => x.Update(0, _Album)).Returns(_Album);
            var albumUpdateService = new AlbumUpdateService(aRepo.Object);
            Assert.AreEqual(albumUpdateService.UpdateItem(0, _Album), _Album);
        }
    }
}

