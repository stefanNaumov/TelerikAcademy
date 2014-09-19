using MusicStore.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace MusicStore.Services.Models
{
    public class ArtistModel
    {
        public static Expression<Func<Artist, ArtistModel>> FromMessage
        {
            get
            {
                return a => new ArtistModel
                {
                    Id = a.Id,
                    Name = a.Name,
                    Country = a.Country,
                    BirthDate = a.BirthDate
                };
            }
        }
        public int Id { get; set; }

        [MaxLength(40)]
        public string Name { get; set; }
        [MaxLength(40)]
        public string Country { get; set; }

        public DateTime BirthDate { get; set; }
    }
}