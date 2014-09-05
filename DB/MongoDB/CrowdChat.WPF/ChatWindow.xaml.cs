using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using CrowdChat.Models;
using CrowdChat.Data;

namespace CrowdChat.WPF
{
    /// <summary>
    /// Interaction logic for ChatWindow.xaml
    /// </summary>
    public partial class ChatWindow : Window
    {
        private User user;
        private CrowdChatDbContext dbContext;
        private CrowdChatController chatController;
        private static string connectionString = "mongodb://tarikat:telerik1@ds052827.mongolab.com:52827/crowdchat";
        private static string databaseName = "crowdchat";

        public ChatWindow(User user)
        {
            this.user = user;
            this.dbContext = new CrowdChatDbContext(connectionString, databaseName);
            this.chatController = new CrowdChatController(dbContext);
            InitializeComponent();
        }

        private void PostMessage(object sender, RoutedEventArgs e)
        {
            Message message = new Message()
            {
                Text = this.UserMessage.Text,
                PostDate = DateTime.Now
            };

            this.chatController.InsertMessage(message);
            var currentMessages = this.chatController.GetAllMessages();

            foreach (var post in currentMessages)
            {
                this.ChatMessages.Items.Add(post);
            }
            //this.chatController.GetAllMessages();
        }

        private void GetAllMessages(object sender, RoutedEventArgs e)
        {

        }
    }
}
