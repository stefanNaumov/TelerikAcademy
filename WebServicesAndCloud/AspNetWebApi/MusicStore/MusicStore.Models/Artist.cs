﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStore.Models
{
    public class Artist
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Country { get; set; }

        public DateTime BirthDate { get; set; }
    }
}
