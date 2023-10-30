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
    public partial class RegistryPage : Page
    {
        public RegistryPage()
        {
            InitializeComponent();
        }

        private void Registry_Click(object sender, RoutedEventArgs e)
        {
            string login = userNameBox.Text;
            string password = userPasswordBox.Password;

            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Пожалуйста, заполните все поля!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            using (var context = new projectWPFEntities())
            {
                if (context.Users.Any(u => u.name == login))
                {
                    MessageBox.Show("Пользователь с таким именем уже существует!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }

                var user = new Users { name = login, password = password };
                context.Users.Add(user);
                context.SaveChanges();
                MessageBox.Show("Вы успешно зарегистрировались!", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
                this.NavigationService.Navigate(new LoginPage());
            }

        }
        private void GoToLoginPage_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new LoginPage());
        }
    }
}
