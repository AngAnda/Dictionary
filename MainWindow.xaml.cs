using Dicitionary.Views;
using System.Windows;

namespace Dicitionary
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainNavigationFrame.Navigate(new OpeningPage());
        }
    }
}
