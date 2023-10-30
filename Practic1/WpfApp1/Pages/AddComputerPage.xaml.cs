using System.Windows.Controls;
using System.Windows;
using WpfApp1.DataModels;

namespace WpfApp1.Pages
{
    public partial class AddComputerPage : Page
    {
        public AddComputerPage()
        {
            InitializeComponent();
        }

        private void AddComputer(object sender, RoutedEventArgs e)
        {
            using (var context = new projectWPFEntities())
            {
                var computer = new Computers
                {
                    IP = ipBox.Text,
                    ClassId = int.Parse(classroomIdBox.Text),
                    State = (stateComboBox.SelectedItem as ComboBoxItem).Content.ToString()
                };

                context.Computers.Add(computer);
                context.SaveChanges();

                MessageBox.Show("Компьютер успешно добавлен!", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
        private void GoBack_Click(object sender, RoutedEventArgs e)
        {
            if (this.NavigationService.CanGoBack)
            {
                this.NavigationService.GoBack();
            }
        }

    }
}

