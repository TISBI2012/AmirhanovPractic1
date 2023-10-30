using System.Windows.Controls;
using System.Windows;
using WpfApp1.DataModels;
using System.Linq;

namespace WpfApp1.Pages
{
    public partial class ViewComputerPage : Page
    {
        public ViewComputerPage()
        {
            InitializeComponent();
            LoadData(); 
        }

        private void LoadData()
        {
            using (var context = new projectWPFEntities())
            {
                computersDataGrid.ItemsSource = context.Computers.ToList();
            }
        }

        private void RefreshButton_Click(object sender, RoutedEventArgs e)
        {
            LoadData();
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
