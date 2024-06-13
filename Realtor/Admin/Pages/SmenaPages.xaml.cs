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
    /// Логика взаимодействия для SmenaPages.xaml
    /// </summary>
    public partial class SmenaPages : Page
    {
        public SmenaPages()
        {
            InitializeComponent();
            LvOrder.ItemsSource = App.Db.user.Where(x => x.status != "уволен").ToList();
        }

        private void BtAdd_Click(object sender, RoutedEventArgs e)
        {
            var select = (sender as MenuItem).DataContext as user;
            if (App.Db.userlist.FirstOrDefault(x=>x.shift.dateend  >= DateTime.Now && x.userid == select.userid) != null)
            {
                return;
            }
            if (App.Db.shift.FirstOrDefault(x => x.datestart == DateTime.Now) != null)
            {
                return;
            }
            shift shiftnew = new shift();
            shiftnew.dateend = DateTime.Now.AddDays(1);
            shiftnew.datestart = DateTime.Now;
            App.Db.SaveChanges();
            userlist userlistnew = new userlist();
            userlistnew.shiftid = shiftnew.shiftid;
            userlistnew.userid = select.userid;
            LvOrder.ItemsSource = App.Db.user.Where(x => x.status != "уволен").ToList();
            MessageBox.Show($"{select.person.firstname} добавлене на смену {DateTime.Now} - {DateTime.Now.AddDays(1)}");
        }
    }
}
