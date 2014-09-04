using System;
using System.Collections.Generic;
using System.Linq;
using MongoDB.Bson;
using MongoDB.Driver;
using CrowdChat.Models;
using MongoDB.Driver.Builders;

namespace CrowdChat.Data
{
    public class CrowdChatController
    {
        private CrowdChatDbContext dbContext;

        public CrowdChatController(CrowdChatDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void InsertMessage(Message message)
        {
            this.dbContext.Messages.Insert(message);
        }

        public IEnumerable<string> GetAllMessages()
        {
            var query = Query<Message>.Where(mess => mess.Text != null);
            var messages = this.dbContext.Messages.Find(query);
            IList<string> messagesList = new List<string>();

            foreach (var message in messages)
            {
                messagesList.Add(message.User + " " + message.Text);
            }

            return messagesList;
        }
    }
}
