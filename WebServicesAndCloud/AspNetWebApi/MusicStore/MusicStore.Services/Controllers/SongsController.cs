using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MusicStore.Models;
using MusicStore.Data;
using MusicStore.Data.Repositories;

namespace MusicStore.Services.Controllers
{
    public class SongsController : ApiController
    {
        private IRepository<Song> songs;
        private Repository<Song> repository;

        public SongsController()
            :this(new Repository<Song>())
        {

        }

        public SongsController(Repository<Song> repository)
        {
            // TODO: Complete member initialization
            this.repository = repository;
        }

        [HttpPost]

        public IHttpActionResult Create(Song song)
        {
            if (!this.ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var newSong = new Song()
            {
                Title = song.Title
            };

            this.songs.Add(newSong);
            this.songs.SaveChanges();

            return Ok(newSong);
        }
    }
}
