using System.Windows;

namespace wpf_db
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

        private void Window_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void Window_MouseDown_1(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            DragMove();
        }


        private void ListVewShanged_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            int index = ListVewShanged.SelectedIndex;
            switch (index)
            {
                case 0:
                    GridPrincipal.Children.Clear();
                    GridPrincipal.Children.Add(new Home());
                    break;
                case 1:
                    GridPrincipal.Children.Clear();
                    GridPrincipal.Children.Add(new Products());
                    break;
                default:
                    GridPrincipal.Children.Clear();
                    GridPrincipal.Children.Add(new Home());
                    break;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Login lg = new Login();
            lg.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
