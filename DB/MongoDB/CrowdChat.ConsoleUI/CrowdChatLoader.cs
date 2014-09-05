using System;
using System.Collections.Generic;
using System.Linq;
using CrowdChat.Data;
using CrowdChat.Models;

namespace CrowdChat.ConsoleUI
{
    public class CrowdChatLoader
    {
        private static string connectionString = "mongodb://tarikat:telerik1@ds052827.mongolab.com:52827/crowdchat";
        private static string databaseName = "crowdchat";

        private static CrowdChatDbContext dbContext = new CrowdChatDbContext(connectionString, databaseName);
        private static CrowdChatController chatController = new CrowdChatController(dbContext);

        static void Main()
        {
            CrowdChatDbContext dbContext = new CrowdChatDbContext(connectionString, databaseName);
            CrowdChatController chatController = new CrowdChatController(dbContext);

            GetAllMessages();
        }

        public static void AddMessage()
        {
            var message = new Message()
            {
                PostDate = DateTime.Now,
                Text = Guid.NewGuid().ToString(),
                User = "Tarikat"
            };

            chatController.InsertMessage(message);
        }

        public static void GetAllMessages()
        {
            var messages = chatController.GetAllMessages();

            foreach (var message in messages)
            {
                Console.WriteLine(message);
            }
        }
    }
}
