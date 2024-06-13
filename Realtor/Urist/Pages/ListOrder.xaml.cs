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
using Urist.Comonents;

namespace Urist.Pages
{
    /// <summary>
    /// Логика взаимодействия для ListOrder.xaml
    /// </summary>
    public partial class ListOrder : Page
    {
        public ListOrder()
        {
            InitializeComponent();
            LvOrder.ItemsSource = App.Db.order.Where(x => x.orderstatus == "готовится").ToList();
        }
        private void AddBt_Click(object sender, RoutedEventArgs e)
        {

            var select = (sender as MenuItem).DataContext as order;
            select.orderstatus = "готов";
            App.Db.SaveChanges();
            LvOrder.ItemsSource = App.Db.order.Where(x => x.orderstatus == "готовится").ToList();
        }
    }
}
