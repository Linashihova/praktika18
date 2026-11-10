using System.Windows;
using System.Windows.Controls;

namespace Airlines_Shihova
{
    public partial class MainWindow : Window
    {
        public static MainWindow init;
        public MainWindow()
        {
            InitializeComponent();
            init = this;
            OpenPage(new Pages.Main());
        }
        public void OpenPage(Page page)
        {
            frame.Navigate(page);
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
