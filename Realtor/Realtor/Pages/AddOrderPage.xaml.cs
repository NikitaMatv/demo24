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
    /// Логика взаимодействия для AddOrderPage.xaml
    /// </summary>
    public partial class AddOrderPage : Page
    {
        order contextorder;
        public AddOrderPage(order neworder)
        {
            InitializeComponent();
            contextorder = neworder;
            DataContext = contextorder;
            DpDate.SelectedDate = DateTime.Now;
        }

        private void BtSave_Click(object sender, RoutedEventArgs e)
        {
            if(TbAddtes.Text != null && TbAddtes.Text != string.Empty)
            {
                contextorder.orderstatus = "готовится";
                contextorder.paymentstatus = "принят";
                contextorder.paymentmethod = TbPaymetor.Text;
                contextorder.datecreation = DateTime.Now;
                contextorder.addres = TbAddtes.Text;
                App.Db.order.Add(contextorder);
                App.Db.SaveChanges();
                orderpersonlist orderpersonlistnew = new orderpersonlist();
                orderpersonlistnew.orderid = contextorder.orderid;
                orderpersonlistnew.userid = App.authuser.userid;
                App.Db.orderpersonlist.Add(orderpersonlistnew);
                App.Db.SaveChanges();
                NavigationService.Navigate(new ListOrderPage());
            }
 
        }

        private void BtCansel_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ListOrderPage());
        }
    }
}
