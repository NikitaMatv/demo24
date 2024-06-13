using Admin.Components;
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
    /// Логика взаимодействия для EmployeeListPage.xaml
    /// </summary>
    public partial class EmployeeListPage : Page
    {
        public EmployeeListPage()
        {
            InitializeComponent();
            LvOrder.ItemsSource = App.Db.user.Where(x => x.status != "уволен").ToList();
        }

        private void BtRemove_Click(object sender, RoutedEventArgs e)
        {
            var select = (sender as MenuItem).DataContext as user;
            if(select.userroleid == 1)
            {
                MessageBox.Show("Нельзя уволить администратора");
                return;
            }
            select.status = "уволен";
            App.Db.SaveChanges();
            LvOrder.ItemsSource = App.Db.user.Where(x => x.status != "уволен").ToList();
        }
    }
}
