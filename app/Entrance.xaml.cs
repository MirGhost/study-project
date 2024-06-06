using System.Windows;

namespace app
{
    /// <summary>
    /// Логика взаимодействия для entrance.xaml
    /// </summary>
    public partial class Entrance : Window
    {
        public Entrance()
        {
            InitializeComponent();
        }

        private void Button_enter_Click(object sender, RoutedEventArgs e)
        {
            ClientMenu menu = new ClientMenu();
            menu.Show();
            Hide();
        }

        private void Registration(object sender, RoutedEventArgs e)
        {
            MainWindow registr = new MainWindow();
            registr.Show();
            Hide();
        }


    }
}