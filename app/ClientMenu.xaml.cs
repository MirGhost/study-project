using System.Windows;

namespace app
{
    /// <summary>
    /// Логика взаимодействия для ClientMenu.xaml
    /// </summary>
    public partial class ClientMenu : Window
    {
        public ClientMenu()
        {
            InitializeComponent();
        }

        private void Click_ExitAccaunt(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Hide();
        }

        private void Click_calendar(object sender, RoutedEventArgs e)
        {
            Calendar calendar = new Calendar();
            calendar.Show();
            Hide();
        }
    }
}
