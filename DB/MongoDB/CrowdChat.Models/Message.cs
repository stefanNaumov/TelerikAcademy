using System;
using System.Collections.Generic;
using System.Linq;
using MongoDB.Bson;

namespace CrowdChat.Models
{
    public class Message
    {
        public ObjectId Id { get; set; }

        public string Text { get; set; }

        public DateTime PostDate { get; set; }

        public string User { get; set; }
    }
}
