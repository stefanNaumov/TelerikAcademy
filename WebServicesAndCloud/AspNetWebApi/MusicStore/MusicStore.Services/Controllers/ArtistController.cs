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
    public class ArtistController : ApiController
    {
        private IRepository<Artist> repo;

        public ArtistController()
            :this(new Repository<Artist>())
        {

        }
        public ArtistController(IRepository<Artist> repository)
        {
            this.repo = repository;
        }

        [HttpPost]
        public IHttpActionResult Create(Artist artist)
        {
            if (!this.ModelState.IsValid)
            {
                return BadRequest(this.ModelState);
            }

            var newArtist = new Artist()
            {
                Id = artist.Id,
                Name = artist.Name,
                BirthDate = artist.BirthDate,
                Country = artist.Country
            };

            this.repo.Add(newArtist);
            this.repo.SaveChanges();

            artist.Id = newArtist.Id;

            return Ok(artist);
        }
    }
}