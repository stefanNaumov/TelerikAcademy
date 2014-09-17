using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStore.Models
{
    public class Song
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Gengre { get; set; }

        public int Year { get; set; }

        public int ArtistId { get; set; }

        public virtual Artist Artist { get; set; }
    }
}
