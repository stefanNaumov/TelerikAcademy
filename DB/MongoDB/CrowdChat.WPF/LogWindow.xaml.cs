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
using System.Windows.Navigation;
using System.Windows.Shapes;
using CrowdChat.Models;
using CrowdChat.ConsoleUI;

namespace CrowdChat.WPF
{
    /// <summary>
    /// Interaction logic for LogWindow.xaml
    /// </summary>
    public partial class LogWindow : Window
    {
        public LogWindow()
        {
            InitializeComponent();
        }

        public void LogBtn(object sender, RoutedEventArgs e)
        {
            User user = new User()
            {
                UserName = this.UserNameTextBox.Text,

            };
            this.Hide();
            ChatWindow chatWindow = new ChatWindow(user);
            chatWindow.Show();
        }

        public void ShowChatWindow(string userName)
        {
            var currentUser = new User()
            {
                UserName = userName
            };
           
        }
    }
}
