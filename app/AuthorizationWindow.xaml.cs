using System.Windows;


namespace app
{


    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void entrance_window(object sender, RoutedEventArgs e)
        {
            Entrance entrance = new Entrance();
            entrance.Show();
            Hide();
        }

    }
}