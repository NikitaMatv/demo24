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
    /// Логика взаимодействия для AutorthPage.xaml
    /// </summary>
    public partial class AutorthPage : Page
    {
        public AutorthPage()
        {
            InitializeComponent();
        }
        private void BtAuth_Click(object sender, RoutedEventArgs e)
        {
            if (TbLogin.Text != null && PbPassword.Password != null)
            {
                user users = App.Db.user.FirstOrDefault(x => x.login == TbLogin.Text);
                if (users != null)
                {
                    if (users.userroleid == 3 && users.status != "уволен")
                    {
                        App.authuser = users;
                        NavigationService.Navigate(new ListOrder());
                    }

                }
            }
        }
    }
}
