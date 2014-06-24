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

namespace TestXAML
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonOne_MouseMove_1(object sender, MouseEventArgs e)
        {
            
        }

        private void TransportUnit(object sender, RoutedEventArgs e)
        {
            
        }
        private void UnitType(object sender, RoutedEventArgs e)
        {
            
        }

        private void ShowNewFreightWindow(object sender, RoutedEventArgs e)
        {
            FreightWindow freightWindow = new FreightWindow();
            freightWindow.Show();
        }

        private void Button_MouseMove_1(object sender, MouseEventArgs e)
        {
            Console.Beep();
        }
        
    }
}
