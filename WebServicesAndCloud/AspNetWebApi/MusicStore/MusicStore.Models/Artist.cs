using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStore.Models
{
    public class Artist
    {
        public int Id { get; set; }

        [MaxLength(40)]
        public string Name { get; set; }
        [MaxLength(40)]
        public string Country { get; set; }

        public DateTime BirthDate { get; set; }
    }
}
