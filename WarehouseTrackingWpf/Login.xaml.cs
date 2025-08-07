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
using System.Windows.Shapes;
using WarehouseTrackingWpf.Account;
using WarehouseTrackingWpf.Interface;

namespace WarehouseTrackingWpf
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        private readonly ILoginService _loginService;

        public Login(ILoginService loginService)
        {
            InitializeComponent();
            _loginService = loginService;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string username = TxtUsername.Text;
            string password = PwdPassword.Password;

            var result = _loginService.Login(username, password);
            MessageBox.Show(result ? "Giriş başarılı" : "Hatalı giriş");
        }
    }
}
