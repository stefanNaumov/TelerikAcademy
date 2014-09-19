using MusicStore.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace MusicStore.Services.Models
{
    public class SongModel
    {
        public static Expression<Func<Song, SongModel>> FromMessage
        {
            get
            {
                return s => new SongModel
                {
                    Id = s.Id,
                    Title = s.Title,
                    Genre = s.Genre,
                    Year = s.Year
                };
            }
        }
        public int Id { get; set; }

        [MaxLength(40)]
        public string Title { get; set; }

        [MaxLength(40)]
        public string Genre { get; set; }

        public int Year { get; set; }

    }
}