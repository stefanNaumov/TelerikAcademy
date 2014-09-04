using System;
using System.Collections.Generic;
using System.Linq;
using MongoDB.Driver;
using CrowdChat.Models;

namespace CrowdChat.Data
{
    public class CrowdChatDbContext
    {
        private string connectionString;
        private string dbName;
        private MongoClient client;
        private MongoServer server;

        public CrowdChatDbContext(string connectionString, string database)
        {
            this.connectionString = connectionString;
            this.dbName = database;
            this.client = new MongoClient(this.connectionString);
            this.server = client.GetServer();
        }

        public MongoCollection<User> Users
        {
            get { return this.GetUsers(); }
        }

        public MongoCollection<Message> Messages
        {
            get { return this.GetMessages(); }
        }

        private MongoCollection<User> GetUsers()
        {
            var db = this.server.GetDatabase(this.dbName);
            return db.GetCollection<User>("Users");
        }

        private MongoCollection<Message> GetMessages()
        {
            var db = this.server.GetDatabase(this.dbName);
            return db.GetCollection<Message>("Messages");
        }
    }
}
