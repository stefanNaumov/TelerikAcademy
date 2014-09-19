using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStore.Models
{
    public class Song
    {
        public int Id { get; set; }

        [MaxLength(40)]
        public string Title { get; set; }

        [MaxLength(40)]
        public string Genre { get; set; }

        public int Year { get; set; }

        public int? ArtistId { get; set; }

        public virtual Artist Artist { get; set; }
    }
}
