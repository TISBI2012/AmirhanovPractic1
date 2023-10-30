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
using WpfApp1.DataModels;

namespace WpfApp1.Pages
{
    /// <summary>
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            string login = userNameBox.Text;
            string password = userPasswordBox.Password;

            using (var context = new projectWPFEntities())
            {
                var user = context.Users.FirstOrDefault(u => u.name == login && u.password == password);

                if (user != null)
                {
                    var main = (MainWindow)Application.Current.MainWindow;
                    main.MainFrame.Navigate(new MainPage());

                    MessageBox.Show("Вы успешно авторизовались!", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show("Неверное имя пользователя или пароль!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }


        private void RedirectRegistry_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new RegistryPage());

        }

    }
}
