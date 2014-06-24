﻿using System;
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

namespace TestXAML
{
    /// <summary>
    /// Interaction logic for FreightWindow.xaml
    /// </summary>
    public partial class FreightWindow : Window
    {
        public FreightWindow()
        {
            InitializeComponent();
        }

        private void ProcessCompanyClient(object sender, RoutedEventArgs e)
        {
            this.DefaultType.Header = this.Company.Header;
            this.CompanyName.Visibility = System.Windows.Visibility.Visible;
            this.FirstName.Visibility = System.Windows.Visibility.Collapsed;
            this.LastName.Visibility = System.Windows.Visibility.Collapsed;
            this.Address.Visibility = System.Windows.Visibility.Visible;
            this.ID.Visibility = System.Windows.Visibility.Visible;
            this.Phone.Visibility = System.Windows.Visibility.Visible;
            this.NameInput.Visibility = System.Windows.Visibility.Visible;
            this.LastNameInput.Visibility = System.Windows.Visibility.Collapsed;
        }
        private void ProcessIndividualClient(object sender, RoutedEventArgs e)
        {
            this.DefaultType.Header = this.Individual.Header;
            this.CompanyName.Visibility = System.Windows.Visibility.Collapsed;
            this.FirstName.Visibility = System.Windows.Visibility.Visible;
            this.LastName.Visibility = System.Windows.Visibility.Visible;
            this.Address.Visibility = System.Windows.Visibility.Visible;
            this.NameInput.Visibility = System.Windows.Visibility.Visible;
            this.LastNameInput.Visibility = System.Windows.Visibility.Visible;
        }
        private void ProcesssCompanyStatute(object sender, RoutedEventArgs e)
        {
            NewClient.Click += (send, even) =>
                {
                    DefaultStatute.Header = NewClient.Header;
                };
            VIPClient.Click += (send, even) =>
                {
                    DefaultStatute.Header = VIPClient.Header;
                };
            ClientWithPreferences.Click += (send, even) =>
                {
                    DefaultStatute.Header = ClientWithPreferences.Header;
                };
        }
    }
}
