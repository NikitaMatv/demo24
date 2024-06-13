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

namespace Admin.Pages
{
    /// <summary>
    /// Логика взаимодействия для MainMenuPages.xaml
    /// </summary>
    public partial class MainMenuPages : Page
    {
        public MainMenuPages()
        {
            InitializeComponent();
            ManuFrame.NavigationService.Navigate(new OrderListPage());
        }

        private void BtUserList_Click(object sender, RoutedEventArgs e)
        {
            ManuFrame.NavigationService.Navigate(new EmployeeListPage());
        }

        private void BtSmena_Click(object sender, RoutedEventArgs e)
        {
            ManuFrame.NavigationService.Navigate(new SmenaPages());
        }

        private void BtOrder_Click(object sender, RoutedEventArgs e)
        {
            ManuFrame.NavigationService.Navigate(new OrderListPage());
        }
    }
}
