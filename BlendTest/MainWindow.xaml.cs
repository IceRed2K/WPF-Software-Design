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

namespace BlendTest
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<User> users { get; set; }
        public MainWindow()
        {
            InitializeComponent();

             users = new List<User>();

            User usr = new User();
            usr.login = "work07@bk.ru";
            usr.pass = "2pac0410";
            usr.cardnum = "4893-47XX-XXXX-2178";
            usr.cardtype = "VISA";
            usr.sub = "Maximum";
            usr.expire = "2019-04-08";

            users.Add(usr);

            DataContext = this;
        }
    }

    class User
    {
        public string login { get; set; }
        public string pass { get; set; }
        public string cardnum { get; set; }
        public string cardtype { get; set; }
        public string sub { get; set; }
        public string expire { get; set; }
    }
}
