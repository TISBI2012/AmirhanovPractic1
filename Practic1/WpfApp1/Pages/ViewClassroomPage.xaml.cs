using System.Linq;
using System.Windows;
using System.Windows.Controls;
using WpfApp1.DataModels;

namespace WpfApp1.Pages
{
    public partial class ViewClassroomPage : Page
    {
        public ViewClassroomPage()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            using (var context = new projectWPFEntities())
            {
                classroomsListView.ItemsSource = context.Classrooms.ToList();
            }
        }

        private void GoBack_Click(object sender, RoutedEventArgs e)
        {
            if (this.NavigationService.CanGoBack)
            {
                this.NavigationService.GoBack();
            }
        }
        private void RefreshButton_Click(object sender, RoutedEventArgs e)
        {
            LoadData();
        }
    }
}
