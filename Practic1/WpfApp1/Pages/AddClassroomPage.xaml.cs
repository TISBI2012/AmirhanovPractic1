using System.Windows.Controls;
using System.Windows;
using WpfApp1.DataModels;

namespace WpfApp1.Pages
{
    public partial class AddClassroomPage : Page
    {
        public AddClassroomPage()
        {
            InitializeComponent();
        }

        private void AddClassroom(object sender, RoutedEventArgs e)
        {
            using (var context = new projectWPFEntities())
            {
                var classroom = new Classrooms
                {
                    ClassNumber = int.Parse(classNumberBox.Text),
                    ComputerSeats = int.Parse(computerSeatsBox.Text)
                };

                context.Classrooms.Add(classroom);
                context.SaveChanges();

                MessageBox.Show("Класс успешно добавлен!", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
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
