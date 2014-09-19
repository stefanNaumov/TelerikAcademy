using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MusicStore.Models;
using MusicStore.Data;
using MusicStore.Data.Repositories;
using MusicStore.Services.Models;

namespace MusicStore.Services.Controllers
{
    public class SongController : ApiController
    {
        private IRepository<Song> repository;

        public SongController()
            :this(new Repository<Song>())
        {

        }

        public SongController(IRepository<Song> repository)
        {
            // TODO: Complete member initialization
            this.repository = repository;
        }

        [HttpPost]
        public IHttpActionResult Create(SongModel song)
        {
            if (!this.ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var newSong = new Song()
            {
                Id = song.Id,
                Title = song.Title,
                Genre = song.Genre,
                Year = song.Year
            };

            this.repository.Add(newSong);
            this.repository.SaveChanges();

            song.Id = newSong.Id;

            return Ok(song);
        }

        [HttpGet]
        public IQueryable<SongModel> All()
        {
            var songs = this.repository.All().Select(SongModel.FromMessage);

            return songs;
        }
    }
}
