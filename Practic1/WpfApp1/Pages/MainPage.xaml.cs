using System.Windows.Controls;
using System.Windows;

namespace WpfApp1.Pages
{
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void NavigateToAddClassroom(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddClassroomPage());
        }

        private void NavigateToAddComputer(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddComputerPage());
        }

        private void NavigateToViewClassroom(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ViewClassroomPage());
        }

        private void NavigateToViewComputer(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ViewComputerPage());
        }
    }
}
