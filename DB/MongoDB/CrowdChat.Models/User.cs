using System;
using System.Collections.Generic;
using System.Linq;
using MongoDB.Bson;

namespace CrowdChat.Models
{
    public class User
    {
        ObjectId Id { get; set; }

        public string UserName { get; set; }
    }
}
