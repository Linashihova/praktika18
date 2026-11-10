using System.Windows;
using System.Windows.Controls;

namespace Airlines_Shihova.Pages
{
    public partial class Main : Page
    {
        public Main()
        {
            InitializeComponent();
        }
        private void search(object sender, RoutedEventArgs e)
        {
            MainWindow.init.OpenPage(new Pages.Ticket(from.Text, to.Text));
        }
    }
}
