using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
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

namespace wpf_db
{
    /// <summary>
    /// Логика взаимодействия для Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
            

        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void LogIn_Click(object sender, RoutedEventArgs e)
        {
            var context = new StoreEntities();
            


            if (context.User.Where(c => c.login == login.Text && c.password.Equals(passwordBox.Password)).SingleOrDefault() != null) {
                Hide();
                MainWindow mainw = new MainWindow();
                mainw.Show();
            }
            
            
            
            
        }



        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

    }
}