using Realtor.Components;
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

namespace Realtor.Pages
{
    /// <summary>
    /// Логика взаимодействия для ListOrderPage.xaml
    /// </summary>
    public partial class ListOrderPage : Page
    {
        public ListOrderPage()
        {
            InitializeComponent();
            LvOrder.ItemsSource = App.Db.orderpersonlist.Where(x => x.userid == App.authuser.userid).ToList();
        }

        private void AddBt_Click(object sender, RoutedEventArgs e)
        {

                NavigationService.Navigate(new AddOrderPage(new order()));
            
           
        }
    }
}
